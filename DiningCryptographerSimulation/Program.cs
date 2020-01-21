using System;

namespace DiningCryptographerSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // http://homepages.herts.ac.uk/~comqjs1/Dining.pdf
            // Consider n cryptographers or participants sitting at a dinner table. 
            var nopara = new Cryptographer("nopara");
            var nullc = new Cryptographer("nullc", true);
            var satoshi = new Cryptographer("satoshi");

            // Each participant generates a random 1-bit secret and shares that secret with his or her left neighbor. 
            nopara.ShareSecret(nullc);
            nullc.ShareSecret(satoshi);
            satoshi.ShareSecret(nopara);
            // Now each participant i separately has two secrets kh,i and ki,j in common with the two neighbors h and j respectively.

            // Furthermore, every participant has a 1-bit secret message mi that is equal to 1 if the participant paid, and 0 otherwise. 
            // All participants broadcast the value bi = ki,i−1 ⊕ ki,i+1 ⊕ mi, where ⊕ denotes the exclusive OR operation (bitwise addition modulo 2).
            var noparaResult = nopara.BroadcastResult();
            var nullcResult = nullc.BroadcastResult();
            var satoshiResult = satoshi.BroadcastResult();

            // If we assume the participants are honest3 and there is only one payer p,
            // every observer of all the broadcasts can reconstruct the message by calculating b1 ⊕b2 ⊕ ···⊕bn,
            // since if broadcast bi contained ki,j then by the protocol bj must contain kj,i.
            if (noparaResult ^ nullcResult ^ satoshiResult)
            {
                Console.WriteLine("Cryptographers paid.");
            }
            else
            {
                Console.WriteLine("NSA paid.");
            }

            Console.WriteLine("Press key to exit...");
            Console.ReadKey();
        }
    }
}
