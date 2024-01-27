using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwiumA
{
    public abstract class Ksztalt
    {
        protected double obwod;
        protected string nazwa;

        protected Ksztalt(string nazwa)
        {
            this.nazwa = nazwa;
            this.obwod = 0;
        }

        public abstract void ObliczObwod();
        public abstract void WprowadzDane();

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine($"Nazwa kształtu: {nazwa}, Obwód: {obwod}");
        }
    }
}
