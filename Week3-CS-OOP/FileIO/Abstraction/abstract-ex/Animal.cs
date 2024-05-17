namespace Abstraction;

abstract class Animal


{
    public string Species { get; set;}

    public Animal()
    {
        Species = "";
    }

    //Two types of Methods you can make in Abstract Classes:
    //Concrete Methods - These methods have an Implementation (it does something)

    public virtual void Sleep()
    {
        System.Console.WriteLine("Animal rests to recover energy.");
    }
    //Abstract Methods- these methods will not have an implementation
    //any class (that is not also abstract) will have to provide said implementation

    public abstract void MakeSound();

}