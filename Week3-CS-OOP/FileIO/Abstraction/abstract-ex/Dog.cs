namespace Abstraction;

class Dog : Animal, ICarnivore
{

    public string FavoriteChewToy { get; set; }
    public int Value { get; set; }

    public override void MakeSound()
    {
        System.Console.WriteLine("Bark bark bark bark!");
    }

    public void EatMeat()
    {
        System.Console.WriteLine("Eats some puppy chow");
    }

    

    public Dog()
    {
        FavoriteChewToy = "";
    }
}