// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
       Building b1 = new();
       Building b2 = new(4, 1000);

       System.Console.WriteLine(b1);
       System.Console.WriteLine(b2);

       House h1 = new();
       System.Console.WriteLine(h1);

       House h2 = new(6, 500);
       System.Console.WriteLine(h2);

       //Full arg constructor for house?
       House h3 = new(8, 750, 12, "Ryan");
       System.Console.WriteLine(h3);
    }
};
