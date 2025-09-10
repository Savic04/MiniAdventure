using MiniAdventure.Entities;

namespace MiniAdventure.Menus;

public class Store
{
       public static void VisitStore(Player player)
    {
        Console.WriteLine("\n-------- The Store --------");
        Console.WriteLine($"Welcome! You have {player.Gold} gold. What would you like to buy?");
        Console.WriteLine("[1] Potion (+25 HP) - 10 gold");
        Console.WriteLine("[2] Sharpening Stone (+5 Damage) - 20 gold");
        Console.WriteLine("[3] Leave");

        string selection = Console.ReadLine();

        switch (selection)
        {
            case "1":
                if (player.Gold >= 10)
                {
                    player.Gold -= 10;
                    player.Heal(25);
                    Console.WriteLine("You bought a Potion! Your HP has been restored by 25.");
                }
                else
                {
                    Console.WriteLine("You don't have enough gold for that!");
                }
                break;
            case "2":
                if (player.Gold >= 20)
                {
                    player.Gold -= 20;
                    
                    player.Damage += 5;
                    Console.WriteLine("You bought a Sharpening Stone! Your damage has increased by 5.");
                }
                else
                {
                    Console.WriteLine("You don't have enough gold for that!");
                }
                break;
            case "3":
                Console.WriteLine("You leave the store.");
                break;
            default:
                Console.WriteLine("That's not a valid option.");
                break;
        }
    }
    }

