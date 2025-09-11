using MiniAdventure.Entities;

namespace MiniAdventure.Fighting;


public class Fight
{
    public Fight(Player player, Mobs randomMob)
    {
    }

    public static bool StartFight(Player player, Mobs mob)
    {
        Console.WriteLine($"\nA wild {mob.MobName} appears! Prepare to fight!");
        int round = 1;

        while (player.CurrentHP > 0 || mob.MobHp > 0)
        {
           
            bool menuIsRunning = true;
            while (menuIsRunning == true)

            {
                Console.WriteLine($"\n--- Round {round} ---");
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                Console.WriteLine("3. Run Away");
                string choiceOfAction = Console.ReadLine();  
                if (choiceOfAction == "1" || choiceOfAction == "2" || choiceOfAction == "3")
                {

                    switch (choiceOfAction)
                    {
                        case "1":
                            Console.WriteLine($"You attacked {mob.MobName} and made {player.Damage} But you took {mob.MobDamage}!");
                            mob.MobHp -= player.Damage;
                            player.CurrentHP -= mob.MobDamage;                            

                            if (mob.MobHp <= 0)
                            {
                                int GoldGained = 5;
                                Console.WriteLine($"Congratulations you have won the fight and have been rewarded {GoldGained}.");
                                player.Gold += GoldGained;
                                Console.WriteLine($"Your total amount of gold is: {player.Gold}");
                                menuIsRunning = false;
                                return menuIsRunning;
                            }
                            else if (player.CurrentHP <= 0)
                            {
                                Console.WriteLine($"You lost the fight");
                            }
                            else
                            {
                                Console.WriteLine($"\n{mob.MobName} has {mob.MobHp} HP left.");
                                Console.WriteLine($"\nYou have {player.CurrentHP} HP left.");
                            }

                            break;
                        case "2":
                            player.Heal(15);
                            Console.WriteLine($"{player} healed 15 hp and now your Hp is {player.CurrentHP}");
                            break;
                        case "3":
                            Console.WriteLine("You ran away bitch get off the game  | CTRL + ALT + F4 |");
                            break;
                    }
                    round++;
                }
            }
        }
        return false;
    }

    public void StartFight()
    { 
    }


}


