using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        MovieRepo mr = new();
        //LinearTest(mr);
    }
    private static void LinearTest(MovieRepo mr)
    {

        RetrievingMovie(mr);//Tested the MovieRepo - GetMovie()


        //Let's test adding a new movie into our collection
        AddingNewMovie(mr);

        //Let's test updating a movie in our collection
        UpdatingMovie(mr);

        //Let's test deleting a movie in our collection
        DeletingMovie(mr);

    }

    private static void DeletingMovie(MovieRepo mr)
    {
        //Pick a movie-> Ask for an ID of a Movie->Retrieve the Movie with that ID
         Movie movie = PromptUserForMovie(mr);
        //Remove that movie from our storage
        Console.WriteLine("Deleted Movie: " + mr.UpdateMovie(movie));
        
    }

    private static void UpdatingMovie(MovieRepo mr)
    {
        //Pick a Movie-> Ask for an ID of a Movie-> Retrieve the Movie with that ID
        Movie movie = PromptUserForMovie(mr);
        //Let the user update some fields
        System.Console.WriteLine("Please provide a new Title: ");
        movie.Title = Console.ReadLine() ?? "";
        //and we could do more steps to update more values...

        //Save the changed values to our storage
        Console.WriteLine("Updated Movie: " + mr.UpdateMovie(movie));
    }

    private static void AddingNewMovie(MovieRepo mr)
    {
        System.Console.WriteLine("Let's add a new movie");
        System.Console.WriteLine("Please provide a Movie Title");
        string title = Console.ReadLine() ?? "";

        System.Console.WriteLine("Please provide a price: ");
        double price = double.Parse(Console.ReadLine()?? "0");

        //Let's assume that the Available will default to true
        //and the return date will be 0

        //also not going to ask for ID- because MovieRepo- AddMovie()
        //already gives it the next, correct value for ID

        //Now need to collect all the info into new Movie Object
        Movie movie = new(0, title, price, true, 0);

        //Now that info is collected into a Movie object
        //let's use MovieRepo to ADD it to our data storage
        movie = mr.AddMovie(movie);
        // reusing movie variable to store updated values, if any,
        //from AddMovie() process

        //for sake of clarity to user of the app, lets inform them of the newly added movie
        System.Console.WriteLine("Newly Added Movie: " + movie);

    }
    private static void RetrievingMovie(MovieRepo mr)
    {
        //Let's test retreiving a movie that exists
        //We have to make a little bit of assumption
        //the user has to know what kind of IDs might work

       Movie retrievedMovie = PromptUserForMovie(mr);
        //Leaving the loop indicates that they have successfully retrieved the movie

        //Easiest way to showcase what Movie we retrieved is to print it out
        System.Console.WriteLine("Retreived Movie: " + retrievedMovie);
    }
    //Helper Method
    private static Movie PromptUserForMovie(MovieRepo mr)
    {
        Movie? retrievedMovie = null;
        while (retrievedMovie == null)
        {

            System.Console.WriteLine("Please enter a movie ID");
            int input = int.Parse(Console.ReadLine() ?? "0");
            retrievedMovie = mr.GetMovie(input);
            
        }
        return retrievedMovie;
    }
}

