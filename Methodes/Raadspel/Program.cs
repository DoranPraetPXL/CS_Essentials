using System.Diagnostics.Metrics;

namespace Raadspel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaratie van variabelen.
            int randomNumber;
            Random random = new Random();

            //Willekeurig getal genereren
            randomNumber = random.Next(1, 101);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Raadspel");
            Console.WriteLine();
            StartCheck(randomNumber);
            Console.ResetColor();
        }

        private static void StartCheck(int searchedInteger)
        {
            int answerInteger;
            int counter = 0;

            do
            {
                counter++;
                //Vraag antwoord via inputbox
                answerInteger = GiveAnswer();

                //Controleer antwoord
                if (answerInteger == searchedInteger)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"U heeft het getal geraden in {counter} beurten");
                } else
                {
                    CheckAnswer(answerInteger, searchedInteger);
                }
            } while (answerInteger != searchedInteger);
        }

        private static int GiveAnswer()
        {
            string answer;
            int retVal;
            bool okResult;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Geef een getal tussen 1 en 100: ");
                answer = Console.ReadLine();
                okResult = int.TryParse(answer, out retVal);
            } while (okResult == false || retVal < 1 || retVal > 100);
            return retVal;
        }

        private static void CheckAnswer(int answer, int solution)
        {
            if (answer < solution)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Raad hoger!");
            }
            else if (answer > solution)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Raad lager!");
            }
        }
    }
}
