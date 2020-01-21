using System;
using System.Collections.Generic;
using System.Text;

namespace DiningCryptographerSimulation
{
    public class Participant
    {
        private bool Secret { get; }
        public string Name { get; }

        public Participant(string name)
        {
            Name = name;
            Secret = SharedRandom.GenerateBool();

            Console.WriteLine($"{Name}\tgenerated {nameof(Secret)}: {Secret}");
        }
    }
}
