// Hoang Le
// hle2@northeaststate.edu

namespace Lab05
{
    /// <summary>
    /// Lab05 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry points
        /// </summary>
        static void Main()
        {
            float acceleration, velocity0, velocity1, time;
            string tempInput = "";

            Console.WriteLine("Physics Acceleration Calculator:");
            Console.WriteLine();

            Console.Write("Enter a value for velocity0 in meters/second: ");
            tempInput = Console.ReadLine(); 
            velocity0 = Convert.ToSingle(tempInput);

            Console.Write("Enter a value for velocity1 in meters/second: ");
            tempInput = Console.ReadLine(); 
            velocity1 = Convert.ToSingle(tempInput);

            Console.Write("Enter a value for time second: ");
            tempInput = Console.ReadLine(); 
            time = Convert.ToSingle(tempInput);

            acceleration = (velocity1 - velocity0) / time;

            Console.WriteLine();
            Console.WriteLine("velocity0 = " + velocity0 + " m/s");
            Console.WriteLine("velocity1 = " + velocity1 + " m/s");
            Console.WriteLine("time = " + time + " s");
            Console.WriteLine("acceleration = " + acceleration + " m/s^2");

            Console.WriteLine();
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }   
    }  
}
