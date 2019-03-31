using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System;

using Heartbeat;
using Heartbeat.InGameObjects;
using Heartbeat.WorldSystem.GridWorld;
namespace Heartbeat.WorldSystem {
    public class MapGeneration {
        private static List<string> EntityTypes = new List<string> () {
            "Wall",
            "Slime",
            "Rat",
            "Goblin",
            "Orc"
        };
        public static Dictionary<Point, BoundingBox> Gen (Dictionary<Point, Color> data) {
            List<Point> points = CleanPoints(data.Keys.Select (x => x).ToList (), data);
            int currentKey = 0;
            List<string> types = RNGChoice (points, data);
            Dictionary<Point, BoundingBox> entities = new Dictionary<Point, BoundingBox> ();
            foreach (string str in types) {
                switch (str) {
                    case "Wall":
                        entities.Add (points[currentKey], new Creature (10, 10, 10, str));
                        Console.WriteLine($"Name: {entities[points[currentKey]].Name}");
                        currentKey += 1;
                        break;
                    case "Slime":
                        entities.Add (points[currentKey], new Creature (10, 10, 10, str));
                        currentKey += 1;
                        break;
                    case "Rat":
                        entities.Add (points[currentKey], new Creature (10, 10, 10, str));
                        currentKey += 1;
                        break;
                    case "Goblin":
                        entities.Add (points[currentKey], new Creature (10, 10, 10, str));
                        currentKey += 1;
                        break;
                }
            }
            return entities;
            //entities.Add( new Creature(10,10,10,"Test" ) , new Point(1,1));
        }
        private static List<string> RNGChoice (List<Point> points, Dictionary<Point, Color> data) {
            List<string> types = new List<string> ();
            foreach (Point pt in points) {
                int rngChoice = StaticData.RNG.Next (0, 100);
                Color clr = data[pt];
                Console.WriteLine($"Position: {(pt.X, pt.Y)} R: {clr.R} G: {clr.G} B: {clr.B} A: {clr.A}");
                // Test mob gen
                if (clr.R > 128 && clr.G < 255 && clr.B < 255 && clr.A <= 36) {
                    types.Add(EntityTypes[1]);
                } else if (clr.R > 128 && clr.G < 255 && clr.B < 255 && clr.A <= 79) {
                    types.Add(EntityTypes[2]);
                } else if (clr.R > 128 && clr.G < 255 && clr.B < 255 && clr.A <= 158) {
                    types.Add(EntityTypes[3]);
                } else if (clr.R > 128 && clr.G < 255 && clr.B < 255 && clr.A <= 255) {
                    types.Add(EntityTypes[4]);
                } else {
                    types.Add(EntityTypes[0]);
                }
            }
            //Console.WriteLine(types.ToString(" , "));
            return types;
        }

        private static List<Point> CleanPoints (List<Point> points, Dictionary<Point, Color> data) {
            List<Point> newPoints = new List<Point>();
            foreach (Point pt in points) {
                if (data[pt].R != 0 || data[pt].G != 0 || data[pt].B != 0 || data[pt].A != 0) { newPoints.Add(pt); }
            }
            return newPoints;
        }
    }
}