// Area of Spherical triangle
using System;

class Program
{
    static void Main(string[] args)
    {
        double angle1, angle2, angle3;

        do
        {
            Console.WriteLine("Enter the three vertex angles of the spherical triangle:");
            Console.Write("Angle 1 (degrees): ");
            angle1 = ReadPositiveAngle();
            Console.Write("Angle 2 (degrees): ");
            angle2 = ReadPositiveAngle();
            Console.Write("Angle 3 (degrees): ");
            angle3 = ReadPositiveAngle();

            double sumOfAngles = angle1 + angle2 + angle3;

            if (sumOfAngles >= 180 && sumOfAngles <= 540)
            {
                break;
            }
            else
            {
                Console.WriteLine("The sum of angles must be greater than 180 degrees and less than 540 degrees. Please try again.");
            }
        } while (true);

        // Convert angles from degrees to radians
        angle1 = ToRadians(angle1);
        angle2 = ToRadians(angle2);
        angle3 = ToRadians(angle3);

        // Calculate the spherical excess
        double sphericalExcess = angle1 + angle2 + angle3 - Math.PI;

        // Calculate the area of the spherical triangle
        Console.Write("Enter the radius in metres: ");
        double radius = double.Parse(Console.ReadLine()); // Assuming unit radius
        double area = sphericalExcess * Math.Pow(radius, 2);

        Console.WriteLine("Area of the spherical triangle: " + area + "metre square");
    }

    // Helper method to convert degrees to radians
    static double ToRadians(double degrees)
    {
        return degrees * Math.PI / 180.0;
    }

    // Helper method to read a positive angle from the user
    static double ReadPositiveAngle()
    {
        double angle;
        do
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out angle) && angle > 0 && angle <= 180)
            {
                return angle;
            }
            else
            {
                Console.WriteLine("Please enter a positive number less than or equal to 180 of vertex angle.");
            }
        } while (true);
    }
}
