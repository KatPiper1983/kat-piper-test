using Microsoft.AspNetCore.Mvc;
using VehicleAPI.Models;

namespace VehicleAPI.Controllers;

[ApiController]
[Route("[controller]")] //http://localhost:port/VehicleController

public class VehicleController : ControllerBase
{
    //this controller will receive HTTP requests to the path /vehicle
    //based on http method it receives, it will direct the request to different 'actions'
    public static List<Vehicle> Vehicles = new List<Vehicle>
    {
        new Vehicle(1, "Toyota", "Camry", 2010, false),
        new Vehicle(2, "Honda", "Accord", 2011, false),
        new Vehicle(3, "Subaru", "Outback", 2013, true),
        new Vehicle(4, "Toyota", "PriusV", 2014, true),
        new Vehicle(5, "Jeep", "Wrangler", 2015, false),
    };
    

    //GET all vehicles
    [HttpGet] // beginning part of GET action to the path /Vehicle.  Needed to let controller know this method should be called when a GET request is sent to /Vehicle
    public IActionResult GetVehicles()
    {
        return Ok(Vehicles);
    }

    //GET a vehicle by ID
    //expecting client to send GET request to /Vehicle and also provide a /Id
 // Id needs to be an integer, ex: http://localhost:port/Vehicle/1

    [HttpGet("{Id}")]                 
    public IActionResult GetVehiclebyId(int Id)
    {
        //example of functional programming
        //have an array and want to filter through that array and grab the first thing that matches correct ID
        //create LINQ onto the Vehicles array that will filter through each of the vehicles and check to see if the VehicleID
        //matches the ID that was passed int
        //if matches, then it will return that vehicle
        Vehicle vehicle = Vehicles.Find(v => v.VehicleId ==Id);
        return Ok(vehicle);
    }

    //POST a new vehicle
    // send data in http request body as a JSON object
    //JSON has to match the field names of the model we are using
    [HttpPost]
    public IActionResult PostVehicle(Vehicle vehicle)
    {
        vehicle.VehicleId = Vehicles.Count + 1;
        Vehicles.Add(vehicle);
        return Ok();
    }

    //PUT a new update on an existing vehicle
    [HttpPut("{Id}")]
    public IActionResult PutVehicle(int Id, Vehicle updatedVehicle)
    {
        //System.Console.WriteLine(Id);
        //System.Console.WriteLine(updatedVehicle);

        int index = Vehicles.FindIndex(v => v.VehicleId == Id);
        Vehicles[index] = updatedVehicle;

        return Ok();
    }

    //DELETE an existing vehicle
    [HttpDelete("{Id}")]
    public IActionResult DeleteVehicle(int Id)
    {
        foreach(Vehicle vehicle in Vehicles)
        {
            if(vehicle.VehicleId == Id)
            {
                Vehicles.Remove(vehicle);
                return Ok();
            }
        }
        return NotFound();
    }

}