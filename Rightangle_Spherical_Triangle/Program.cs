//Spherical right angle triangle

using System;

class Program
{
    static void Main(string[] args)
    {
        double angleC = 90;
        Console.WriteLine("Enter the side A:");
        double sideA = int.Parse(Console.ReadLine()) * (Math.PI / 180); //convert degree to radians
        Console.WriteLine("Enter the side B:");
        double sideB = int.Parse(Console.ReadLine()) * (Math.PI / 180);
        double cosc = (Math.Cos(sideA) * Math.Cos(sideB)) + (Math.Sin(sideA) * Math.Sin(sideB) * Math.Cos(angleC));
        double sideC = Math.Acos(cosc) * (180 / Math.PI);
        Console.WriteLine($"cosC:{cosc}");
        // initial assumption let us consider angleC be 90
        double CosA = (Math.Cos(sideA) - Math.Cos(sideB) * Math.Cos(sideC)) / Math.Sin(sideB) * Math.Sin(sideC);
        double CosB = (Math.Cos(sideB) - Math.Cos(sideA) * Math.Cos(sideC)) / Math.Sin(sideA) * Math.Sin(sideC);

        double angleA = Math.Acos(CosA) * (180 / Math.PI);
        double angleB = Math.Acos(CosB) * (180 / Math.PI);
        double sumAngle = angleA + angleB + angleC;
        Console.WriteLine($"the angleA:{angleA}");
        Console.WriteLine($"the angleB:{angleB}");
        Console.WriteLine($"the angleC:{angleC}");
        Console.WriteLine($"the sideC:{sideC}");

        if (sumAngle >= 180 && sumAngle <= 540)
        {
            Console.WriteLine("it is right angled spherical triangle");
        }
        else
        {
            Console.WriteLine("it is not a right angled spherical triangle ");
        }

    }

}


