// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //PreventativeApproach();
        //HandlingExceptions();
      // System.Console.WriteLine(WhyFinally()); 
      ThrowingExceptions();



    }

    public static void ThrowingExceptions()
    //You can introduce your own Exceptions into the code at will:
    //throw keyword

    
    public static int WhyFinally()
    {
        int x = 10;
        int y = 1;

        try
        {
            int result = x/y;
            return result;
        }
        catch(DivideByZeroException ex)
        {
            System.Console.WriteLine(ex.Message);
            return 0;
        }
        finally
        {
            System.Console.WriteLine("Printing from the Finally Block");
        }

    }

    private static void PreventativeApproach()
    {
        int[] numbers = [1, 2, 3];

        System.Console.WriteLine("Enter an index: ");
        int index = int.Parse(Console.ReadLine() ?? "0"); //Null Coalescing

        //Preventative Approach to dealing with issues
        if (index >= numbers.Length || index < 0)
        {
            System.Console.WriteLine("You failed to enter an index!");
        }
        else
        {
            System.Console.WriteLine(numbers[index]);
        }

        System.Console.WriteLine("Program End");
    }

    public static void HandlingExceptions()
    {
        int[] numbers = [1, 2, 3,];

        System.Console.WriteLine("Enter an index: ");
        int index = int.Parse(Console.ReadLine()?? "0");

        //Handling Exceptions: try-catch block
        try
        {
            System.Console.WriteLine(numbers[index]);
        }
        catch(IndexOutOfRangeException ex)
        {
            System.Console.WriteLine(ex.Message);
            System.Console.WriteLine(ex.StackTrace);
        }
        catch(FormatException ex)
        {
            System.Console.WriteLine(ex.Message);
            System.Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            System.Console.WriteLine("Will Execute No Matter What");
        }

        System.Console.WriteLine("Program End");
    }

}
