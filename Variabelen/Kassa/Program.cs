namespace Kassa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PXL catering kassa");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Geef de prijs van het product: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Geef het aantal: ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Het totaalbedrag is {price * amount}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
