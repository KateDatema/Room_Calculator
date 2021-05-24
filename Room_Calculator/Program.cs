using System;

namespace Room_Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Boolean con = true; 
            while (con == true)
            {
                Console.WriteLine("Please enter the length of your room");
                double length = double.Parse(Console.ReadLine());


                Console.WriteLine("Please enter the width of the room");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of the room");
                double height = double.Parse(Console.ReadLine());

                double perimeter = (length * 2) + (width * 2);
                double area = length * width;


                Console.WriteLine("Length: " + length);
                Console.WriteLine("Width: " + width);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter:" + perimeter);
                Console.WriteLine("Height:" + height);
                Console.WriteLine("Paint: " + (perimeter / 5) );
                Console.WriteLine("Carpet Tiles: " + (area / 5));
                Console.WriteLine("Volume: " + (length * width * height));

                Console.WriteLine("Would you like to measure another room? (yes or no)");
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                

                if (userInput == "yes")
                {
                    con = true;
                }
                else
                {
                    con = false;
                }

            }

        }
    }
}
