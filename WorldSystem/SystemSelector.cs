using Heartbeat.WorldSystem.GridWorld;
namespace Heartbeat.WorldSystem {
    public class SystemSelector {
        public void Selector (int mode, string path) {
            switch ((int) mode) {
                case 0:
                    GWorld world = new GWorld ();
                    world.Start (path);
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}