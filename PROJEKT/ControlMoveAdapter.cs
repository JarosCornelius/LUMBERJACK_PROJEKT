using System;
using System.Windows.Forms;

namespace PROJEKT
{

    /// <summary>
    /// klasa przenoszenia ruchu
    /// </summary>
    abstract class ControlMoveAdapter : IMovable
    {
        /// <summary>
        /// określenie co ma być zwrócone i co ma stać się z wartością przypisaną do właściwości Left
        /// </summary>
        public int Left
        {
            get
            {
                return Control.Left;
            }

            set
            {
                Control.Left = value;
            }
        }


        /// <summary>
        /// określenie co ma być zwrócone i co ma stać się z wartością przypisaną do właściwości Top
        /// </summary>
        public int Top
        {
            get
            {
                return Control.Top;
            }

            set
            {
                Control.Top = value;
            }
        }

        /// <summary>
        /// zdefiniowanie kontrolki
        /// </summary>
        public Control Control { get; set; }


        /// <summary>
        /// zmiana polozenia obiektow na współrzednej x oraz y, ruch po krzywej
        /// </summary>
        /// <param name="dt"></param>
        public abstract void UpdatePosition(long dt);

        /// <summary>
        /// sprawdzenie czy obiekt wyszedl poza pole gry
        /// </summary>
        public abstract void Reset();

        /// <summary>
        /// sprawdzenie czy obiekt jest skałą
        /// </summary>
        public bool IsRock { get; set; } // czy obiekt  jest skala


        /// <summary>
        /// przypisanie Control do control
        /// </summary>
        public ControlMoveAdapter(Control control)
        {
            Control = control;
        }
    }
}
