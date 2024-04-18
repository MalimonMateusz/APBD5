using APBD_005.Properties;
using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;

namespace APBD_005.Controlers;


[Route("api/Visit")]
[ApiController]
public class VisitControler : ControllerBase
{




    [HttpGet("{id}")]
    public IActionResult GetVisit(int id)
    {
        StaticData.LoadRelationships(); 

        var visit = StaticData.Visits.FirstOrDefault(v => v.id == id);
        if (visit == null)
        {
            return NotFound($"Visit with ID {id} not found.");
        }

        return Ok(visit);
    }



    [HttpPost]
    public IActionResult AddVisit([FromBody] Visit visit)
    {
        StaticData.Visits.Add(visit);
        return Created($"/visits/{visit.id}", visit);
    }
    
}