using System.Security.Cryptography.X509Certificates;

namespace lekcja31
{
    abstract class Postac : IAtakMagiczny,IAtakMieczem
    {
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }
        public abstract void Ruch();

         void IAtakMagiczny.Atak(int pkt)
        {
            Console.WriteLine("Atak magiczny");
        }

        public void AtakMieczem(int pkt)
        {
            Console.WriteLine("Atak mieczem");
        }

        void IAtakMieczem.AtakMieczem(int pkt)
        {
            throw new NotImplementedException();
        }

        void IAtakMieczem.Atak(int pkt)
        {
            Console.WriteLine("Atak mieczem");
        }

        public string imie;
        public int punktyHP;
    }
}