namespace Javaquarium.Simulator.Logics
{
    public abstract class Fish : Entity
    {
        public string Name { get; set; }
        public Sexe FishSexe { get; set; }
        public int Health { get; set; }

        public Fish() : base()
        {
            Health = 10;
        }
        public virtual void Die()
        {
            var t = Aquarium.entites.FirstOrDefault(t => t.EntityId == EntityId);
            if (t == null)
            {
                return;
            }
            Aquarium.entites.Remove(t);
        }


        ~Fish()
        {
            Console.WriteLine("cool");
        }
    }

    public enum Sexe
    {
        Male = 0,
        Female = 1
    }
}