internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Geef het aantal seconden in: ");
        int totalSeconds = int.Parse(Console.ReadLine());

        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;

        Console.WriteLine($"H: {hours}, M: {minutes}, S: {seconds}");
    }
}