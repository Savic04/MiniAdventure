
using MiniAdventure;
using System.Security.Cryptography.X509Certificates;

namespace MiniAdventure;

public class Mobs
{
    public string mobname = "";
    public int mobhp = 0;
    public int GoldReward = 0;

    List<Mobs> moblist = new List<Mobs>();
    
   
    public Mobs()
    {
        moblist.Add(new Mobs { mobname = "Goblin", mobhp = 103, GoldReward = 9 });
        moblist.Add(new Mobs { mobname = "Vendigo", mobhp = 85, GoldReward = 4 });
        moblist.Add(new Mobs { mobname = "Näcken", mobhp = 93, GoldReward = 6 });
        moblist.Add(new Mobs { mobname = "Sven", mobhp = 100, GoldReward = 7 });
        moblist.Add(new Mobs { mobname = "Creeper", mobhp = 107, GoldReward = 10 });


        Random random = new Random();

        int RandomMob = random.Next(moblist.Count);
    }
}
  




