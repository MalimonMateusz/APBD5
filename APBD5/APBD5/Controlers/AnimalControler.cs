using APBD_005.Properties;
using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;

namespace APBD_005.Controlers;


[Route("api/Animal")]
[ApiController]
public class AnimalControler : ControllerBase
{

    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, [FromBody] Animal updatedAnimal)
    {
        var animal = StaticData.Animals.FirstOrDefault(a => a.IdAnimal== id);
        if (animal == null)
        {
            return NotFound($"Animal with ID {id} not found.");
        }

     
        animal.NameAnimal = updatedAnimal.NameAnimal;
        animal.KategoryAnimal = updatedAnimal.KategoryAnimal;
        animal.MassAnimal = updatedAnimal.MassAnimal;
        animal.ColorsAnimal = updatedAnimal.ColorsAnimal;
        return Ok(animal);
    }
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(StaticData.Animals);
    }
    
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = StaticData.Animals.FirstOrDefault(a => a.IdAnimal == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }
        
        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult AddAnimal([FromBody] Animal animal)
    {
       
        if (animal == null || string.IsNullOrEmpty(animal.NameAnimal))
        {
            return BadRequest("Animal data is incomplete.");
        }

        
        animal.IdAnimal = StaticData.Animals.Max(a => a.IdAnimal) + 1;
        StaticData.Animals.Add(animal);
        return CreatedAtAction(nameof(GetAnimal), new { id = animal.IdAnimal }, animal);
    }

    

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = StaticData.Animals.FirstOrDefault(a => a.IdAnimal == id);
        if (animal == null)
        {
            return NotFound($"Animal with ID {id} not found.");
        }

        StaticData.Animals.Remove(animal);
        return NoContent(); 
    }
    
}