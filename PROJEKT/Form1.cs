using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms.VisualStyles;
using PROJEKT.Properties;

namespace PROJEKT
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// określenie pliku zapisu wyników z gry
        /// </summary>
        private const string Path = "HighScore.dat";
        /// <summary>
        /// główny timer gry
        /// </summary>
        private Timer mainTimer = new Timer();
        /// <summary>
        /// zmienna typu Engine
        /// </summary>
        private Engine engine;
        /// <summary>
        /// liczba punktów, wartosc początkowa 0
        /// </summary>
        private int points = 0; //punkty
        /// <summary>
        /// odliczacz czasu,  wartosc początkowa 0
        /// </summary>
        int stopwatch = 0; //odliczacz czasu


        /// <summary>
        /// Konstruktor klasy Form1; rozpoczyna inicjowanie komponentów 
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            scores = LoadScoresFromFile(Path);
            mainTimer.Interval = 20;         
            mainTimer.Tick+=MainTimerOnTick;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {        
            Application.ApplicationExit +=  ApplicationOnApplicationExit;
        }

        private void ApplicationOnApplicationExit(object sender, EventArgs e)
        {
            StoreHighScores(Path);
        }




        /// <summary>
        /// metoda odpowiedzialna za magzynowanie wyników w pliku
        /// </summary>
        /// <param name="path"></param>
        private void StoreHighScores(string path)
        {
            using (Stream saveFileStream = File.Create(path))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(saveFileStream, scores);              
            }
        }




        /// <summary>
        /// dodaje obiekty o parametrach: liczba obiektów, rozmiar, gdzie; przekazywnaie parametru do simlpenovecontrol; jeden losowy obiekt staje się kamieniem
        /// </summary>
        private void RestartObjects()
        {
            var list = PrepareObjects(6, 80, panelMainGame); // dodaje obiekty o parametrach liczba obiuektow; ozmiar wpx; gdzie
            Random r = new Random();
            foreach (var control in list)
            {
                SimpleMoveControl movable = new SimpleMoveControl(control); //przekazywnaie parametru do simlpenovecontrol
                movable.Speed = (float)(1 + r.NextDouble()); //rozne predkosci                
                engine.RegisteMovable(movable);
                control.Tag = movable;
            }

            Control rock = list[r.Next(list.Count)];
            (rock.Tag as SimpleMoveControl).IsRock = true; // jeden losowy obiekt staje się kamieniem
            (rock as PictureBox).Image = Properties.Resources.rock;
        }



        /// <summary>
        ///  usuwanie obiektow z poprzedniej gry, op ile się odbyła, odpowiedzialna za rozmieszczenie obiektów w różnych, losowych miejscach; dodanie zdarzenia, dodanie kontrolki do listy parent i do swojej listy
        /// </summary>
        /// <param name="count"></param>
        /// <param name="parent"></param>
        /// <param name="size"></param>
        private IList<Control> PrepareObjects(int count,int size,Control parent)
        {
            // usuwanie obiektow z poprzedniej gry, op ile była
            for (int i = parent.Controls.Count -1; i > 0; i--)
            {
                if(parent.Controls[i] is PictureBox)
                    parent.Controls.RemoveAt(i);
            }

            IList <Control> ret = new List<Control>(); //lista kontrolek
            Random r = new Random(); //start z innej pozycji
            for (int i = 0; i < count; i++) //petla przechodzaca po kazdym obikecie
            {
                var ctrl = new PictureBox()
                {
                   
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.StretchImage,                    
                    Image = Properties.Resources.kloda,
                    
                   
                    Location = new Point(this.Width + size + r.Next(this.Width), //rozna lokacja, aby wszystki nie wyszly na raz 
                        (int) (i * (this.Height / (float) count))), // rozmieszczenie
                    Size = new Size(size, size),                    
                };
                ctrl.MouseDown+=CtrlOnMouseDown; //zdarzenie gdy zostanie kontrolka kliknieta
                parent.Controls.Add(ctrl); //dodanie kontrolki do listy parent
                ret.Add(ctrl); //dodanie kontrolki do swojej listy
            }

            return ret;          
        }



        /// <summary>
        /// obługa MouseEventu; gdy zostanie kliknięty kamień - koniec gry; dodawanie punktów, znikanie kłody po kliknięciu
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void CtrlOnMouseDown(object sender, MouseEventArgs e)
        {
         
            ControlMoveAdapter control = ((sender as Control).Tag as ControlMoveAdapter);
            if (control.IsRock)
                HandleEndGame(); // konie gry gdy kamien
            else
            {
                points++;
                labelPoints.Text = points.ToString();
                control.Reset(); // znikanie klinkej klody
            }

        }


        /// <summary>
        /// metoda odpowiedzialna za zakończenie gry, sprawdzenie, czy został pobity rekord; dodawanie danych do wyników; usuwanie najmniejszego wyniku, aby zrobić miejsce dla nowego
        /// </summary>
        private void HandleEndGame()
        {
            mainTimer.Stop();
            timer3.Stop();
            MessageBox.Show("Koniec gry! Twoje punkty: " + points);

            if (IsHighScore())
            {
                if (scores.Max(z => z.Score) < points)
                MessageBox.Show("Nowy rekord!");
                var dlg = new PromptDialog();
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    scores.Add(new HighScoreEntry(points,dlg.Response, stopwatch));
                    if ( scores.Count > maxHighScoreEntries)
                        // usuwanie namniejszego dotychczas wyniku zeby zrobic miejsce dla nowego
                        scores.Remove(scores.Where(x=>x.Score == scores.Min(z=>z.Score)).First());   
                }
            }

            panelMainGame.Hide();
            button1.Show();
        }

        /// <summary>
        /// sprawdzenie czy sa jeszcze miejsca na nowe punkty lub  nowy wynik jest lepszy niz dotychczas najgorszy
        /// </summary>
        private bool IsHighScore()
        {
            // jesli sa jeszcze miejsca na nowe punkty lub  nowy wynik jest lepszy niz dotychczas najgorszy
            return scores.Count < maxHighScoreEntries || maxHighScoreEntries <= scores.Min(x => x.Score);
        }


        /// <summary>
        /// timer oblicza liczbe tikniec, (czas uruchumienia  - czas ostatniego obiektu)
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void MainTimerOnTick(object sender, EventArgs e)
        {            
            engine.OnTick();
        }


        /// <summary>
        /// button rozpoczynająct grę, z prostą animacją bunifu
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
                bunifuTransition1.ShowSync(button1);
            else
                bunifuTransition1.HideSync(button1);

            StartGame();
            timer3.Start();
        }



        /// <summary>
        /// rozpoczęcie gry, zerowanie punktów i stopera
        /// </summary>
        private void StartGame()
        {
            engine = new Engine();
            RestartObjects();

            panelMainGame.Show();            
            engine.Start();
            mainTimer.Start();

            points = 0;
            labelPoints.Text = points.ToString();
            stopwatch = 0;     
        }



        /// <summary>
        /// maksymalna liczba przechowaywanych rekodow
        /// </summary>
        private readonly int maxHighScoreEntries = 10; // maksymalna liczba przechowaywanych rekodow
        /// <summary>
        /// rekordy graczy
        /// </summary>
        private IList<HighScoreEntry> scores = Enumerable.Empty<HighScoreEntry>().ToList(); // rekordy graczy


        /// <summary>
        /// button odpowiedzialny za pokazywanie wyników
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            HandleHighScores();
        }


        /// <summary>
        /// pokazywanie wyników, z prostą animacją bunifu; dodawanie wyników do listBoxScores i ich sortowanie
        /// </summary>
        private void HandleHighScores()
        {
            if (panel1.Visible == false)
                bunifuTransition1.ShowSync(button2);
            else
                bunifuTransition1.HideSync(button2);
            

            listBoxScores.Items.Clear();
            listBoxScores.Items.AddRange(scores.OrderByDescending(x=>x.Score).ToArray());
            panelHighScores.Show();

            
        }



        /// <summary>
        /// lista przechowywująca wyniki z pliku
        /// </summary>
        /// <param name="path"></param>
        private IList<HighScoreEntry> LoadScoresFromFile(string path)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream str = File.OpenRead(path))
            {
                return (List<HighScoreEntry>) bf.Deserialize(str);
            }
        }

        /// <summary>
        /// przycisk odpowiedzialny za zamknięcie aplikacji z prostą animacją bunifu
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
                bunifuTransition1.ShowSync(button3);
            else
                bunifuTransition1.HideSync(button3);

            Application.Exit();

        }




        /// <summary>
        /// przycisk odpowiedzialny za ukrycie wyników
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            HideHighScores();
        }


        /// <summary>
        /// metoda ukrywająca panel z wynikami, odkrywająca przycisk2
        /// </summary>
        private void HideHighScores()
        {
            panelHighScores.Hide();
            button2.Show();
        }

        private void listBoxScores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPoints_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// timer odliczający sekundy, które są ukazywane w label
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void timer3_Tick(object sender, EventArgs e)
        {
            stopwatch++;
            timer3.Interval = 999;
            labelcounter.Text = stopwatch.ToString(); 

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelHighScores_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// przycisk odpowiedzialny za zamknięcie aplikacji podczas gry
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        /// <summary>
        /// przycisk odpowiedzialny za koniec gry, podczas gry
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            HandleEndGame();

        }
    
    }
}
