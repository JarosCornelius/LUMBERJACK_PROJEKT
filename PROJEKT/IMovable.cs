namespace PROJEKT
{

    /// <summary>
    /// interfejs definiujacy metode UpdatePosition odpowiadajcą za zmiane polozenia obiektow, oraz Left, Top, określające położenie obiektu
    /// </summary>
    internal interface IMovable
    {
        /// <summary>
        /// zdefiniowanie właściwości Left, okreslenie polozenia obiektu w poziomie
        /// </summary>
        int Left { get; set; }


        /// <summary>
        /// zdefiniowanie właściwości Top, okreslenie polozenia obiektu w pionie
        /// </summary>
        int Top { get; set; }


        /// <summary>
        /// zdefiniowanie metody, zmiana polozenia obiektow na współrzednej x oraz y, ruch po krzywej
        /// </summary>
        /// <param name="dt"></param>
        void UpdatePosition(long dt); //up[datowanie obiektow dt-zmaiana jednostek  czasu w tikach
    }
}