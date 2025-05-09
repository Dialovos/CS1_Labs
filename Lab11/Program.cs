// Hoang Le
// hle2@northeaststate.edu

namespace Lab11
{
    /// <summary>
    /// Lab11 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            // Ask for Side
            Console.Write("Enter the number of sides: ");
            int numSides = Convert.ToInt32(Console.ReadLine());

            if (numSides < 3)
            {
                Console.WriteLine("Number of sides must be greater than 2. Exiting.");
                return;
            }

            // Ask for Length 
            Console.Write("Enter the length of each side: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            if (sideLength <= 0)
            {
                Console.WriteLine("Length of sides must be greater than 0. Exiting.");
                return;
            }
            // Calculate the area of the polygon using the CalculateRegularPolygonArea method and storing it in the variable
            // "area" to be print to console. 
            double area = CalculateRegularPolygonArea(numSides, sideLength);
            Console.WriteLine($"The area of the polygon is {area}");
        }
        /// <summary>
        /// Calculate the polygon area (formula) 
        /// </summary>
        /// <param name="numSides"></param>
        /// <param name="sideLength"></param>
        /// <returns></returns>
        static double CalculateRegularPolygonArea(int numSides, double sideLength)
        {
            return (numSides * Math.Pow(sideLength, 2)) / (4 * Math.Tan(Math.PI / numSides));
        }
    }
}
