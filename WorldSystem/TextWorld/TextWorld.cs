using System;
using System.Drawing;
using System.Collections.Generic;
using Heartbeat.InGameObjects;
namespace Heartbeat.WorldSystem.TextWorld {
    public class TextWorld {
        public Map WorldMap = new Map();
        public Player Player = new Player(10,10,10,"Player",new Point(10,10));

        public TextWorld(int width, int height) {
            WorldMap.Generate(width, height);
        }
    }
}