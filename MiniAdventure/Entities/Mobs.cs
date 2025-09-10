using System;
using System.Security.Cryptography.X509Certificates;

namespace MiniAdventure.Entities
{
    public class Mobs
    {
        public string MobName;
        public int MobHp;
        public int MobDamage;
        public int GoldReward;
        public int MobMana;

        public static string[] mobsArray = { "Sven", "Näcken", "Vendigo", "Goblin", "Ghost" };
        

        public Mobs()
        {       
        }
        public void Mobs1()
        {

        }

      

        // sakapar random 
        public static Random random = new Random();
        public static Mobs GetRandomMob(string[] randomArray)
        {
            int randomIndex = random.Next(0, mobsArray.Length);
            Mobs mob = new Mobs();
            mob.MobName = randomArray[random.Next(randomArray.Length)];
            mob.MobHp = random.Next(50,100);
            mob.MobDamage = random.Next(4,14);
            mob.GoldReward = random.Next(0,6);
            return mob;

        }
    }

}
