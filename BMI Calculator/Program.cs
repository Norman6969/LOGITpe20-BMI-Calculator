using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BMI Calculator";
            Console.Write("What is your mass in Kilograms > ");
            string mass_string = Console.ReadLine();
            float mass;
            if (!float.TryParse(mass_string, out mass))
            {
                Console.WriteLine("Since " + mass_string + " isn't a valid float/integer, this application will close. Press enter to exit.");
                Console.Read();
                Environment.Exit(-1);
            }
            else
            {
                Console.Write("What is your height in centimeters > ");
                string height_string = Console.ReadLine();
                float height;
                if (!float.TryParse(height_string, out height))
                {
                    Console.WriteLine("Since " + height_string + " isn't a valid float/integer, this application will close. Press enter to exit.");
                    Console.Read();
                    Environment.Exit(-1);
                }
                else
                {
                    Console.WriteLine("Your BMI > " + Math.Round(Calculate_BMI(mass, height), 2));
                    Console.WriteLine("Press ENTER to exit...");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
            }

        }

        static float Calculate_BMI(float mass, float height)
        {
            return mass / Sqr(height / 100);
        }

        static float Sqr(float number)
        {
            return number * number;
        }
    }
}
