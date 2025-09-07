Console.WriteLine("Welcome to the game MiniAdventure! Please choose a username: ");
string userName = Console.ReadLine().ToLower();


string Characters = "";
Console.WriteLine($"Welcome {userName} Please choose a game character [Mage] or [Warrior]");

bool validAnswer = false;
while (validAnswer != true)
{

    Characters = Console.ReadLine().ToLower();
    if (Characters == "mage")

    {
        Console.WriteLine($"Perfekt choice! {Characters} Now let the journey begin {userName} ");
        validAnswer = true;
    }
    else if (Characters == "warrior")
    {
        Console.WriteLine($"Great choise! Warrior Now let the amazing journey begin {userName}");
        validAnswer = true;
    }
    else
        Console.WriteLine("Enter an valid Character!");

}
Console.WriteLine();
Console.WriteLine($"Because you choose {Characters}");


