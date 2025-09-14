using MiniAdventure.Entities;

namespace MiniAdventure.Fighting;

public class Fight
{
    public static bool StartFight(Player player, Mobs mob)
    {
        mob = Mobs.GetRandomMob(Mobs.mobsArray);
        Console.WriteLine($"\nA wild {mob.MobName} appears! Prepare to fight!");
        int round = 1;

        while (player.CurrentHP > 0 && mob.MobHp > 0)
        {
            Random random = new Random();

            Console.WriteLine($"\n--- Round {round} ---");
            Console.WriteLine($"You have {player.CurrentHP} HP left.");
            Console.WriteLine($"The {mob.MobName} has {mob.MobHp} HP left.");
            Console.WriteLine("\nChoose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.WriteLine("3. Run Away");
            string choiceOfAction = Console.ReadLine() ?? "";

            switch (choiceOfAction)
            {
                case "1":

                    int randomDamage = random.Next(4, 17);

                    mob.MobHp -= randomDamage;
                    Console.WriteLine($"You attacked the {mob.MobName} and dealt {randomDamage} damage!");

                    if (mob.MobHp > 0)
                    {
                        player.CurrentHP -= mob.MobDamage;
                        Console.WriteLine($"The {mob.MobName} retaliated and hit you for {mob.MobDamage} damage!");
                    }
                    break;

                case "2":
                    player.Heal(15);
                    Console.WriteLine($"You healed 15 HP. Your HP is now {player.CurrentHP}.");

                    player.CurrentHP -= mob.MobDamage;
                    Console.WriteLine($"The {mob.MobName} seized the opportunity and hit you for {mob.MobDamage} damage while you were healing!");
                    break;

                case "3":
                    Console.WriteLine("You managed to run away safely.");
                    return false;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            if (mob.MobHp <= 0)
            {
                int goldGained = 5;
                Console.WriteLine($"\nCongratulations! You have defeated the {mob.MobName} and won the fight!");
                player.Gold += goldGained;
                Console.WriteLine($"You gained {goldGained} gold. Your total gold is: {player.Gold}.");

                Console.WriteLine("Press any key to continue!");
                Console.ReadKey();

                return true;
            }
            else if (player.CurrentHP <= 0)
            {
                Console.WriteLine($"\nYou have been defeated by the {mob.MobName}!");
                return false;
            }

            round++;
        }
        return false;
    }

    public void StartFight()
    {      
    }
}
    





