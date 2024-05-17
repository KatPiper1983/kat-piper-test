// See https://aka.ms/new-console-template for more information
using System.Globalization;

int counter = 1;

while (counter <= 100)
{
    Console.WriteLine(counter);
    counter++;
}
counter = 1;
int sum = 0;
int end = 100;
while(counter <=100)
{
    sum += counter;
    ++counter;
}
Console.WriteLine("The sum of 1- " + end + " is: " + sum);

//Input Validation
//Tell the user to print out the number: 5

int num = 0;
while(num != 5 )
{
Console.WriteLine("Please input number: 5");
string? input = Console.ReadLine();
if (input != null) num = int.Parse(input);

if(num!=5)
{
    Console.WriteLine("Please try again!");

}
}

// Down here is for when the loop is done--> they finally input the correct value



Console.WriteLine("Good job, you finally entered the correct number");

// Rebranding last example into Do While Loop



do
{
Console.WriteLine("Please input number: 5");
string? input = Console.ReadLine();
if (input != null) num = int.Parse(input);

if(num!=5)
{
    Console.WriteLine("Please try again!");

}
}

while(num != 5 );

// Down here is for when the loop is done--> they finally input the correct value



Console.WriteLine("Good job, you finally entered the correct number");

//For Loops

//Print numbers 1-100

for(int count = 1; count <=100; count++)
{
    Console.WriteLine(count);
}

//Print  the sum of numbers 1-10000
int result = 0;

for(int count =1; count<= 10000; count++)
{
    result += count;
}
Console.WriteLine(result);

//Print only even numbers 2-200
for (int count = 2; count <= 200; count+=2)
{
    Console.WriteLine(count);
}

//Print all numbers starting with  50 going to 25
for (int count = 50; count>= 25; count--)
{
    Console.WriteLine(count);
}

//Nesting Loops
Console.WriteLine("_______________");
//Build a square out of "*" of whatever size we want

int size = 10;
//Builds a number of rows = size
for (int i = 1; i <=size; i++)
{   //Builds ONE row
    for (int j = 1; j<=size; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();//sends code to the next row
}
Console.WriteLine("_____________");
// Staircase Challenge

//Print 1 "*" for the 1st row, then 2 "*" for the 2nd row, etc....
size = 5;
// The outer loop deals with printing additional rows/"Steps"
for (int i = 1; i <=size; i++)
{
    //The inner loop deals with printing the contents of each row/"Step"
    for (int j = 1; j<=i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}


//Staircase Challenge Cont

//There are 3 other directions that the staircase can "face"
//Build them all

//Before foreach
string word = "Hello";
for(int i = 0; i < word.Length; i++)
{
    Console.WriteLine(word[i]);
}

Console.WriteLine("_____________");
//Foreach Loop
foreach (char c in word)
{
    Console.WriteLine(c);
}