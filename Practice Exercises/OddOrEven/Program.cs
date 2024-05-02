// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        //formula: (a*b) + (c*d)

        //create a method with four integer arguments
        //calculate above formula
        //determine if result is even or odd
        //return either odd or even

        int number = funMathFormula(2,3,4,5);
        if(number %2==0)
        {
            System.Console.WriteLine("Even");
        }
        else
        {
            System.Console.WriteLine("Odd");
        }
    }

    public static int funMathFormula(int a, int b, int c, int d)
    {
        int result = (a*b) + (c*d);
        return result;
    }





}


