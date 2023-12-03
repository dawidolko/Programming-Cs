namespace lekcja29
{
    abstract class Postac
    {
        public Postac(string imie, int punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
        }
        public abstract void Ruch();
        public string imie;
        public int punktyHP;
    }
}