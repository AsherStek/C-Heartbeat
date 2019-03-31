using System;
using System.Security.Cryptography;
using System.Linq;
using System.Text;

namespace Heartbeat {
    class Game {
        // World Variables
        static int WorldWidth = 10;
        static int WorldHeight = 5;
        static Heartbeat Heart = new Heartbeat();
        static void Main(string[] args) {

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()){
                byte[] bytes = new byte[4];
                rng.GetBytes(bytes);
                bytes = bytes.Reverse().ToArray();

                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes){
                    sb.Append(b.ToString("X2"));
                }
                StaticData.Seed = int.Parse(sb.ToString(), System.Globalization.NumberStyles.HexNumber);
            }
            bool running = true;
            Heart.Run(running);
        }
    }
}
