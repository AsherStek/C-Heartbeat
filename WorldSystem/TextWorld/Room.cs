using System;
namespace Heartbeat.WorldSystem.TextWorld {
    public class Room {
        public int Spot = 0;
        public bool Inhabited = false;
        public void Update () {
            if (Inhabited) {
                Spot = 1;
            } else {
                Spot = 0;
            }
        }
    }
}