namespace Lekcja18
{
    class Czlowiek
    {
        public string imie;
        private int wiek;
        /* public void SetWiek(int wiek)
         {
             if (wiek >=0) {
                 this.wiek = wiek;
             }else
             {
                 wiek = Math.Abs(wiek);
                 this.wiek = wiek;
             }
         }
         public int GetWiek()
         {
             return wiek;
         }*/
        //public int wiek { get; set; }

        public int Wiek
        {
            get { return wiek; }
            set
            {

                if (value >= 0 && value <= 200)
                {
                    wiek = value;
                }
                else
                {
                    wiek = 0;
                }
            }
        }
    }
}
