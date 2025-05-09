// Hoang Le
// hle2@northeaststate.edu
// Project 16

namespace Lab16
{
    /// <summary>
    /// Lab16 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            int[] d4 = new int[4];
            int[] d6 = new int[6];
            int[] d8 = new int[8];
            int[] d10 = new int[10];
            int[] d12 = new int[12];
            int[] d20 = new int[20];

            RollDice(d4, 4);
            RollDice(d6, 6);
            RollDice(d8, 8);
            RollDice(d10, 10);
            RollDice(d12, 12);
            RollDice(d20, 20);

            Console.WriteLine("d4 rolls: " + ArrayToString(d4));
            Console.WriteLine("d6 rolls: " + ArrayToString(d6));
            Console.WriteLine("d8 rolls: " + ArrayToString(d8));
            Console.WriteLine("d10 rolls: " + ArrayToString(d10));
            Console.WriteLine("d12 rolls: " + ArrayToString(d12));
            Console.WriteLine("d20 rolls: " + ArrayToString(d20));

        }

        static int RollDice(int sides)
        {
            Random random = new Random();

            random.Next(1, sides + 1);

            return random.Next(sides) + 1;
        }

        static void RollDice(int[] diceRolls, int sides)
        {

            for (int i = 0; i < diceRolls.Length; i++)
            {
                if (diceRolls == null) return;

                diceRolls[i] =RollDice(sides);
            }
        }

        static string ArrayToString(int[] array)
        {
            string value = string.Empty;

            foreach (int val in array)
            { 
                value += val + " ";
            }

            return value;
        }
    }
}