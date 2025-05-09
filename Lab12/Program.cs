// Hoang Le
// hle2@northeaststate.edu

namespace Lab12
{
    /// <summary>
    /// Lab12 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Twinkle Twinkle Little Star");

            PlayTwinkleTwinkle();
        }
        static void PlayTwinkleTwinkle()
        {
            if (OperatingSystem.IsWindows())
            {
                int C = 262;
                int D = 294;
                int E = 330;
                int F = 349;
                int G = 392;
                int A = 440;

                Console.Beep(C, 500);
                Console.Beep(C, 500);
                Console.Beep(G, 500);
                Console.Beep(G, 500);
                Console.Beep(A, 500);
                Console.Beep(A, 500);
                Console.Beep(G, 500);
                Console.Beep(G, 1000);
                Console.Beep(F, 500);
                Console.Beep(F, 500);
                Console.Beep(E, 500);
                Console.Beep(E, 500);
                Console.Beep(D, 500);
                Console.Beep(D, 500);
                Console.Beep(C, 500);
                Console.Beep(C, 1000);
            }
        }
    }
}