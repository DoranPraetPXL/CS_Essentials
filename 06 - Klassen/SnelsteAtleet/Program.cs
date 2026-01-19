
using SnelsteAtleet.Models;

namespace SnelsteAtleet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int time = 0;
            Athlete fastestAthlete = null; 

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Snelste atleet");
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.WriteLine();
                Console.Write("Naam atleet: ");
                name = Console.ReadLine();

                if (!name.Equals("STOP", StringComparison.OrdinalIgnoreCase))
                {
                    do
                    {
                        Console.Write("Looptijd: ");
                    } while (!int.TryParse(Console.ReadLine(), out time));

                    if (fastestAthlete != null && time < fastestAthlete.Time)
                    {
                        fastestAthlete = new Athlete();
                        fastestAthlete.Name = name;
                        fastestAthlete.Time = time;
                    }
                }
            } while (!name.Equals("STOP", StringComparison.OrdinalIgnoreCase));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($"De snelste atleet is {fastestAthlete.Name} met {fastestAthlete.Time} seconden");

            //Gehele deling en uren, minuten worden uit de tijd gehaald
            TimeSpan duration = TimeSpan.FromSeconds(fastestAthlete.Time);

            Console.WriteLine($"{duration.Hours} uren");
            Console.WriteLine($"{duration.Minutes} minuten");
            Console.WriteLine($"{duration.Seconds} seconden");
        }
    }
}
