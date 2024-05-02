// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        string filepath = "example.txt";

        StreamWriter writer = new StreamWriter(filepath, true);

        writer.WriteLine("Hello World!"); //writes to file
        writer.WriteLine("Ryan was here!"); //writes to file

        System.Console.WriteLine("Info written to file"); //writes to app/console

        writer.Close();

        //can you using method in place of Close()
        using(StreamWriter writer = new StreamWriter(filepath, true))
        {
             writer.WriteLine("Hello World!"); //writes to file
             writer.WriteLine("Ryan was here!"); //writes to file

            System.Console.WriteLine("Info written to file"); //writes to app/console
        }
    }
}
//StreamWriter will overwrite/override any existing contents in the file