using DogAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace DogAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class DogController : ControllerBase
{
    public static List<Dog> Dogs = new List<Dog>
    {
        new Dog(1, "Golden Retriver", 12, true),
        new Dog(2, "Standard Poodle", 10, false),
        new Dog(3, "Beagle", 8, true),
        new Dog(4, "German Shepard", 6, false),
        new Dog(5, "Dalmation", 4, true),
    };

    [HttpGet]

    public IActionResult GetDogs()
    {
        return Ok(Dogs);
    }
    [HttpPost]
    public IActionResult PostDog(Dog dog)
    {
        dog.DogId = Dogs.Count + 1;
        Dogs.Add(dog);
        return Ok();

    }

    [HttpPut("{Id}")]
    public IActionResult PutDog(int Id, Dog updatedDog )
    {
        int index = Dogs.FindIndex(d => d.DogId == Id);
        Dogs[index] = updatedDog;

        return Ok();
    }
    [HttpDelete("{Id}")]
    public IActionResult Deletedog(int Id)
    {
        foreach(Dog dog in Dogs)
        {
            if(dog.DogId == Id)
            {
                Dogs.Remove(dog);
                return Ok();
            }
        }
        return NotFound();
    }

}