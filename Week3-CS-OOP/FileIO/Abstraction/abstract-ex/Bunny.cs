class Bunny : Animal, IHerbivore
{
    public override void MakeSound()
    {
        System.Console.WriteLine("What's up, Doc?");
    }

    public override void EatPlant()
}