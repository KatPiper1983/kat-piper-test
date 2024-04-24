// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        /*  Console.WriteLine("Hello, World!");
          AddNumbers(1,2);
          AddNumbers(4,5);

          int result = SquareNumber(5);
          Console.WriteLine(result);

          SayHello();*/

        PrintMenu();
        int cmd = GetCmd();

        switch (cmd)
        {
            case 1:
                {
                    SayHello();
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Enter 1st number:");
                    string? value1 = Console.ReadLine();
                    Console.WriteLine("Enter 2nd number: ");
                    string? value2 = Console.ReadLine();

                    int num1 = 0, num2 = 0;
                    if (value1 != null) num1 = int.Parse(value1);
                    if (value2 != null) num2 = int.Parse(value2);

                    AddNumbers(num1, num2);
                    break;

                }
            case 3:
                {
                    Console.WriteLine("Enter a number");
                    string? value1 = Console.ReadLine();

                    int num1 = 0;
                    if (value1 != null) num1 = int.Parse(value1);
                    Console.WriteLine(SquareNumber(num1));
                    break;
                }
        }



    }

    private static int GetCmd()
    {
        string? input = Console.ReadLine();
        int cmd = 0;
        if (input != null) cmd = int.Parse(input);
        return cmd;
    }

    public static void PrintMenu()
    {
        Console.WriteLine("Welcome to our app!");
        Console.WriteLine("================");
        Console.WriteLine("Please enter a command:");
        Console.WriteLine("[1] Say Hello!");
        Console.WriteLine("[2] Add two numbers");
        Console.WriteLine("[3] Square a number");
        Console.WriteLine("===================");
    }

    //Let's meke a method that simply adds two numbers together and prints that result

    //Method signature Syntax: access_modifier return_type MethodName(parameterType parameterName)

    public static void AddNumbers(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }

    //method that RETURNS the squared value of a number
    public static int SquareNumber(int num1)
    {
        int square = num1 * num1;
        return square;
    }

    public static void SayHello()
    {
         //Print out this welcome message
        Console.WriteLine("Please enter your name: ");
        string? input = Console.ReadLine();
        Console.WriteLine("===============");
        Console.WriteLine("Hello " + input);
        Console.WriteLine("================");
    }


}

 //Takes in two strings and prints both of them twice
 //find the largest number between 3 ints