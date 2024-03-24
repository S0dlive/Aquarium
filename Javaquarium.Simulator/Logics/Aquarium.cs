using Javaquarium.Simulator.Logics.Races;

namespace Javaquarium.Simulator.Logics;

public static class Aquarium
{
    public static List<Entity> entites = new List<Entity>();

    public static void AddFish(Fish fish)
    {
        if (fish == null)
        {
            return;
        }
        entites.Add(fish);
    }

    public static void AddAlga(Alga alga)
    {
        if (alga == null)
        {
            return;
        }
        entites.Add(alga);
    }

    public static void NextTurn()
    {
        EatStat();
    }

    private static void EatStat()
    {
        foreach (var fish in entites)
        {
            if (fish is Fish)
            {
                if (fish is Carnivor carnivor)
                {
                    bool isGood = false;
                    while (isGood == false)
                    {
                        var eaten = new Random().Next(0, entites.Count);
                        if (entites[eaten] is Fish victim)
                        {
                            carnivor.EatFish(victim);
                            isGood = true;
                        }
                    }
                }
                /*if (fish is Herbivorous herbivorous)
                {
                    bool isGood = false;
                    while (isGood == false)
                    {
                        var eaten = new Random().Next(0, entites.Count);
                        if (entites[eaten] is Alga victim)
                        {
                            herbivorous.EatAlga(victim);
                            isGood = true;
                        }
                        
                    }
                }*/
            }
            continue;
        }
    }
    
    public static void DeleteAlga(Alga alga)
    {
        
    }
}