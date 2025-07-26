namespace Bits___Bites;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\r\n _             ()     _             \r\n|_) o _|_ _    /\\/   |_) o _|_ _  _ \r\n|_) |  |__>    \\/\\   |_) |  |_(/__> \r\n                                    \r\n                                    \r\n                                    \r\n");

        Bestellung bestellung = new Bestellung();
        bestellung.AddBestellung();

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"\n\nGesamtpreis: {bestellung.BerechneBestellung()}€\n\n");
        Console.ForegroundColor= ConsoleColor.Black;

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Drücke eine Taste, um das Programm zu beenden.");
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.Black;
    }
}
