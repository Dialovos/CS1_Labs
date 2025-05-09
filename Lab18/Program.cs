// Hoang Le
// hle2@northeaststate.edu
// Project 18

namespace Lab18
{
    /// <summary>
    /// Lab18 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            RegularPolygon regularPolygon1 = new RegularPolygon();
            RegularPolygon regularPolygon2 = new RegularPolygon(6, 4.0);
            RegularPolygon regularPolygon3 = new RegularPolygon();

            regularPolygon3.NumSides = 12;
            regularPolygon3.SideLength = 1.25;

            Console.WriteLine($"regularPolygon1\n\t" +
                $"numSide = {regularPolygon1.NumSides}\n\t" +
                $"sideLength = {regularPolygon1.SideLength}\n\t" +
                $"perimeter = {regularPolygon1.Perimeter}\n\t" +
                $"area = {regularPolygon1.Area}\n");

            Console.WriteLine($"regularPolygon2\n\t" +
                $"numSide = {regularPolygon2.NumSides}\n\t" +
                $"sideLength = {regularPolygon2.SideLength}\n\t" +
                $"perimeter = {regularPolygon2.Perimeter}\n\t" +
                $"area = {regularPolygon2.Area}\n");

            Console.WriteLine($"regularPolygon3\n\t" +
                $"numSide = {regularPolygon3.NumSides}\n\t" +
                $"sideLength = {regularPolygon3.SideLength}\n\t" +
                $"perimeter = {regularPolygon3.Perimeter}\n\t" +
                $"area = {regularPolygon3.Area}\n");

            Console.ReadKey();
        }
    }
}