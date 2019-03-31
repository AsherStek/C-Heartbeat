using System;
public static class StaticData {
    private static int seed;
    public static int Seed {
        get { return seed; }
        set {
            seed = value;
            RNG = new Random (seed);
        }
    }
    public static Random RNG {
        get;
        private set;
    }
    public static bool InRange (int val, int min, int max) { return (val <= max && val > min); }
}