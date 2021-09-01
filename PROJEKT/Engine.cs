using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEKT
{

    /// <summary>
    /// klasa z silnikiem gry, odpowiedzialna za poruszanie obiektow
    /// </summary>
    class Engine //poruszanie obiektow
    {
        /// <summary>
        /// lista elementów, które będa poruszane
        /// </summary>
        private List<IMovable> movables;    //lista elementow ktore beda poruszane    


        /// <summary>
        /// lista elementów, które będa poruszane
        /// </summary>
        private long lastTickCount;


        /// <summary>
        /// inicjalizacja nowego elementu listy
        /// </summary>
        public Engine()
        {
            movables = new List<IMovable>();
        }


        /// <summary>
        /// dodawanie do listy
        /// </summary>
        public void RegisteMovable(IMovable movable)
        {
            movables.Add(movable);
        }


        /// <summary>
        /// czas startu gry
        /// </summary>
        public void Start()
        {
            lastTickCount = DateTime.Now.Ticks;
        }


        /// <summary>
        /// oblicza liczbe tikniec, (czas uruchumienia  - czas ostatniego obiektu)
        /// </summary>
        public void OnTick()
        {
            foreach (var movable in movables)
            {
                movable.UpdatePosition(DateTime.Now.Ticks - lastTickCount); //oblicza liczbe tikniec, uruchumienia  - czas ostatniego obiektu
            }

            lastTickCount = DateTime.Now.Ticks;
        }
    }
}
