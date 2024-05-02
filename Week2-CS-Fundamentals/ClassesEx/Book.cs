class Book
{
    /*
    General Structure to Models:
        - fields (Properties)
        - constructors
        - methods

    */
    //Fields
    string title;
    string author;
    int pages;

    //Alternative - Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    //Constructors
    public Book()
    {

    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    //Getters and Setters
    public string GetTitle()
    {
        return title;
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }


    //Methods

    //ToString





}