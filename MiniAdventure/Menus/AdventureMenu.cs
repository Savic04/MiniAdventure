using MiniAdventure.Entities;
using MiniAdventure.Fighting;
using MiniAdventure.Paths;
namespace MiniAdventure.Menus;
public class AdventureMenu
{
    public static void AdventureSelection(Player player,Mobs mob)
    {
        Console.WriteLine("Yoou started your adventure Press [1] to continue");
        Console.WriteLine("[1] Path of Marstrand!  \n[2] Main Menu");
        string choiseOfPath = Console.ReadLine()??"";
        switch (choiseOfPath)
        {
            case "1":
                FirstPath.firstPath();
                Fight.StartFight(player, mob);
                break;
            case "2":
                Console.WriteLine("Return to main menu");
                return;
                break;
        }
    }
}



