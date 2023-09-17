

namespace Bits___Bites.Postentyp;

internal class Essen : Posten
{
    public Essen(bool extragross, string name, double preis) : base (name, preis)
    {
        this.Extragross = extragross;
    }

    public bool Extragross { get; set; }

    internal override double BerechnePreis()
    {
        if (Extragross) 
        {
            double einProzent = Preis / 100;
            double _20Prozent = einProzent * 20;
            double _20ProzentErhoben = Preis + _20Prozent;
            return _20ProzentErhoben;
        }
        else
        {
            return this.Preis;
        }
    }
}
