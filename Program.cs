using System;
namespace Room_Calculator
{
    class Program
    {
        static void Main()
        {
            //Call Method to start entering information, when complete, ask user to start again
            Roomcalc();
            Console.WriteLine("Would you like to start again? Type 'Y' to start again, otherwise enter another key to close the program.");
            string restart = Console.ReadLine();
            
            //If user does want to restart, clear previous inputs and start the Main method again which calls the calc Method
            if (restart == "Y")
            {
                Console.Clear();
                Main();
            }
        }
        static void Roomcalc()
        {
            Console.WriteLine("Welcome to the SIMS! Let's start by creating your first room!");
            Console.WriteLine("(All values are in feet)");

            //Ask user for inputs and set those values to decimals
            Console.WriteLine("Enter the Length of the room:");
            string length_entry = Console.ReadLine();
            decimal length = decimal.Parse(length_entry);

            Console.WriteLine("Enter the Width of the room:");
            string width_entry = Console.ReadLine();
            decimal width = decimal.Parse(width_entry);

            Console.WriteLine("Enter the Height of the room:");
            string height_entry = Console.ReadLine();
            decimal height = decimal.Parse(height_entry);

            // Math portion, Must calculate here in order to send into IF statement below.
            decimal area = length * width;
            decimal perimeter = (2 * length) + (2 * width);
            decimal volume = area * height;

            /* First make sure that the area is a positive number. If it is not or something else is wrong,
            send to 'else' portion */
            if (area > 0)
            {
                if (area < 250)
                {
                    Console.WriteLine("This is a small room.");
                }
                if (area >= 250 && area < 650)
                {
                    Console.WriteLine("This is a medium room.");
                }
                if (area > 650)
                {
                    Console.WriteLine("This is a large room.");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong, please try again.");
            }

            //Console printouts of the calculations
            Console.WriteLine("This is the Area of your room:");
            Console.WriteLine(area);
            Console.WriteLine("This is the Perimeter of your room:");
            Console.WriteLine(perimeter);
            Console.WriteLine("This is the Volume of your room in inches squared:");
            Console.WriteLine(volume);
        }
    }
}