namespace Heartbeat.InGameObjects {
    public class Creature : Entity {
        public Creature(int Health, int Defense, int Attack, string Name)
        {
            this.Health = Health;
            this.Defense = Defense;
            this.Attack = Attack;
            this.Name = Name;
        }

        public static Creature NewRandomCreature(string Name, int rngMax = 20) => new Creature(StaticData.RNG.Next(10,rngMax)+10,StaticData.RNG.Next(5,rngMax/2),StaticData.RNG.Next(5,rngMax/2),Name);

    }
}