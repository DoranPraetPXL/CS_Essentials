namespace Rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = ReadNumber(1);
            int secondNumber = ReadNumber(2);
            char calculation = ReadCalculation();

            Console.WriteLine($"\n{firstNumber} {calculation} {secondNumber} = {Calculate(firstNumber, secondNumber, calculation)}");
            Console.ReadKey();
        }

        static int ReadNumber(int order)
        {
            int input;
            do
            {
                Console.Write($"Geef getal {order}: ");

            } while (!int.TryParse(Console.ReadLine(), out input));
            return input;
        }

        static char ReadCalculation()
        {
            string input;
            do
            {
                Console.Write("Geef bewerking: ");
                input = Console.ReadLine();
            } while (input != "+" && input != "-" && input != "*" && input != "/");
            return char.Parse(input);
        }

        static double Calculate(int firstNumber, int secondNumber, char calculation)
        {
            switch (calculation)
            {
                case '+':
                    return firstNumber + secondNumber;
                case '-':
                    return firstNumber - secondNumber;
                case '*':
                    return firstNumber * secondNumber;
                case '/':
                    return firstNumber / secondNumber;
                default:
                    return 0;
            }
        }
    }
}
