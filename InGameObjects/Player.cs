using System.Drawing;
namespace Heartbeat.InGameObjects {
    public class Player : Entity {
        
        public Player(int Health, int Defense, int Attack, string Name, Point Location)
        {
            this.Health = Health;
            this.Defense = Defense;
            this.Attack = Attack;
            this.Name = Name;
            this.Location = Location;
        }

        public void Move(Direction direction){
            switch ((int)direction){
            case 0:
                Location = new Point(this.Location.X, this.Location.Y+1);
                break;
            case 1:
                Location = new Point(this.Location.X+1, this.Location.Y);
                break;
            case 2:
                Location = new Point(this.Location.X, this.Location.Y-1);
                break;
            case 3:
                Location = new Point(this.Location.X-1, this.Location.Y);
                break;
            }
        }
    }

    public enum Direction : int {
        North = 0,
        East = 1,
        South = 2,
        West = 3,
        Length = 4
    }
}