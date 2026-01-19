using FavorieteAlbum.Models;

namespace FavorieteAlbum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*** Favoriete album ***");
            Console.WriteLine();
            Console.ResetColor();

            Album favoriteAlbum = new Album();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wat is de naam van je favoriete album?");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            favoriteAlbum.Name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Op welke datum werd het uitgebracht?");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            favoriteAlbum.ReleaseDate = DateTime.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hoeveel nummers staan er op het album?");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            favoriteAlbum.Songs = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hoe lang duurt het album in totaal? (minuten)");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            favoriteAlbum.Duration = TimeSpan.FromMinutes(double.Parse(Console.ReadLine()));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Naam:           {favoriteAlbum.Name}");
            Console.WriteLine($"Uitgebracht:    {favoriteAlbum.ReleaseDate.ToLongDateString()}");
            Console.WriteLine($"Aantal nummers: {favoriteAlbum.Songs}");
            Console.WriteLine($"Totale duur:    {favoriteAlbum.Duration.ToString(@"hh\:mm")}");
            Console.ResetColor();
        }
    }
}
