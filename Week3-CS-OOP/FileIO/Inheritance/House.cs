class House : Building //tells C# that House is a class that drives itself from Building
{

    public int Bedrooms { get; set; }
    public string Owner { get; set; }
    public House() : base() //base is an implied piece of code
    {
        System.Console.WriteLine("Now lets make that Building into a House");
        Owner = "";
    }
    public House(int walls, int area) : base(walls, area)
    {
         Owner = "";
         System.Console.WriteLine("Now let's make Building into a House!");
    }

    public House (int walls, int area, int bedrooms, string owner) : base (walls, area)
    {
        
        Bedrooms = bedrooms;
        Owner = owner; 
    }

    public override string ToString()
    {
        return "{Walls: " + Walls + " Area: " + Area + " ,bedrooms:" + Bedrooms + " ,Owner: '" + Owner + "'}";
        //return base.ToString();//calls parent class ToString method
    }

}