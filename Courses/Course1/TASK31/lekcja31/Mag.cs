using lekcja31;

namespace lekcja31
{
    sealed class Mag : Postac
    {
        public Mag(string imie, int punktyHP, int mana) : base(imie, punktyHP)
        {
            this.imie = imie;
            this.punktyHP = punktyHP;
            this.mana = mana;
        }

        public override void Ruch()
        {
            Console.WriteLine("Ruch Maga");
        }

        public int mana;
    }
}