class MovieStorage
{
    /*
    This entire set up is TEMPORARY!
    We don't know how to work with Databases yet - 
    by extension - communicate with them

    SO we're going to build some devices for storing movies
    BUT everything is sadly lost every time the application shuts down
    */

    public  Dictionary<int, Movie> movies;
    public int idCounter = 1;
    //Making this constructor give us some pre-loaded Movies to work with
    public MovieStorage()
    {
        Movie movie1 = new(idCounter, "Iron Man", 5, true, 0); idCounter++;
        Movie movie2 = new(idCounter, "The Avengers", 6, true, 0); idCounter++;
        Movie movie3 = new(idCounter, "The Little Mermaid", 8, true, 0); idCounter++;

        movies = []; //sets the dictionary to an empty collection
        movies.Add(movie1.Id, movie1);
        movies.Add(movie2.Id, movie2); //alternative, more proper syntax
        movies.Add(movie3.Id, movie3);

        
    }
}