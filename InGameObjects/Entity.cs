
using System.Drawing;
namespace Heartbeat.InGameObjects{
    public abstract class Entity : BoundingBox {
        public int Health {get; set;}
        public int Defense {get; set;}
        public int Attack {get; set;}
        public string Name {get; set;}

        public Point Location {get; set;}

        public virtual void AttackEntity(Entity entity){
           
           entity.Damage(StaticData.RNG.Next(0,Attack));
        }

        public virtual void Damage(int amount)
        {
            int defense = StaticData.RNG.Next(0, Defense);
            int damage = amount - defense < 0 ? 0:amount-defense;
            Health -= damage;
        }
    }
}