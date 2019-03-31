using System.Drawing;
using System.Collections.Generic;
using Heartbeat.WorldSystem;
namespace Heartbeat.WorldSystem.GridWorld {
    public class GridWorld {
        private string ImagePath;
        private int Width;
        private int Height;
        private int Step;
        public GridWorld(string imagePath) {
            Bitmap map = new Bitmap($"{imagePath}");
            Width = map.Width;
            Height = map.Height;
            MapLoader.Loader(map);
        }
    }
}