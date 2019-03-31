using System;
using System.Collections.Generic;
namespace Heartbeat.WorldSystem.TextWorld {
    public class Map {
        public List<Room> Rooms = new List<Room>();
        public int Width;
        public int Height;
        public void Generate(int width, int height) {
            Width = width;
            Height = height;
            for (int i = 0; i < (width * height); i++) {
                Rooms.Add(new Room());
            }
        }
    }
}