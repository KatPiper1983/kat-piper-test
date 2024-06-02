namespace DogAPI.Model;

public class Dog
{
    public int DogId { get; set; }
    public string DogBreed { get; set; }
    public int DogAge { get; set; }
    public bool Fixed {get; set; }


public Dog(int DogId, string DogBreed, int DogAge, bool Fixed)
{
    this.DogId = DogId;
    this.DogBreed = DogBreed;
    this.DogAge = DogAge;
    this.Fixed = Fixed;
}
}