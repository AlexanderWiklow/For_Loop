using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Räkna upp (i) från 0 till 100 
             for (int i = 0; i <= 100; i++)
            {   
                // Skriv värden på (i) utan att brta rad
                Console.Write("{0} ", i);

                // om i är jämnt delbart med 10 
                if (i % 10 == 0)
                {
                    // Skriv värden på (i) till höger om tabellen
                    Console.WriteLine("\t{0}", i);
                }
            }
            Console.ReadLine();
        }
    }
}
