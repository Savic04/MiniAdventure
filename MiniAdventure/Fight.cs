

using MiniAdventure.Entities;

namespace MiniAdventure;


public class Fight
{
    public Fight(Player player, Mobs randomMob)
    {
    }

    public static bool StartFight(Player player, Mobs mob)
    {
        System.Console.WriteLine($"\nA wild {mob.MobName} appears! Prepare to fight!");
        int round = 1;

        while (player.Hp > 0 || mob.MobHp > 0)
        {
           
            bool menuIsRunning = true;
            while (menuIsRunning == true)

            {
                System.Console.WriteLine($"\n--- Round {round} ---");
                System.Console.WriteLine("Choose your action:");
                System.Console.WriteLine("1. Attack");
                System.Console.WriteLine("2. Heal");
                System.Console.WriteLine("3. Run Away");
                string choiceOfAction = Console.ReadLine();   // fixa felet varför du inte kan skriva in A B eller annat är int
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
                                Console.WriteLine($"Congrats you won");
                                menuIsRunning = false;
                                return menuIsRunning;
                            }
                            else if (player.Hp <= 0)
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
                            player.Heal(player.Hp);
                            Console.WriteLine($"{player} healed 15 hp and now your Hp is {player.CurrentHP}");
                            break;
                        case "3":
                            Console.WriteLine("You ran away bitch get off the game  | CTRL + ALT + F4 |");
                            break;
                    }
                    round++;
                }

                //switch (choiceOfAction)
                //{
                //    case "1":
                //        Console.WriteLine($"You attacked {mob.MobName} and made {player.Damage} But you took {mob.MobDamage}!");
                //        mob.MobHp -= player.Damage;
                //        player.CurrentHP -= mob.MobDamage;

                //        if (mob.MobHp <= 0)
                //        {
                //            Console.WriteLine($"Congrats you won");
                //        }
                //        else if (player.Hp <= 0)
                //        {
                //            Console.WriteLine($"You lost the fight");
                //        }
                //        else
                //        {
                //            Console.WriteLine($"\n{mob.MobName} has {mob.MobHp} HP left.");
                //            Console.WriteLine($"\nYou have {player.CurrentHP} HP left.");
                //        }



                //        break;
                //    case "2":
                //        player.Heal(player.Hp);
                //        Console.WriteLine($"{player} healed 15 hp and now your Hp is {player.CurrentHP}");
                //        break;
                //    case "3":
                //        Console.WriteLine("You ran away bitch get off the game  | CTRL + ALT + F4 |");
                //        break;
                //}
                //bool IsWinning = false;
                //if (player.Hp > 0)
                //{
                //    Console.WriteLine($"Game over");
                //    IsWinning = true;
                //}
                //else if (mob.MobHp < 0)
                //{
                //    Console.WriteLine($"Congrats u won");
                //    IsWinning = false;
                //}
                //else
                //{
                //    Console.WriteLine();
                //}

            }
        }
        return false;
    }

    public void StartFight()
    { 
    }


}


