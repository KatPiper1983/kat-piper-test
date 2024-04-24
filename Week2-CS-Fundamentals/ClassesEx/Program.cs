// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 1;
        string word = "Hello";

        //Object Declaration and Instantiation (Initialization)
        Object obj1 = new Object();    
        Object obj2 = new Object();
        Object obj3 = new();

        DateTime currentTime = DateTime.Now;
        Console.WriteLine(currentTime);


        Car car1 = new Car();
        Console.WriteLine(car1);

        car1.color = "Blue";
        car1.make = "Honda";
        car1.model = "Pilot";
        car1.year = 2020;

        Console.WriteLine(car1.color);
        Console.WriteLine(car1.make);

        car1.Honk();
        car1.Drive(100);
        
    }
}