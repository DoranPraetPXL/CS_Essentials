namespace Gemiddelde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Berekening van het gemiddelde van 4 gehele getallen");
            Console.WriteLine();
            Console.ResetColor();
            Console.Write("Geef getal 1: ");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("Geef getal 2: ");
            int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.Write("Geef getal 3: ");
            int.TryParse(Console.ReadLine(), out int thirdNumber);
            Console.Write("Geef getal 4: ");
            int.TryParse(Console.ReadLine(), out int fourthNumber);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Het gemiddelde van {firstNumber}, {secondNumber}, {thirdNumber} en {fourthNumber} is {(firstNumber + secondNumber + thirdNumber + fourthNumber) / 4f}");
            Console.ResetColor();
        }
    }
}
