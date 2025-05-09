// Hoang Le
// hle2@northeaststate.edu

namespace Lab08
{
    /// <summary>
    /// Lab08 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            // variable
            double convertTemperature;
            double temperature;

            // program name
            Console.WriteLine("Temperature Converter (F->C) or (C->F)" + "\n");

            // prompt user for numeric type
            Console.Write("Enter a valua for temperature: ");
            temperature = Convert.ToDouble(Console.ReadLine());
             
            // prompt user for data temperature type
            Console.Write("Select the unit entered Fahrenheit or Celsius (Enter F or C): ");
            string temperatureUnit = Console.ReadLine();

            // temperature conversion
            if (temperatureUnit.Equals("F") || temperatureUnit.Equals("f"))
            {
                // if the user enter Fahrenheit "F" or "f" then convert to Celsius
                convertTemperature = (temperature - 32) * 5 / 9;
                Console.WriteLine($"\n{temperature}F = {convertTemperature:F0}C \n");
            }

            else if (temperatureUnit.Equals("C") || temperatureUnit.Equals("c"))
            {
                // if the user enter Celsius "C" or "c" then convert to Fahrenheit
                convertTemperature = (temperature * 9 / 5) + 32;
                Console.WriteLine($"\n{temperature}C = {convertTemperature:F0}F\n");
            }

            else
            {
                // if user eneter anything beside "F", "f", "C", or "c" then print an invalid message
                Console.WriteLine($"{temperatureUnit} is not a valid unit \n");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
