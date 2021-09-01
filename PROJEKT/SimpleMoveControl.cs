using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PROJEKT
{
    /// <summary>
    /// klasa odpowiadająca za ruch obiektow po krzywej, zmiane predkosci, sprawdzenie czy obiekt wyszedl poza pole
    /// </summary>
    class SimpleMoveControl : ControlMoveAdapter
    {
        /// <summary>
        /// sprawdza czy obiekt bedzie sie poruszal po krzywej czy nie
        /// </summary>
        public bool CurvedMove { get; set; }//czy obiekt bedzie sie poruszal po krzywej czy nie 
        /// <summary>
        /// predkosc poruszania sie obiektow
        /// </summary>
        public float Speed { get; set; } //predkosc  
        /// <summary>
        /// ilość czasu, który upłynął od rozpoczęcia ruchu obiektu(gry)
        /// </summary>
        private long tillStart = 0; //ile czasu uplynelo od rozpoczecia ruchu obiektu(gry)
        /// <summary>
        /// wspolczynnik zwiekszajacy predkosc o 10%
        /// </summary>
        private float speedChangeCoeff = 1.1f; //zwiekszamy predkosc o 10%
        /// <summary>
        /// co ile tikniec zwiekszana ma byc predkosc
        /// </summary>
        private long speedIncreaseInterval = 20000000; //co ile tikniec zwikeszana ma byc predkosc
        /// <summary>
        /// aktualny poziom trudnosci
        /// </summary>
        private int level = 0; //poziom trudnosci aktualny
        /// <summary>
        /// losowe pojawienie sie obiektów
        /// </summary>
        private Random r;
        /// <summary>
        /// wspolczynnik krzywosci
        /// </summary>
        private float curveCoeff;
        /// <summary>
        /// maksymalny poziom(predkosc) poruszania sie obieków
        /// </summary>
        private int maxLevel = 18;


        /// <summary>
        /// sprawdza czy obiekt bedzie sie poruszal po krzywej, czy nie
        /// </summary>
        /// <param name="control"></param>
        public SimpleMoveControl(Control control)
            : base(control)
        {
            r = new Random(this.Control.GetHashCode());
            Speed = 1;     //predkosc        
            CurvedMove = false; //czy obiekt bedzie sie poruszal po krzywej czy nie 
        }


        /// <summary>
        /// funkja kwadratowa odpowiadajaca za poruszanie obiektu po krzywej
        /// </summary>
        /// <param name="x"></param>
        float f(float x)
        {
            return curveCoeff * x * x / 6;
        } //funckja kwadratowa ze wspolczynnikiem curvecoeff



        /// <summary>
        /// zmiana polozenia obiektow na współrzednej x oraz y, ruch po krzywej
        /// </summary>
        /// <param name="dt"></param>
        public override void UpdatePosition(long dt)
        {

            tillStart += dt;
            CheckBounds();
            UpdateMotion(dt);

            float coeff = 0.00001f; //zwolnienie
            float bas = (dt * coeff * Speed); //odpowiedzialny za zmiane polozenia obiektu w plaszczyxnie poziomej (x)

            if (CurvedMove) //ruch po krzywej
            {
                float dx = bas;
                Left -= (int)(dx); //zmiana na wspol poziomej
                //Top += (int)(0.05 * (curveCoeff * bas * bas + bas * curveCoeff));
                float dy = coeff * (Top - f(Left));
                Top += (int)dy; //zmiana na wspol pionowej
                // Left -= Math.Abs((int)(10*Speed *(Math.Sin(dt*coeff))));
                //Top += (int)(10 *Speed *(Math.Sin(dt * coeff)));
            }
            else //ruch po poziomej
            {
                Left -= (int)(bas);
                // Top -= (int)(dt * coeff * Speed);
            }
        }



        /// <summary>
        /// wspolczynnik losowania albo dodatni albo ujemny
        /// </summary>
        private int nextSign()
        {
            return r.Next(2) == 0 ? -1 : 1; //wspolczynnik losowania albo dodatni albo ujemny
        }




        /// <summary>
        /// modyfikacja ruchu obiektu w zaleznosci ile czasu minelo
        /// </summary>
        /// <param name="dt"></param>
        private void UpdateMotion(long dt)//modyfikacja ruchu obiektu w zaleznosci ile czasu minelo
        {
            if (level >= maxLevel)
                return; //jezeli osiagnie maksymalny poziom to nie zwiekszamy juz poziomu
            if (tillStart / speedIncreaseInterval > (tillStart - dt) / speedIncreaseInterval)
            {
                Speed *= speedChangeCoeff;
                level++;


                if (!CurvedMove)
                {
                    CurvedMove = (r.NextDouble() <= (level / (double)maxLevel)); //losowanie czy ma sie poruszac po krzywej, im wiekszy level tym wieksze prawdopodobienstwo
                    UpdateCurveCoeff();
                }
            }
        }




        /// <summary>
        /// ustawienie wspolczynnika krzywosci
        /// </summary>
        private void UpdateCurveCoeff()
        {
            curveCoeff = (float)(nextSign() * r.NextDouble() * 2); //wspolczynniik krzywosci
        }



        /// <summary>
        /// sprawdzenie czy obiekt wyszedl poza pole gry
        /// </summary>
        private void CheckBounds() //sprawdza czy obiekt wyszedl za ramki
        {
            if (Left <= 0)
                Reset();
            else if (Top + Control.Height <= 0)
                Top = Control.Parent.Height - 1;
            else if (Top >= Control.Parent.Height)
                Top = 1;
        }



        /// <summary>
        /// resetowanie obiektow
        /// </summary>
        public override void Reset()
        {
            Left = Control.Parent.Width;
            UpdateCurveCoeff();
        }
    }
}
