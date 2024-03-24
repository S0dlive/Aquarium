namespace Javaquarium.Simulator.Logics;

public abstract class Fish : Entity
{
    public string Name { get; set; }
    public Sexe FishSexe { get; set; }
    
}


public enum Sexe
{
    Male = 0,
    Female = 1
}