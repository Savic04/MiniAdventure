using MiniAdventure.Entities;
using MiniAdventure.Fighting;
using MiniAdventure.Paths;


namespace MiniAdventure.Menus;

public class AdventureMenu
{
    public static void AdventureSelection(Player player,Mobs mob)
    {
        Console.WriteLine("Choose your adventure! You have 3 different paths to choose of");
        Console.WriteLine("[1] Path of Marstrand    \n[2] Path of Excelssior   \n[3] Path of Void");
        string choiseOfPath = Console.ReadLine();

        switch(choiseOfPath)
        { 
             
           case "1":
           
                FirstPath.firstPath();
                Fight.StartFight(player, mob);

              break;

           case "2":
                SecondPath.secondPath();
                   
                break;

           case "3":
                ThirdPath.thirdPath();
                break;

        }

    }
}



