// See https://aka.ms/new-console-template for more information
int actualNumber = 66;
int guess = 0;

Console.WriteLine("Let's play a game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.  Can you guess what it is?");
string? input = Console.ReadLine();
if (input != null) guess= int.Parse(input);


while (actualNumber != guess)
{    
    
    if (guess > actualNumber)
    {
        Console.WriteLine("Sorry, you are too high.  Please guess again");
        input = Console.ReadLine();
        if (input != null) guess= int.Parse(input);
    }
    else 
    {
        Console.WriteLine("Nope!  Your guess is too low.  Please try again");
        input = Console.ReadLine();
        if (input != null) guess= int.Parse(input);;
    }
}

Console.WriteLine("Congratulations!  You guessed correctly.  Thanks for playing!");



//Ryan's Solution

int correctNum = 40;
int guess = 0;

while (guess != correctNum)
{
Console.WriteLine("Please enter a number between 1-100:");
string? input = Console.ReadLine();
if (input != null) guess = int.Parse(input);

    if(guess> correctNum)
    {
        Console.WriteLine ("your guess was too high!");
    }
    else if(guess < correctNum)
    {
        Console.WriteLine("Your guess was too low!");
    }

}
Console.WriteLine("You are correct!  Thanks for playing");

//Solution with randome number
Random random = new Random();
int correctNum = random.Next(1, 101);
int guess = 0;

while (guess != correctNum)
{
Console.WriteLine("Please enter a number between 1-100:");
string? input = Console.ReadLine();
if (input != null) guess = int.Parse(input);

    if(guess> correctNum)
    {
        Console.WriteLine ("your guess was too high!");
    }
    else if(guess < correctNum)
    {
        Console.WriteLine("Your guess was too low!");
    }

}
Console.WriteLine("You are correct!  Thanks for playing");

// Play again without having to restart

bool again = true;

while(again)
{
    Random random = new Random();
    int correctNum = random.Next(1, 101);
    int guess = 0;


    while (guess != correctNum)
    {
        Console.WriteLine("Please enter a number between 1-100:");
        string? input = Console.ReadLine();
        if (input != null) guess = int.Parse(input);

        if(guess> correctNum)
        {
            Console.WriteLine ("your guess was too high!");
        }
        else if(guess < correctNum)
        {
            Console.WriteLine("Your guess was too low!");
        }

    }
    Console.WriteLine("You are correct!  Thanks for playing");

    Console.WriteLine("Would you like ot play again? (Y) or (N)");
    input= Console.ReadLine();

    if ("Y".Equals(input))
    {
        again = true;
    }
    else
    {
        again = false;
    }
}
Console.WriteLine("Thanks for playing!  Have a good day!");