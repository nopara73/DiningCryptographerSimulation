using System;
using System.Collections.Generic;
using System.Text;

namespace DiningCryptographerSimulation
{
    public static class SharedRandom
    {
        public static Random Random { get; } = new Random();
        public static bool GenerateBool() => Random.Next(0, 1) == 0 ? false : true;
    }
}
