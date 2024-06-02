using System;
using System.Linq;

class Program
{
    static IUserRepo ur;
    static void Main(string[] args)
    {
        //test out LINQ and Lambda Expressions
       // LambdaTest();
       using AppDbContext context = new();
       ur = new UserRepo(context);

       //Create a new user
       User newUser = new(0, "juliet", "pass5", "user");
       ur.AddUser(newUser);
       ur.Save();
       System.Console.WriteLine("User added successfully");

    }
    public static void LambdaTest()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8];
        List<string> words = ["Hello", "Hey", "Hi", "Ahoy"];
        List <int> evenNumbers = numbers.Where(num => num %2 == 0).ToList();
        var hWords = words.Where(word => word.Substring(0,1)== "H");

      evenNumbers.ForEach(num => System.Console.WriteLine(num));
      evenNumbers = evenNumbers.OrderBy(x => x).ToList();
      System.Console.WriteLine("=================");
      evenNumbers.ForEach(num => System.Console.WriteLine(num));
        
    }
}

