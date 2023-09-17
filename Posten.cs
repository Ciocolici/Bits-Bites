

using System.ComponentModel;

namespace Bits___Bites;

abstract class Posten
{
    public string Name { get; protected set; }
    public double Preis { get; protected set; }

    public static List<Posten> bestellposten = new List<Posten>();

    public Posten(string name, double preis)
    {
        this.Name = name;
        this.Preis = preis;
    }

    internal virtual double BerechnePreis()
    {
        double gesamtPreis = 0;
        foreach (object Posten in bestellposten) 
        {
            gesamtPreis = gesamtPreis + Preis;
        }
        return gesamtPreis;
    }
}
