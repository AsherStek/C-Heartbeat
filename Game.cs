using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using Heartbeat.WorldSystem;

namespace Heartbeat {
    class Game {
        // World Variables
        static int WorldWidth = 64;
        static int WorldHeight = 32;
        static int Scale = 20;
        static double Fps = 60.0;
        static bool VS = true;
        static string Title = "Heartbeat Engine";
        //static Heartbeat Heart = new Heartbeat();
        public bool Running = true;

        static string ImagePath = ".\\Maps\\Test.png";

        static SystemSelector Syst = new SystemSelector ();

        [STAThread]
        static void Main (string[] args) {

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider ()) {
                byte[] bytes = new byte[4];
                rng.GetBytes (bytes);
                bytes = bytes.Reverse ().ToArray ();

                StringBuilder sb = new StringBuilder ();
                foreach (byte b in bytes) {
                    sb.Append (b.ToString ("X2"));
                }
                StaticData.Seed = int.Parse (sb.ToString (), System.Globalization.NumberStyles.HexNumber);
            }

            Syst.Selector (0, ImagePath);

            Window Win = new Window (WorldWidth * Scale, WorldHeight * Scale, Title, VS);
            Win.Run (Fps);
        }
    }
}