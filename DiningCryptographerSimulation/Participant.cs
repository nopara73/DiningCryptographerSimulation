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
        public bool IPaid { get; }

        public Participant(string name, bool iPaid = false)
        {
            Name = name;
            IPaid = iPaid;
            Secret = SharedRandom.GenerateBool();

            if (iPaid)
            {
                Console.WriteLine($"{Name}\tpaid for the dinner.");
            }
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
