

using Bits___Bites.Postentyp;

namespace Bits___Bites;

internal class Bestellung
{
    public bool BitAndBiteCard { get; set; }

    internal double BerechneBestellung()
    {
        double gesamtPreis = 0;

        foreach (var item in Posten.bestellposten)
        {
            gesamtPreis += item.BerechnePreis();
        }
        if (BitAndBiteCard)
        {
            double einProzent = gesamtPreis / 100;
            double _5Prozent = einProzent * 5;
            double _5ProzentNiedriger = gesamtPreis - _5Prozent;
            return _5ProzentNiedriger;
        }
        else
        {
            return gesamtPreis;
        }
    }

    public void AddBestellung()
    {
        BitAndBiteCard = true;

        Getraenk getraenk1 = new Getraenk(true, true, "Bergenbier", 2);
        Getraenk getraenk2 = new Getraenk(false, true, "Coca Cola", 1.3);

        Posten.bestellposten.Add(getraenk1);
        Posten.bestellposten.Add(getraenk2);

        Essen essen1 = new Essen(true, "Shaorma", 4.5);
        Essen essen2 = new Essen(false, "Kebab", 3.5);

        Posten.bestellposten.Add(essen1);
        Posten.bestellposten.Add(essen2);

        Ticket ticket1 = new Ticket(new DateTime(2023, 9, 23), 180, "Kurzticket", 0.5);
        Ticket ticket2 = new Ticket(new DateTime(2023, 9, 23), 1440, "Datenticket", 0.3);

        Posten.bestellposten.Add(ticket1);
        Posten.bestellposten.Add(ticket2);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n\nEs wurden folgendes bestellt:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n1 {getraenk1.Name};\tAlkoholisch:{getraenk1.Alkoholisch};\tBefindet sich die Bestellung in Happy Hour? {getraenk1.Happyhour};\tPreis: {getraenk1.BerechnePreis()}€\n\n1 {getraenk2.Name};\tAlkoholisch: {getraenk2.Alkoholisch};\tBefindet sich die Bestellung in Happy Hour? {getraenk2.Happyhour};\tPreis: {getraenk2.BerechnePreis()}€\n\n1 {essen1.Name};\tExtragross: {essen1.Extragross};\t\t\t\t\t\t\t\tPreis: {essen1.BerechnePreis()}€\n\n1 {essen2.Name};\tExtragross: {essen2.Extragross};\t\t\t\t\t\t\t\tPreis: {essen2.BerechnePreis()}€\n\n1 {ticket1.Name};\tStartzeit: {ticket1.Startzeit};\tGültigkeitsdauer: {ticket1.Minuten} Minuten;\t\tPreis: {ticket1.BerechnePreis()}€\n\n1 {ticket2.Name};\tStartzeit: {ticket2.Startzeit};\tGültigkeitsdauer: {ticket2.Minuten} Minuten;\t\tPreis: {ticket2.BerechnePreis()}€");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"\n\nVerfügt der Kunde über eine BitAndBiteCard? {BitAndBiteCard}");
    }
}
