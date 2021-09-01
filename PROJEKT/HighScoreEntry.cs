using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKT
{
    [Serializable]


    /// <summary>
    /// klasa reprezentujaca jeden rekord gracza
    /// </summary>
    class HighScoreEntry // struktura reprezentuje jeden rekord gracza
    {
        /// <summary>
        /// punkty
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// imie gracza
        /// </summary>
        public string Nick { get; set; }


        /// <summary>
        /// czas gry
        /// </summary>
        public int Time { get; set; }


        /// <summary>
        /// wpisywanie danych
        /// </summary>
        /// <param name="nick"></param>
        /// <param name="score"></param>
        /// <param name="time"></param>
        public HighScoreEntry(int score, string nick, int time)
        {
            Score = score;
            Nick = nick;
            Time = time;
        }


        /// <summary>
        /// sposob wypisania danych
        /// </summary>
        public override string ToString()
        {
            return "Gracz " + Nick + " zdobyl " + Score + " punktow" + " w czasie " + Time + " sekund";
        }
    }
}
