//Area of oblique triangle
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliqueSphericalTriangle
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter the lengths of the sides of the spherical triangle (in radians):");
            Console.Write("Side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Side c: ");
            double c = double.Parse(Console.ReadLine());
            if (!(a + b > c && b + c > a && c + a > b))
            {
                Console.WriteLine("Error: The sum of two sides is not greater than the third side thus it do not form a valid oblique angled triangle.");
                return;
            }

            // Calculate the angles of the spherical triangle using the law of cosines
            double cosA = (Math.Cos(a) - (Math.Cos(b) * Math.Cos(c))) / (Math.Sin(b) * Math.Sin(c));
            double cosB = (Math.Cos(b) - (Math.Cos(a) * Math.Cos(c))) / (Math.Sin(a) * Math.Sin(c));
            double cosC = (Math.Cos(c) - (Math.Cos(a) * Math.Cos(b))) / (Math.Sin(a) * Math.Sin(b));

            // Convert angles from radians to degrees
            double A = Math.Acos(cosA) * (180.0 / Math.PI);
            double B = Math.Acos(cosB) * (180.0 / Math.PI);
            double C = Math.Acos(cosC) * (180.0 / Math.PI);

            // Ensure each angle is between 0 and 180 degrees
            if (double.IsNaN(A) || double.IsNaN(B) || double.IsNaN(C) || A < 0 || A > 180 || B < 0 || B > 180 || C < 0 || C > 180)
            {
                Console.WriteLine("Error: One or more angles are outside the valid range of 0 to 180 degrees.");
                return;
            }

            // Calculate the sum of the angles
            double sumOfAngles = A + B + C;

            // Ensure the sum of angles is within the valid range of 180 to 540 degrees
            if (sumOfAngles < 180 || sumOfAngles > 540)
            {
                Console.WriteLine("Error: The sum of the angles is outside the valid range of 180 to 540 degrees.");
                return;
            }

            // Output the angles of the spherical triangle
            Console.WriteLine($"Angle A: {A} degrees");
            Console.WriteLine($"Angle B: {B} degrees");
            Console.WriteLine($"Angle C: {C} degrees");


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}