namespace MiniAdventure.Entities;

public class Player
{
    public static int hpRegeneration;
    public string className;
    public static int MaxHp;
    public int Hp;
    public int CurrentHP;
    public int Damage;
    public int Gold;
    public Player(string className)
    {
        className = className;
        if (className == "1")
        {
            
            MaxHp = 100;
            Hp = MaxHp;
            Damage = 15;
            Gold = 20;
            CurrentHP = MaxHp;
            hpRegeneration = 10;
        }
        else if (className == "2")
        {
            MaxHp = 120;
            Hp = MaxHp;
            CurrentHP = MaxHp;
            Damage = 10;
            Gold = 15;
            hpRegeneration = 20;
        }
    }

    public Player()
    {
    }

    //All stats thats showing
    public void Stats()
    {
         Console.WriteLine(" _________________");
        Console.WriteLine($"|      Class      |");
        Console.WriteLine($"|HP: {MaxHp}          |");
        Console.WriteLine($"|Damage: {Damage}       |");
        Console.WriteLine($"|Gold: {Gold}         |"); 
         Console.WriteLine("|_________________|");
    }
    // taking damag
    public void TakeDamage(int damageAmount)
    {
        MaxHp = damageAmount;
       
        Console.WriteLine($"{className} lost {damageAmount} of {MaxHp} And now ur hp is {CurrentHP} ");
      
    }

    public void GiveDamageMob()
    {

    }
    public void Heal(int healAmount)
    {
        int NewHp = Hp + healAmount;
        int healedAmount = 15;
        if (NewHp > MaxHp)
        {
            Hp = MaxHp;
            Console.WriteLine($"You healed for {healedAmount} HP. Your HP is now at maximum: {MaxHp}");
        }
        else
        {
            Hp = NewHp;
            Console.WriteLine($"You healed for {healedAmount} HP. Your current HP is now: {CurrentHP}");
        }
    }

}


