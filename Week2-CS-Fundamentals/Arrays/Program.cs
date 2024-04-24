// See https://aka.ms/new-console-template for more information
int [] numbers = new int [5];

numbers[0] = 10;
numbers[1] = 11;
numbers[2] = 12;

Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);

foreach (int num in numbers)
{
    Console.WriteLine(num);
}

foreach (int num in numbers)
{
    Console.Write(num + " ");
}