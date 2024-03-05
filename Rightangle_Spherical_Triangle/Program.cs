//﻿to find the hypotenus side of the right angled spherical triangle ,given inputs are two sides , angle c is inclined at 90 degree
using System;

class Program
{
    static void Main(string[] args)
    { 
        // let us assume right angled at c
        double angleC = 90;
        Console.WriteLine("Welcome User to Right angled Spherical Triangle Calculation");
        Console.Write("Enter the side A(Degrees):");
        double sideA = int.Parse(Console.ReadLine())*(Math.PI/180);
        Console.Write("Enter the side B(Degrees):");
        double sideB = int.Parse(Console.ReadLine())*(Math.PI/180);
        double cosc = (Math.Cos(sideA) * Math.Cos(sideB));
        double sideC = Math.Acos(cosc) * (180 / Math.PI);

        // initial assumption let us consider angleC be 90
        double CosA = (Math.Cos(sideA) - (Math.Cos(sideB) * Math.Cos(sideC))) / Math.Sin(sideB) * Math.Sin(sideC);// to find the angleA
        double CosB = (Math.Cos(sideB) - (Math.Cos(sideA) * Math.Cos(sideC))) / Math.Sin(sideA) * Math.Sin(sideC); // to find the angleB

        double angleA = Math.Acos(CosA) * (180 / Math.PI);
        double angleB = Math.Acos(CosB) * (180 / Math.PI);
        double sumAngle = angleA + angleB + angleC;
        Console.WriteLine($"the angleA:{angleA} degree");
        Console.WriteLine($"the angleB:{angleB} degree");
        Console.WriteLine($"the angleC:{angleC} degree");
        Console.WriteLine($"the sideC:{sideC} Radians");
        // 
        if (sumAngle >= 180 && sumAngle <= 540)
        {
            Console.WriteLine("It is right angled spherical triangle");
        }
        else
        {
            Console.WriteLine("It is not a right angled spherical triangle ");
        }

    }

}