using System;

namespace DiningCryptographerSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var nopara = new Participant("nopara");
            var nullc = new Participant("nullc");
            var satoshi = new Participant("satoshi");

            nopara.ShareSecret(nullc);
            nullc.ShareSecret(satoshi);
            satoshi.ShareSecret(nopara);

            Console.WriteLine("Press key to exit...");
            Console.ReadKey();
        }
    }
}
