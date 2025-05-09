// Hoang Le
// hle2@northeaststate.edu

namespace Lab13
{
    /// <summary>
    /// Lab13 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            // Declare variables
            sbyte c;
            byte d;
            short e;
            ushort f;
            int g;
            uint h;
            long i;
            ulong j;
            float m;
            double n;
            decimal o;
            char p;
            string s;
            bool t;

            // Get user input 
            c = Prompt.ForSignedByte("Enter a sbyte: ");
            d = Prompt.ForByte("Enter a byte: ");
            e = Prompt.ForShort("Enter a short: ");
            f = Prompt.ForUnsignedShort("Enter a ushort: ");
            g = Prompt.ForInt("Enter an int: ");
            h = Prompt.ForUnsignedInt("Enter an uint: ");
            i = Prompt.ForLong("Enter a long: ");
            j = Prompt.ForUnsignedLong("Enter a ulong: ");
            m = Prompt.ForFloat("Enter a float: ");
            n = Prompt.ForDouble("Pardon me, may I have a double?: ");
            o = Prompt.ForDecimal("Enter a decimal: ");
            p = Prompt.ForChar("Enter a char: ");
            s = Prompt.ForString("Enter a string: ");
            t = Prompt.ForBool("Enter a bool: ");

            // Display results 
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine($"f = {f}");
            Console.WriteLine($"g = {g}");
            Console.WriteLine($"h = {h}");
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"j = {j}");
            Console.WriteLine($"m = {m}");
            Console.WriteLine($"n = {n}");
            Console.WriteLine($"o = {o}");
            Console.WriteLine($"p = {p}");
            Console.WriteLine($"s = {s}");
            Console.WriteLine($"t = {t}");
        }
    }
}