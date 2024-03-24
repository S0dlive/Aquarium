namespace Javaquarium.Simulator.Logics.Races;

public abstract class Carnivor : Fish
{
    public virtual void EatFish(Fish fish)
    {
        fish.Die();
    }
}
