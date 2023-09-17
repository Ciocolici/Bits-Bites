

namespace Bits___Bites.Postentyp;

internal class Ticket : Posten
{
    public Ticket(DateTime startzeit, int minuten, string name, double preis) : base (name, preis)
    {
        this.Startzeit = startzeit;
        this.Minuten = minuten;
    }

    public DateTime Startzeit { get; set; }
    public int Minuten { get; set; }

    internal override double BerechnePreis()
    {
        double minutenPreis = Minuten * Preis;
        return minutenPreis;
    }

    

}
