// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Media;

class Program
{
    static void Main(string[] args)
    {
       // PracticeObjects();
       // PracticeProperties();
       //PracticeScopes()
       PracticeNamespaces();

    }
    public static void PracticeNamespaces()
    {
        Movie movie1 = new("The Avengers", 90);
        System.Console.WriteLine(movie1.Title);
        System.Console.WriteLine(movie1.Rating);
    }

    public static void PracticeScopes()
    {   //Testing 
        System.Console.WriteLine("Total Things Created: " + Thing.count);
        Thing thing1 = new();
        System.Console.WriteLine("Total Things Created: " + Thing.count);
        Thing thing2 = new();
        System.Console.WriteLine("Total Things Created: " + Thing.count);
        //Showing that object Scoped variables are independent of one another
        thing1.objectNum ++;
        thing2.objectNum --;

        System.Console.WriteLine(thing1.objectNum);
        System.Console.WriteLine(thing2.objectNum);
        //Showing how to call Class Scoped variables/methods. Cannot do so through
        System.Console.WriteLine(Thing.classNum);
        Thing.StaticMethod();
        System.Console.WriteLine(DateTime.Now);


    }

    public static void PracticeProperties()
    {
        Book book1 = new Book();
        book1.Title = "Dracula";
        System.Console.WriteLine(book1.Title);
    }



    // All object examples were placed into method to keep clean
    private static void PracticeObjects()
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
        Console.WriteLine(car1.year);
        Console.WriteLine(car1.mileage);

        System.Console.WriteLine("Color: " + car1.color + "; Year: " + car1.year);
        System.Console.WriteLine(car1.color + car1.year);

        car1.Honk();
        car1.Drive(100);
        car1.Drive(100);

        Car car2 = new Car();
        car2.color = "Grey";
        car2.make = "Ford";
        car2.model = "Focus";
        car2.year = 2016;

        System.Console.WriteLine("Car 1 Mileage: " + car1.mileage);
        System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);

        car2.Drive(50);
        System.Console.WriteLine("After driving car 2 some more: ");

        System.Console.WriteLine("Car 1 Mileage: " + car1.mileage);
        System.Console.WriteLine("Car 2 Mileage: " + car2.mileage);

        Car car3 = car2;
        System.Console.WriteLine("Car 3 Color: " + car3.color);
        System.Console.WriteLine("Car 3 Milieage " + car3.mileage);

        //Are car3 and car2 the same car? or just borrowing the same initial values?

        car3.Drive(50);
        System.Console.WriteLine("Car2 mileage: " + car2.mileage);
        System.Console.WriteLine("Car3 mileage: " + car3.mileage);

        //car3 and car2 are both the SAME exact car in memory
        car3 = new();

        System.Console.WriteLine("Car 1: " + car1.ToString());
        System.Console.WriteLine("Car 2: " + car2.ToString());


        System.Console.WriteLine("Car 1: " + car1);
        System.Console.WriteLine("Car 2: " + car2);


        Car car4 = new Car();
        Car car5 = new Car("Silver");
        Car car6 = new Car("Yellow", "Volkswagon", "Beetle", 2005, 100000);
        Car car7 = new Car("", "Honda", "Accord", 1987, 100000);

        System.Console.WriteLine("Car 1: " + car1);
        System.Console.WriteLine("Car 2: " + car2);
        System.Console.WriteLine("Car 3: " + car3);
        System.Console.WriteLine("Car 4: " + car4);
        System.Console.WriteLine("Car 5: " + car5);
        System.Console.WriteLine("Car 6: " + car6);
        System.Console.WriteLine("Car 7: " + car7);

        //How to copy over one object's values to another object
        //No-arg
        Car car8 = new();
        car8.color = car6.color;
        car8.make = car6.make;
        car8.model = car6.model;
        car8.year = car6.year;
        car8.mileage = car6.mileage;

        //full-arg
        Car car9 = new(car6.color, car6.make, car6.model, car6.year, car6.mileage);

        //Copy Constructor
        Car car10 = new(car6);

        //Practice
        //create new project 
        // create fields for object
        //give it some methods
        //give it a constructor
        //create instances of the clase in main method
    }
}