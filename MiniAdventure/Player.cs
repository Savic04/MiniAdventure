

using System.ComponentModel;

namespace MiniAdventure;

public class Player
{
    public string Name = "";
    public int MaxHp = 0;
    public int Hp = 0;
    public int GoldReward = 0;
    public int Damage = 0;

    public Player(string name, int hp,int goldReward)
    {
        Name = name;
        MaxHp = hp;
        GoldReward = goldReward;
        Console.WriteLine($"Congratulation for choosing{Name} Let the game begin!");

    }
    public void TakeDamage(int damageAmount)
    {
        Hp -= damageAmount;
        if (Hp < 0)
        {
            Console.WriteLine($"{Name} took {damageAmount} damage. Your healt is now at {Hp}");

        }
    }    
}

