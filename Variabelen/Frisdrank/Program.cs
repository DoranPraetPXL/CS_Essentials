namespace Frisdrank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine($"Ingeworpen bedrag: {2:c}");
            Console.Write("Prijs van de gekozen frisdrank: € ");
            decimal price = decimal.Parse(Console.ReadLine());

            int change = 200 - (int)(price * 100);
            Console.WriteLine($"Wisselgeld: {change / 100M:c}");

            int coins = change / 100;
            Console.WriteLine($"Munten van 1 euro: {coins}");
            change -= 100;

            coins = change / 50;
            Console.WriteLine($"Munten van 50 cent: {coins}");
            change -= coins * 50;

            coins = change / 20;
            Console.WriteLine($"Munten van 20 cent: {coins}");
            change -= coins * 20;

            coins = change / 10;
            Console.WriteLine($"Munten van 10 cent: {coins}");
            change -= coins * 10;

            coins = change / 5;
            Console.WriteLine($"Munten van 5 cent: {coins}");
            change -= coins * 5;

            coins = change / 2;
            Console.WriteLine($"Munten van 2 cent: {coins}");
            change -= coins * 2;

            coins = change;
            Console.WriteLine($"Munten van 1 cent: {coins}");

            //Alternatief wannneer je niet met 100 wil vermenigvuldigen.
            //Probleem hier is de afronding!

            //const double cent50 = 0.5;
            //const double cent20 = 0.2;
            //const double cent10 = 0.1;
            //const double cent5 = 0.05;
            //const double cent2 = 0.02;

            //double price = double.Parse(Console.ReadLine());
            //double change = 2 - price;
            //Console.WriteLine($"Wisselgeld: {change:c}");

            //double coins = (int)change;
            //Console.WriteLine($"Munten van 1 euro: {coins}");
            //change -= 1;

            //coins = (int)(change / cent50);
            //Console.WriteLine($"Munten van 50 cent: {coins}");
            //change -= coins * cent50;

            //coins = (int)(change / cent20);
            //Console.WriteLine($"Munten van 20 cent: {coins}");
            //change -= coins * cent20;

            //coins = (int)(change / cent10);
            //Console.WriteLine($"Munten van 10 cent: {coins}");
            //change -= coins * cent10;

            //coins = (int)(change / cent5);
            //Console.WriteLine($"Munten van 5 cent: {coins}");
            //change -= coins * cent5;

            //coins = (int)(change / cent2);
            //Console.WriteLine($"Munten van 2 cent: {coins}");
            //change -= coins * cent2;

            //coins = change;
            //Console.WriteLine($"Munten van 1 cent: {coins}");
        }
    }
}
