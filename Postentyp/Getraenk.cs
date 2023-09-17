
namespace Bits___Bites.Postentyp;

internal class Getraenk : Posten
{
    public Getraenk(bool alkoholisch, bool happyhour, string name, double preis) : base (name, preis)
    {
        this.Alkoholisch = alkoholisch;
        this.Happyhour = happyhour;
    }

    public bool Alkoholisch { get; set; }
    public bool Happyhour { get; set; }

    internal override double BerechnePreis()
    {
        if ( Alkoholisch && Happyhour)
        {
            double einProzent = Preis / 100;
            double _75Prozent = einProzent * 75;
            return _75Prozent;
        }
        else
        {
            return this.Preis;
        }
    }
}
