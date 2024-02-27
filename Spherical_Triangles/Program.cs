// Area of spherical triangle
using System;

class Program
{
    static void Main(string[] args)
    {
        double angle1, angle2, angle3;

        do
        {
            Console.WriteLine("Enter the three angles of the spherical triangle:");
            Console.Write("Angle 1 (degrees): ");
            angle1 = double.Parse(Console.ReadLine());
            Console.Write("Angle 2 (degrees): ");
            angle2 = double.Parse(Console.ReadLine());
            Console.Write("Angle 3 (degrees): ");
            angle3 = double.Parse(Console.ReadLine());

            double sumOfAngles = angle1 + angle2 + angle3;

            if (sumOfAngles <= 180 || sumOfAngles >= 540)
            {
                Console.WriteLine("The sum of angles must be greater than 180 degrees and less than 540 degrees. Please try again.");
            }
            else
            {
                break;
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
        double radius = (double.Parse(Console.ReadLine())); // Assuming unit radius
        double area = sphericalExcess * Math.Pow(radius, 2);

        Console.WriteLine("Area of the spherical triangle: " + area + " square metre");
    }

    // Helper method to convert degrees to radians
    static double ToRadians(double degrees)
    {
        return degrees * Math.PI / 180.0;
    }
}