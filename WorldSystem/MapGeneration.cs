using System.Drawing;
using System.Collections.Generic;
using Heartbeat.WorldSystem.GridWorld;
using Heartbeat.InGameObjects;
using Heartbeat;
using System.Linq;
namespace Heartbeat.WorldSystem {
    public class MapGeneration {
        private static List<string> EntityTypes = new List<string>() {
                "Wall", 
                "Slime", 
                "Rat", 
                "Goblin"
            };
        public static Dictionary<BoundingBox, Point> Gen(Dictionary<Color ,List<Point>> data) {
            List<Color> rgbs = data.Keys.Select(x => x).ToList();
            int currentKey = 0;
            List<string> types = RNGChoice(rgbs);
            Dictionary<BoundingBox, Point> entities = new Dictionary<BoundingBox, Point>();
            foreach (string str in types) {
                switch(str) {
                    case "Wall":
                        entities.Add(new Creature(10,10,10,str) , data[rgbs[currentKey]][currentKey]);
                        currentKey += 1;
                        break;
                    case "Slime":
                        entities.Add(new Creature(10,10,10,str) , data[rgbs[currentKey]][currentKey]);
                        currentKey += 1;
                        break;
                    case "Rat":
                        entities.Add(new Creature(10,10,10,str) , data[rgbs[currentKey]][currentKey]);
                        currentKey += 1;
                        break;
                    case "Goblin":
                        entities.Add(new Creature(10,10,10,str) , data[rgbs[currentKey]][currentKey]);
                        currentKey += 1;
                        break;
                }
            }
            return entities;
            //entities.Add( new Creature(10,10,10,"Test" ) , new Point(1,1));
        }
        private static List<string> RNGChoice(List<Color> rgbs) {
            List<string> types = new List<string>();
            foreach (Color color in rgbs) {
                int rngChoice = StaticData.RNG.Next(0, 100);
                if (color.R == 0 && color.G == 0 && color.B == 0) {
                    types.Add(EntityTypes[0]);
                } else if (color.R >= 172 && color.G < 172 && color.B < 172 && StaticData.InRange(rngChoice, 0, 39)) {
                    types.Add(EntityTypes[1]);
                } else if (color.R >= 172 && color.G < 172 && color.B < 172 && StaticData.InRange(rngChoice, 40, 74)) {
                    types.Add(EntityTypes[2]);
                } else if (color.R >= 172 && color.G < 172 && color.B < 172 && StaticData.InRange(rngChoice, 75, 100)) {
                    types.Add(EntityTypes[3]);
                }
            }
            return types;
        }
    }
}