// See https://aka.ms/new-console-template for more information


//Takes in two strings and prints both of them twice
 //find the largest number between 3 ints

using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        DoubleDown();

        GreatestNumber();

    }

    private static void GreatestNumber()
    {
        

        System.Console.WriteLine("Give me three numbers, and I'll tell you which one is highest");
        System.Console.WriteLine("Enter the first number:");
        string? input1 = Console.ReadLine();
        
        System.Console.WriteLine("Enter the second number:");
        string? input2 = Console.ReadLine();
       
        System.Console.WriteLine("Enter the third number:");
        string? input3 = Console.ReadLine();
        

        int num1 = 0; int num2 = 0; int num3 = 0;
        if (input1 != null) num1 = int.Parse(input1);
        if (input2 != null) num2 = int.Parse(input2);
        if (input3 != null) num3 = int.Parse(input3);

        if (num1 > num2 && num1 > num3)
        {
            System.Console.WriteLine("The highest number is " + num1);
        }
        else if (num2 > num1 && num2 > num3)
        {
            System.Console.WriteLine("The highest number is " + num2);
        }
        else if (num3 > num1 && num3 > num2)
        {
            System.Console.WriteLine("The highest number is " + num3);
        }
        else
        {
            System.Console.WriteLine("Cannot Compute! Two or more numbers are equal to each other");
        }
    }

    public static void DoubleDown()
{
    System.Console.WriteLine("What's your first name?");
    String? inputFirst= Console.ReadLine();
    System.Console.WriteLine(inputFirst);
    System.Console.WriteLine(inputFirst);
    System.Console.WriteLine("What's your last name?");
    String? inputLast = Console.ReadLine();
    System.Console.WriteLine(inputLast);
    System.Console.WriteLine(inputLast);
}

public static void LargestNumber()
{
    
}

}











