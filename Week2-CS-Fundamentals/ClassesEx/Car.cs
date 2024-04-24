class Car
{
    //Fields
    public string color;
    public string make;
    public string model;
    public int year;
    public int mileage;

    //Methods
    public void Honk()
    {
        Console.WriteLine("Honk Honk!");
    }

    public void Drive(int miles)
    {
        mileage += miles;
        Console.WriteLine("The new total mileage is: " + mileage);
    }

    


}