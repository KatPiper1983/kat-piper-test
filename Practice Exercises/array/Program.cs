// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        //find the largest number in the array of values

        //need to check each value in the  array
        int max = 0;
        foreach(int value in array)
        {
            if(value > max)
                max = value;
        }
        System.Console.WriteLine("The max number is: " + max );
        //we need to track what max value have found at any given time
        //once done checking, return/print said highest number

        //print out resersed order of a string
        //print out something in the end
            //storing work into a string?
            //how do I reverse a string?
            //build string with characters of original string but backwards

        //maybe loop through each character of string?
        //maybe start loop at the end and work backward?
        string reverse = "";
        for(char c in str)
        {
            reverse = c + reverse;
        }

        for(int i = str.Length -1; i>=0; i--)
        {
            reverse += string[i]
        }


    }
}
