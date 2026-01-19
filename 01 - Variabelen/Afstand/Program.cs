namespace Afstand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Afstand in centimeter: ");

            int centimeters = int.Parse(Console.ReadLine());

            // Convert centimeters to feet en inches (1 inch = 2.54 cm, 1 foot = 12 inches)
            double inches = centimeters / 2.54;
            int feet = (int)inches / 12;
            inches = inches % 12; // Get the remaining inches after converting to feet


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{centimeters} cm is gelijk aan {feet} voet en {inches:F2} inch.");
            Console.ResetColor();
        }
    }
}
