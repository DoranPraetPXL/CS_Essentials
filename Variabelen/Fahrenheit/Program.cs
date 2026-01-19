namespace Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.Write("Temperatuur in °F: ");
            
            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"Temperatuur in °C: {celsius:F2}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                Console.ResetColor();
            }
        }
    }
}
