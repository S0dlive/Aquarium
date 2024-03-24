namespace Javaquarium.Simulator.Logics;

public abstract class Entity
{
    
    public string EntityId { get; set; }

    public Entity()
    {
        EntityId = Guid.NewGuid().ToString();
    }
}
