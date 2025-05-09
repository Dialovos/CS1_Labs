// Hoang Le
// hle2@northeaststate.edu
// Project 15

namespace Lab15
{
    /// <summary>
    /// Lab15 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            string? input = string.Empty;
            Console.WriteLine("Deckard Cain: Hello traveler, stay a while and listen!");

            while (input != "bye")
            {
                Console.Write("You: ");
                input = Console.ReadLine();


                if (input.ToUpper().Equals("LORE"))
                {
                    Console.WriteLine("Deckard Cain: Tristram something something.");
                }

                else if (input.ToUpper().Equals("DIABLO"))
                {
                    Console.WriteLine("Deckard Cain: Diablo is, like, the worst.");
                }

                else if (input.ToUpper().Equals("D4"))
                {
                    Console.WriteLine("Deckard Cain: No, I am not slated to return for Diablo 4.I am going into comedy.");
                }

                else if (input.ToUpper().Equals("BYE"))
                {
                    Console.WriteLine("Deckard Cain: No, I am not slated to return for Diablo 4.I am going into comedy.");
                }

                else
                {
                    Console.WriteLine("Deckard Cain: I don’t know what you mean. Soo.. stay a while and listen.");
                }
            } 
        }
    } 
}
