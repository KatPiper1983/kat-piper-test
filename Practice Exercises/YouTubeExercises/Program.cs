using System;

class Program
{
    static void Main(string[] args)
    {
      var names = new string []  {"Kat", "Ana", "Felipe"};

      names = [..names, "Damian"];
      
       foreach (var name in names)
         {
          Console.WriteLine($"Hello {name.ToUpper()}!");
         }

     
     
      
      
      
      
       //hold for later 
     /* int counter = 10;
      do
      {
        System.Console.WriteLine(counter);
        counter++;
      }
      while (counter < 5);
        */




    }
}
