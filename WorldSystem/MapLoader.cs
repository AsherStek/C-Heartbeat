using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

using Heartbeat.InGameObjects;
namespace Heartbeat.WorldSystem {
    public class MapLoader {
        public static Dictionary<Point, BoundingBox> Loader (Bitmap map) {
            Dictionary<Point, Color> data = new Dictionary<Point, Color> ();
            Console.WriteLine($"Height: {map.Height} Width: {map.Width}");
            for (int y = 0; y < map.Height; y++) {
                for (int x = 0; x < map.Width; x++) {
                    Color pixel = map.GetPixel (x, y);
                    data.Add(new Point (x, y), pixel);
                }
            }
            /*
            List<Point> points = data.Keys.Select (x => x).ToList ();
            foreach (Point pt in points) {
                Console.WriteLine($"Point: {pt} Color: {data[pt]}");
            }
            */
            return MapGeneration.Gen (data);
        }
    }
}