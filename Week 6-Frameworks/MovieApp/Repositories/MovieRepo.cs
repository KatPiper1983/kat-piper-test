class MovieRepo
{

    /*
    This class is in the Data Access/Repository Layer of our app
    It's solely responsible for any data access and management centered
    around our Movie Object

    4 Major Operations we'd like to manage in this location
        - CRUD Operations (Create, Read, Update, Delete)
        - Create- add data
        - Read- Read/Retrieve data
        - Update- changes made to any objects
        - Delete- remove data objects
    */

    MovieStorage movieStorage = new ();
    public Movie AddMovie(Movie m)
    {
        //We need to first ensure that the movie being added has a correct ID
        //Assume it doesn't...and force it to have a correct ID using ID counter
        m.Id = movieStorage.idCounter++; //incrementing value afterwards to prep it for next time is needed

        //Add movie into our collection
        movieStorage.movies.Add(m.Id, m);
        return m;
    }
    public Movie? GetMovie(int id)
    {
        if(movieStorage.movies.ContainsKey(id))
        {
            Movie selectedMovie = movieStorage.movies[id];
            return selectedMovie;
            //return movieStorage.movies[id]; - fancy approach to above code
        }
        else
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again:");
            return null;
        }
    }
       //THIS IS A NEW METHOD!
    //No Parameters because...get everything is get everything. No options to choose.
    public List<Movie> GetAllMovies()
    {
        //I am chooseing to return a List because that is a much more common collection to
        //work with. It does mean I have to do a little bit of work here - but its not bad.
        return movieStorage.movies.Values.ToList();
    }

    public Movie? UpdateMovie(Movie updatedMovie)//updating storage in method
    {
        //assuming that the ID is consistent with an ID that exists
        //then just have to update the value (aka Movie) for the said key (ID) within the Dictionary
        try 
        {
            movieStorage.movies[updatedMovie.Id] = updatedMovie;
        
            //choose to send updated movie back as a "response-feedback" system
            //conveys that i've updated the storage with this movie I send back to you
            return updatedMovie;
        }
        catch(Exception e)
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again");
            return null;
        }
    }
    public Movie? DeleteMovie(Movie m)
    {
        
        //If we have the ID-> then remove it from storage
        bool didRemove = movieStorage.movies.Remove(m.Id);
        if (didRemove)
        {
            //now we will return the movie that got deleted
            return m;
        }
       
        else
        {
            System.Console.WriteLine("Invalid Movie ID - Please Try Again");
            return null;
        }
    }

}