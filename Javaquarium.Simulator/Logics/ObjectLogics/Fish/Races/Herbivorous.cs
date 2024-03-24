namespace Javaquarium.Simulator.Logics.Races;

public class Herbivorous : Fish
{
    public virtual void EatAlga(Alga alga)
    {
        Aquarium.DeleteAlga(alga);
    }
}
