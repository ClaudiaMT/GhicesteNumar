using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhicesteNumar
{
    class Program
    {
        static void Main(string [] args)
        {
            Random rng = new Random();
            int generat = rng.Next(1,100);
            Console.WriteLine(generat);
            int introdus;
            do
            {
                Console.Write("\n Ghiceste numarul (intre 1-100):   ");
                introdus = int.Parse(Console.ReadLine());
                // Console.WriteLine("\n Nr introsus este: {0} \t", introdus);
                if (generat!=introdus)
                {
                    Console.WriteLine(" Mai incearca");

                    if (generat > introdus)
                    {
                        Console.WriteLine("\tNumarul este prea mic\n\n");
                    }

                    if (generat < introdus)
                    {
                        Console.WriteLine("\tNumarul este prea mare\n\n");
                    }
                }
                if (introdus > 100)
                {
                    Console.WriteLine("numarul trebuie sa fie inintervalul 1-100");
                }
                if (introdus < 1)
                {
                    Console.WriteLine("numarul trebuie sa fie pozitiv si celputin egal cu 1");
                }
            }
            while (generat != introdus);
            Console.WriteLine("\n\n\n\t\t\t\t Ai ghicit!\n\n \t\t\t\tNr. generat este {0}\n\n\n\n", generat);
        }
    }
}
