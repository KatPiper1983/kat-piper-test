class Cat : Animal, ICarnivore
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