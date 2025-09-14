using MiniAdventure.Entities;
using MiniAdventure.Fighting;

namespace MiniAdventure.Menus;

public class MainMenu
{
    public static Player player;

    public static void StartMainMenu()
    {


        Console.WriteLine("Welcome to the game MiniAdventure! Please choose a username: ");
        string userName = Console.ReadLine().ToLower();
        Console.Clear();
        string className = "";
        Console.WriteLine($"Welcome {userName} Please choose a game character 1. [Mage] or 2. [Warrior]");               
  
        bool validAnswer = false;
        while (validAnswer != true)
        {
            className = Console.ReadLine()?? ""; 

            if (className == "1")

            {
                Console.WriteLine($"Perfect choice! {userName} Now let your journey as: |Mage| begin! ");
                validAnswer = true;
            }
            else if (className == "2")
            {
                Console.WriteLine($"Great choise! {userName} Now let the amazing journey as: |Warrior| begin!");
                validAnswer = true;
            }
            else
                Console.WriteLine("Enter an valid Character!");

        }
        Player player = new Player(className);
        Console.WriteLine();
        Console.WriteLine($" Because you choose {className}\n Your starting values are, ");
        player.Stats();
        Mobs mob = new Mobs();
        bool GameIsRunning = true;
        while (GameIsRunning)
        {

            Console.WriteLine("\n-------- Main Menu --------");
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("\n[1] Start the Adventure");
            Console.WriteLine("[2] Visit the Store! Not yet opened");
            Console.WriteLine("[3] Show Stats");


            Console.WriteLine("[5] Exit Game");

            Console.WriteLine("\nEnter your choice:");

            string menuSelection = Console.ReadLine()??"";


            switch (menuSelection)
            {
                case "1":
                    AdventureMenu.AdventureSelection(player, mob);  
                    if(player.CurrentHP <= 0)
                    {
                        Console.WriteLine("Game over bitch! Get good! shit player, especially robin!");
                        Environment.Exit(0);
                    }
                    break;
                //case "2":
               //     Store.VisitStore(player);               öppnar senare
                  // break;
                case "3":
                    Console.WriteLine("====CLASS-STATS====");
                    player.Stats();                    
                    Console.WriteLine("Press enter to continue");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "5":
                    Console.WriteLine("Exiting game. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine($"Try again! {userName}");
                    break;
            }
        }                 
    }
}
// The main menu loop
