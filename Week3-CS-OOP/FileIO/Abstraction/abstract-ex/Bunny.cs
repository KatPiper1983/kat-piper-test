namespace Abstraction;

class Bunny : Animal, IHerbivore, IAdorable
{
    public override void MakeSound()
    {
        System.Console.WriteLine("What's up, Doc?");
    }

    public override void EatPlant()
}