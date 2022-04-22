// Created by: Mark Palfi
// Created on: Mar 2022
//
// This program does math 

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double side1;
        double side2;
        double side3;
        double height;
        double perimeter;
        double area;

        Console.WriteLine("This program calculates the area and perimeter of a triangle.");
        Console.WriteLine("");

        // input
        Console.Write("Enter side lenght 1: ");
        side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side lenght 2: ");
        side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side lenght 3: ");
        side3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        height = Convert.ToDouble(Console.ReadLine());

        // process
        perimeter = side1 + side2 + side3;
        area = height * side2 / 2;

        // output
        Console.WriteLine("Area = " + area + " cm²");
        Console.WriteLine("Perimeter = " + perimeter + " cm");

        Console.WriteLine("\nDone.");
    }
}