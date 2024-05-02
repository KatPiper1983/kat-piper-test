namespace Media
{
    
    class Movie
    {
        public string Title { get; set; }
        public int Rating { get; set; }
        public double Price { get; set; }

        public Movie()
        {
            Title = "";

        }

        public Movie(string Title, int Rating)
        {
            Title = Title;
            Rating = Rating;
        }
    }
}    