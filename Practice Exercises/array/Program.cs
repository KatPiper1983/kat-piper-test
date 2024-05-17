// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        //find the largest number in the array of values

        //need to check each value in the  array
       /* int max = 0;
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
        }*/
        //System.Console.WriteLine(Reverse("FreaksAndGeeks"));

        string s = Console.ReadLine();

        foreach(char c in s)
        {
            Console.WriteLine(c-'a'+1);
            
        }

    }
    //Reverse String Method()
        public static string Reverse(string Input)
    {
        char[] charArray = Input.ToCharArray();//converts string to character array
        string reversedString = String.Empty; //Declaring an empty string

        //Iterating each character from right to left
        for(int i = charArray.Length-1; i>-1; i--)
        {
            //append each character to the reversedString
            reversedString += charArray[i];
        }
        //Return the reversed string
        return reversedString;
    }
}
