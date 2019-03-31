using System.Drawing;
using System.Collections.Generic;
using Heartbeat.InGameObjects;
namespace Heartbeat.WorldSystem {
    public class MapLoader {
        public static Dictionary<BoundingBox, Point> Loader(Bitmap map) {
            Dictionary<Color, List<Point>> data = new Dictionary<Color, List<Point>>();
            for (int y = 0; y < map.Height; y++) {
                for (int x = 0; x < map.Width; x ++) {
                    Color pixel = map.GetPixel(x, y);
                    data.Add(pixel, new List<Point>(){new Point(x,y)});
                }
            }
            return MapGeneration.Gen(data);
        }
    }
}