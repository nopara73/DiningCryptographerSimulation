using System;
using System.Collections.Generic;
using System.Text;

namespace DiningCryptographerSimulation
{
    public class Participant
    {
        private bool Secret { get; }
        private bool NeighborSecret { get; set; }
        public string Name { get; }

        public Participant(string name)
        {
            Name = name;
            Secret = SharedRandom.GenerateBool();

            Console.WriteLine($"{Name}\tgenerated {nameof(Secret)}: {Secret}");
        }

        internal void ShareSecret(Participant participant)
        {
            participant.ReceiveSecret(this);
        }

        private void ReceiveSecret(Participant participant)
        {
            NeighborSecret = participant.Secret;

            Console.WriteLine($"{Name}\treceived secret of {participant.Name}");
        }
    }
}
