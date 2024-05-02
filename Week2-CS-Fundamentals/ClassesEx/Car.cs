using System.Drawing;

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

    public override string ToString()
    {
        string str = "";
        str += "Car {Color:" + color;
        str += "; Make: " + make;
        str += "; Model: " + model;
        str += "; Year: " + year;
        str += "; Mileage: " + mileage + " }";

        return str;
    }

    public Car()
    {
        color = "Black";
    }

    public Car(string color)
    {
        //color = newColor;
        //System.Console.WriteLine(color);
        this.color = color;
    }//full-arg constructor- meaning a choice of us providing ALL the values for our fields
    public Car (string color, string make, string model, int year, int mileage)
    {
        this.color = color;
        this.make = make;
        this.model = model;
        this.year = year;
        this.mileage = mileage;
    }
 

        //Copy constructor
        public Car(Car other)
        {
            color = other.color;
            make = other.make;
            model = other.model;
            year = other.year;
            mileage = other.mileage;

        }
}