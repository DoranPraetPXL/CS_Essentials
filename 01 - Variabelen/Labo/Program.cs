namespace Labo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Minecraft Pickaxes
            //		stap 1) Durabilities
            int stoneDur = 131;
            int ironDur = 250;
            int diamondDur = 1561;
            int netheriteDur = 2031;

            //		stap 2) Hoeveel blokken worden er gemijnd?
            Console.Write("Hoeveel blokken wil je mijnen met een stone pickaxe? ");
            string input = Console.ReadLine();
            int.TryParse(input, out int parsedBlocks);

            // 2. Laat de speler blokken mijnen
            //		stap 3) Berekeningen
            int remainingStone = stoneDur - parsedBlocks;
            int remainingIron = ironDur - parsedBlocks;
            int remainingDiamond = diamondDur - parsedBlocks;
            int remainingNetherite = netheriteDur - parsedBlocks;

            //		stap 4) Resultaten tonen
            Console.WriteLine($"\nStone: {remainingStone} durability over");
            Console.WriteLine($"Iron: {remainingIron} durability over");
            Console.WriteLine($"Diamond: {remainingDiamond} durability over");
            Console.WriteLine($"Netherite: {remainingNetherite} durability over");

            // 3. Je eigen Pickaxe
            //		stap 5) Eigen tool
            Console.Write("\nMaak je eigen tool - geef een naam: ");
            string customName = Console.ReadLine();

            Console.Write("Geef de maximale durability (geheel getal): ");
            string customInput = Console.ReadLine();
            int.TryParse(customInput, out int parsedCustom);

            int remainingCustom = parsedCustom - parsedBlocks;
            Console.WriteLine($"\nJe tool '{customName}' heeft nog {remainingCustom}" +
             "durability over na {parsedBlocks} blokken.");
        }
    }
}
