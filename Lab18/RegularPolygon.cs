namespace Lab18
{
    internal class RegularPolygon
    {
        /// <summary>
        /// property
        /// </summary>
        public uint NumSides { get; set; }

        /// <summary>
        /// property
        /// </summary>
        public double SideLength { get; set;}

        /// <summary>
        /// calculate and get the area of the regular polygon
        /// </summary>
        public double Area
        { 
            get {return NumSides * Math.Pow(SideLength, 2) / (4 * Math.Tan(Math.PI / NumSides)); }
        }

        /// <summary>
        /// calculate and get the perimeter of the regular polygon
        /// </summary>
        public double Perimeter
        {
            get {return NumSides * SideLength; }
        }

        /// <summary>
        /// default constructor that sets the fields
        /// </summary>
        public RegularPolygon()
        {
            NumSides = 3;
            SideLength = 1; 
        }

        /// <summary>
        /// parameterized constructor that accepts parameters
        /// </summary>
        /// <param name="numSides"></param>
        /// <param name="sideLength"></param>
        public RegularPolygon(uint numSides, double sideLength)
        {
            this.NumSides = numSides;
            this.SideLength = sideLength;
        }
    }
}
