// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        //Data Structure- Arrays
        //int[] numbers = new int[5];

        //Collections

        //List 
        // - List -> stores all of its values inside of an array

        //Parameterized Class. . . 
        //Generics - Generic Classes
        //Datatype<elementType> variableName = new DataType<elementType>();

        List<int> numbers = new List<int>();
        //List<int> numbers = []; (simplified version)

        //Add values
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        //Printing out items in a Collection

        //Long way
        foreach(int num in numbers)
        {
            System.Console.WriteLine(num);
        }

        //One-liner
        System.Console.WriteLine(string.Join("," , numbers));

        //--------------------

        //Insert a value somewhere other than at the end:
        numbers.Insert(0,40);
         System.Console.WriteLine(string.Join("," , numbers));

         //Add/Insert multiple values
         //Another list
         List<int> numbers2 = [1,2,3];
         numbers.AddRange(numbers2);
         numbers.InsertRange(0, [4,5,6]);
          System.Console.WriteLine(string.Join("," , numbers));
         
         //Different approach
         /* foreach(int num in numbers2)
          {
            numbers.Insert(0, num);
          }*/

          //IndexOf
           System.Console.WriteLine(numbers.IndexOf(30));

          //Accessing an Element
           System.Console.WriteLine(numbers [0]);

           //Remove and Element:
           numbers.Remove(20); //Remove 20 from the list
           numbers.RemoveAt(0);//Remove the 0-indexed element

           //Reverse the List
           numbers.Reverse();
            System.Console.WriteLine(string.Join("," , numbers));

            numbers.Sort();
             System.Console.WriteLine(string.Join("," , numbers));

             //Self-Study: Icomparable<datatype>-> see how you can add it to your
             //own classes - thus allowing them to be sorted

        //Lists
        //StacksAndQueues();
        //HashSets();
        Dictionaries();


    Stack<int> stack = new ();
    stack.Push(10);
    stack.Push(20);
    stack.Push(30);
    System.Console.WriteLine("First popped item: " + stack.Pop());
    stack.Push(40);





    }

    private static void Dictionaries()
    {
        //Dictionaries story Key-Value Pairs
        //Two datatype that you have to pick.  One representing the Key, the other: the value
        //Real World equivalences - Dictionary, (word = key) (definition = value)

        Dictionary<string, int> studentScores = [];
        studentScores.Add("Ryan", 80);
        studentScores.Add("Emma", 85);
        studentScores.Add("Adam", 75);

        //Accessing elements in the dictionary
        System.Console.WriteLine("Ryan's Score: " + studentScores["Ryan"]);

        studentScores["Ryan"] = 81;
        System.Console.WriteLine("Ryan's Score: " + studentScores["Ryan"]);

        foreach (KeyValuePair<string, int> kvp in studentScores)
        {
            System.Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }

        // can use var as a placeholder to figure out data type
        foreach (var kvp)

    }
    private static void HashSets()
    {
        //Hash- a way of storing values - usually using some of the item's
        //data to help formulate a spot for the hash to store said items

        //Set - do not preserve any order insertion
        //    - duplicates are not allowed

        HashSet<int> set = [1, 2, 3, 4, 1];

        set.Add(5);
        set.Add(5);// ignores duplicates

        System.Console.WriteLine(set.Contains(4));
        foreach(int num in set)
        {
            System.Console.WriteLine(num);
        }

    }

    private static void StacksAndQueues()
    {
    //There are more collections than just Lists
    //Stacks and Queues take a slightly different strategy to data storage
    //They see it as a holding cell where data enters in a partidular order
    //And then exits (removed from collection) in a partidular order.
    //Stacks have a strategy -> First In, Last Out -> FILO
    //Queues have a strategy -> First In, First Out -> FIFO

    Queue<int> queue = new();
    queue.Enqueue(1);
    }
}
