// Hoang Le
// hle2@northeaststate.edu

namespace Lab10
{
    /// <summary>
    /// Lab10 Implementation
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            Console.Write("Enter a month in the year (e.g., 1 for Jan): ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            float days = 0;
            string monthId = "";

            switch (month)
            {
                case 1:
                    monthId = "January";
                    days = 31;
                    break;
                case 2:
                    monthId = "February";
                    // I use the leap year method instead of creating my own 
                    days = DateTime.IsLeapYear(year) ? 29 : 28;
                    break;
                case 3:
                    monthId = "March";
                    days = 31;
                    break;
                case 4:
                    monthId = "April";
                    days = 30;
                    break;
                case 5:
                    monthId = "May";
                    days = 31;
                    break;
                case 6:
                    monthId = "June";
                    days = 30;
                    break;
                case 7:
                    monthId = "July";
                    days = 31;
                    break;
                case 8:
                    monthId = "August";
                    days = 31;
                    break;
                case 9:
                    monthId = "September";
                    days = 30;
                    break;
                case 10:
                    monthId = "October";
                    days = 31;
                    break;
                case 11:
                    monthId = "November";
                    days = 30;
                    break;
                case 12:
                    monthId = "December";
                    days = 31;
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    monthId = "0";
                    break;

            }
            // I print the output outside of the switch so I have to do less typing 
            Console.WriteLine($"{monthId} {year} has {days} days");
        }
    }
}

