using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
namespace Heartbeat {
    public class Heartbeat {
        private const int Throttle = 10;
        private const long Million = 1000000L;
        private const long Billion = 1000000000L;
        private long LastFpsTime;
        private int Fps;
        public void Run(bool running, Window win) {
            long lastLoopTime = NanoTime();
            const int TARGET_FPS = 60;
            const long OPTIMAL_TIME = Billion / TARGET_FPS;
            while (running) {
                long now = NanoTime();
                long updateLength = now - lastLoopTime;
                lastLoopTime = now;
                double delta = updateLength / Convert.ToDouble(OPTIMAL_TIME);
                LastFpsTime += updateLength;
                Fps++;
                if (LastFpsTime >= Billion) {
                    Console.WriteLine($"(FPS: {Fps})");
                    LastFpsTime = 0;
                    Fps = 0;
                }
                Update(delta);
                Render(delta);
                int sleepFor = Convert.ToInt32((lastLoopTime-NanoTime() + OPTIMAL_TIME)/Million) * Throttle;
                if (sleepFor < 0) {
                    sleepFor += -1;
                }
                Thread.Sleep(sleepFor);
            }
        }
        private void Update(double delta) {
            Console.WriteLine(delta);
        }
        private void Render(double delta) {

        }
        private static long NanoTime() {
            long nano = 1000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 1000L;
            return nano;
        }
    }
}