using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using Heartbeat.InGameObjects;
using Heartbeat.WorldSystem;
namespace Heartbeat.WorldSystem.GridWorld {
    public class GWorld {
        private string ImagePath;
        private int Width;
        private int Height;
        private int Step;
        public void Start (string imagePath) {
            Bitmap map = new Bitmap (imagePath);
            Width = map.Width;
            Height = map.Height;
            Dictionary<Point, BoundingBox> mapData = MapLoader.Loader (map);
            List<Point> points = mapData.Keys.Select (x => x).ToList ();
            foreach (Point pt in points) {
                Console.WriteLine($"Point: {pt} Type: {mapData[pt]} Name: {mapData[pt].Name} Health: {mapData[pt].Health}");
            }
        }
    }
}