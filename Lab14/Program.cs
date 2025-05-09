// Hoang Le
// hle2@northeaststate.edu
// Project 14

namespace Lab14
{
    /// <summary>
    /// Lab14 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            Console.Write("Loop 1:");
            for (int i = 1; i < 20; ++i)
            {
                Console.Write($"{i * 11} ");
            }

            Console.Write("\nLoop 2:");
            for (int i = 0; i < 19; ++i)
            {
                Console.Write($"{68 - 2 * i} ");
            }

            Console.Write("\nLoop 3:"); // I notice that the sequence is ascending by 26
            for (int i = 1; i < 400; i++)
            {
                if (i  % 2==0 && i % 13 == 0)
                { 
                    Console.Write($"{i} ");
                }

                /*Console.Write($"{i * 26} ");*/ // simple solution
            }

            int a = 0;
            int b = 1;
            int c;
            Console.Write("\nLoop 4:");
            for (int i = 0; i < 19; i++)
            {
                if (i < 1) // I dont know how to start the sequence from zero
                {
                    Console.Write($"{a} {b} ");
                }

                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                    Console.Write($"{c} ");
                }
                
            }
        }
    }
}