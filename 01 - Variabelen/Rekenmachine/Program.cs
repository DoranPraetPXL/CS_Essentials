namespace Rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eerste getal: ");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("Tweede getal: ");
            int.TryParse(Console.ReadLine(), out int secondNumber);

            double result = firstNumber + secondNumber;

            Console.Write($"Resultaat: {firstNumber} + {secondNumber} = {result}");
        }
    }
}
