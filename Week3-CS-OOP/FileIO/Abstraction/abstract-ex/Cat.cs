namespace Abstraction;

class Cat : Animal, ICarnivore, IAdorable
{
    public int Value { get; set; }

    public override void Sleep()
    {
        System.Console.WriteLine("Curls into fluff ball");
    }



    public override void MakeSound()
    {
        System.Console.WriteLine("Meow Meow Meoooooooow!");
    }

    public void EatMeat()
    {
        System.Console.WriteLine("Eats some meat.");
    }
}