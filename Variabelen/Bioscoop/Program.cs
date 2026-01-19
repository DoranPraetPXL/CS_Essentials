namespace Bioscoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double normalPrice = 9.1;
            const double reductionPrice = 8.1;
            const double studentPrice = 6.9;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kinepolis ticket boot");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- normale tarief bedraagt: 9,10 euro");
            Console.WriteLine("- kortingstarief bedraagt: 8,10 euro");
            Console.WriteLine("- studententarief bedraagt: 6,90 euro");
            Console.WriteLine();
            Console.Write("Geef aantal ticket voor normale tarief: ");
            int normal = int.Parse(Console.ReadLine());
            Console.Write("Geef aantal ticket voor kortingstarief: ");
            int reduction = int.Parse(Console.ReadLine());
            Console.Write("Geef aantal ticket voor studententarief: ");
            int student = int.Parse(Console.ReadLine());
            double normalTotal = normal * normalPrice;
            double reductionTotal = reduction * reductionPrice;
            double studentTotal = student * studentPrice;
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"Uw afrekening");
            Console.WriteLine();
            Console.WriteLine($"Normale tarief: {normal} x {normalPrice} = {normalTotal}");
            Console.WriteLine($"Kortingstarief: {reduction} x {reductionPrice} = {reductionTotal}");
            Console.WriteLine($"Studententarief: {student} x {studentPrice} = {studentTotal}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Totaal: {normalTotal + reductionTotal + studentTotal}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
