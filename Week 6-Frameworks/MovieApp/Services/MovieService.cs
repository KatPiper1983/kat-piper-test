class MovieService
{
    /*
        Services:
            - Checkout Movie
            - Checkin Movie
            - View (Your) Checked out movies (Get)
            - View Available Movies (Get)
        Trivial Services:
            - Rememmber why we organize app into layers
                - It allows us to organize and clearly conceptualize the flow of operations
                within the app at any given moment in time
                - we like to have the app ALWAYS flow Up and Down one Layer at a time

    */
    MovieRepo mr = new();
    //m is the movie we want to attempt to check in
    public Movie Checkin(Movie m)
    {

    if (m.Available || m.ReturnDate ==0)
    {
        System.Console.WriteLine("Movie currently not checked out");
        return null; //movie doesn't get checked in
    }
    }
    //m is the movie we want to attempt to check out
    public Movie Checkout(Movie m)
    {
        //Lets first check to see if the Movie is Available - OR lets return 
        //null if its not available - get that out of the way

        if(m.Available)
        {
            //then perform the check out
            //what does it mean to check out the movie?
            //1) the movie becomes unavailable
            //2) a returnDate is set
            //3) (Optional) - it's set to a particular user
            //Make sure to update the data storage with these changes
            m.Available = false;
            m.ReturnDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + (60*60*48);
            // Make sure to update the data storage with these changes
            mr.UpdateMovie(m);
            return new(); //choosing to send back the checked out movie
        }
        else
        {
            System.Console.WriteLine("Movie Currently Unavailable");
            return null; //Movie doesn't get checked out
        }
    }

    public List<Movie> GetAvailableMovies()
    {
        //Get All Movies
        List<Movie> allMovies = mr.GetAllMovies();
        //Then filter out movies you don't want
        List<Movie> availableMovies = new();
        //run a loop over all movies to determine if they make the cut
        foreach( Movie m in allMovies)
        {
            if(m.Available)
            {
                availableMovies.Add(m);
            }
        }



        //Return that filtered list
        return availableMovies; 
    }

    public Movie? GetMovie(int id)
    {
        return mr.GetMovie(id);
    }

}