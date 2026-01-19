namespace Ondernemingsnummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ondernemingsnummer: ");
            string input = Console.ReadLine();
            
            while (input.ToUpper() != "STOP")
            {
                switch (IsVATNumber(input))
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Het ondernemingsnummer is correct!");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Het ondernemingsnummer is NIET correct!");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Het ondernemingsnummer is niet correct gevormd! Het formaat moet BE0.xxx.xxx.xxx zijn.");
                        break;
                }
                Console.ResetColor();
                Console.Write("Ondernemingsnummer: ");
                input = Console.ReadLine();
            }
        }

        static byte IsVATNumber(string vatNumber)
        {
            uint number;

            // BE0457.033.811
            // 4570338 11

            // Foute vorm
            if (!vatNumber.Substring(0, 3).ToUpper().Equals("BE0") || // niet startend met "BE "
                vatNumber.Length != 14 || // of niet de juiste lengte
                !uint.TryParse(vatNumber.Substring(3).Replace(".", ""), out number)) // of is geen getal 
            {
                return 3;
            }

            // Juiste vorm
            // Ondernemingsnummer splitsen.
            long vatNumberPart1 = long.Parse(number.ToString().Substring(0, 7));
            byte vatNumberPart2 = byte.Parse(number.ToString().Substring(7, 2)); // controlenummer

            //Ondernemingsnummer controleren.
            if ((97 - (vatNumberPart1 % 97)) == vatNumberPart2)
                return 1; // Juist nummer.
            else
                return 2; // Fout nummer.
        }
    }
}
