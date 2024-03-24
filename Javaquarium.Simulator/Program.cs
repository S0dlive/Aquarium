using Javaquarium.Simulator.Logics;
using Javaquarium.Simulator.Logics.Implem;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("hello world");
        MainProgram();
    }

    private static void MainProgram()
    {
        bool isStart = true;
        while (isStart)
        {
            var input = Console.ReadLine();
            switch (input)
            {
                case "C" :
                    isStart = false;
                    break;
                case "next" : 
                    Aquarium.NextTurn();
                    Console.WriteLine(Aquarium.entites.Count);
                    foreach (var entity in Aquarium.entites)
                    {
                        if (entity is Fish fish)
                        {
                            Console.WriteLine(fish);
                        }
                        else if (entity is Alga alga)
                        {
                            Console.WriteLine(alga);
                        }
                    }
                    break;
                case "addFish" :
                    int t = int.Parse(Console.ReadLine());
                    AddFishs(t);
                    break;
                
                
            }
            
        }
    }

    private static void AddFishs(int fishsNumber)
    {
        for (int i = 0; i < fishsNumber; i++)
        {
            var sex = new Random().Next(0, 2);
            var name = "Entite" + Aquarium.entites.Count;
            var race = new Random().Next(0, 6);
            switch (race)
            {
                case 1 : 
                    Aquarium.AddFish(new Clown()
                    {
                        EntityId = Guid.NewGuid().ToString(),
                        Name = name,
                        FishSexe = sex == 1 ? Sexe.Male : Sexe.Female 
                    });
                    break;
                case 2 : 
                    Aquarium.AddFish(new Carpe()
                    {
                        EntityId = Guid.NewGuid().ToString(),
                        Name = name,
                        FishSexe = sex == 1 ? Sexe.Male : Sexe.Female 
                    });
                    break;
                case 3 : 
                    Aquarium.AddFish(new Thon()
                    {
                        EntityId = Guid.NewGuid().ToString(),
                        Name = name,
                        FishSexe = sex == 1 ? Sexe.Male : Sexe.Female 
                    });
                    break;
                case 4 : 
                    Aquarium.AddFish(new Mérou()
                    {
                        EntityId = Guid.NewGuid().ToString(),
                        Name = name,
                        FishSexe = sex == 1 ? Sexe.Male : Sexe.Female 
                    });
                    break;
                case 5 : 
                    Aquarium.AddFish(new Bar()
                    {
                        EntityId = Guid.NewGuid().ToString(),
                        Name = name,
                        FishSexe = sex == 1 ? Sexe.Male : Sexe.Female 
                    });
                    break;
                case 6 : 
                    Aquarium.AddFish(new Sole()
                    {
                        EntityId = Guid.NewGuid().ToString(),
                        Name = name,
                        FishSexe = sex == 1 ? Sexe.Male : Sexe.Female 
                    });
                    break;
            }
        }
    }
}