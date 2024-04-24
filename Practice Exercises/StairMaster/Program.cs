// See https://aka.ms/new-console-template for more information
// Staircase Challenge

//Print 1 "*" for the 1st row, then 2 "*" for the 2nd row, etc....
using System.Globalization;

int size = 5;
// The outer loop deals with printing additional rows/"Steps"
for (int i = 1; i <=size; i++)
{
    //The inner loop deals with printing the contents of each row/"Step"
    for (int j = 1; j<=i; ++j)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}


//Staircase Challenge Cont

//There are 3 other directions that the staircase can "face"
//Build them all

//ascending from left to right
for(int i = 1; i<= size; i++)
{
    for (int j = 1; j <= size-i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k<=i; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine("________________");

//Inverted Descending
for (int i = 1; i<=size; i++ )
{
    for (int j = size; j>=i; --j)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine("______________");

//Inverted ascending left to right
for (int i = 0; i<= size; i++)
{
    for(int j = 1; j<= i; j++)
    {
        Console.Write(" ");
    }
    for (int k=1; k<=size-i; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}