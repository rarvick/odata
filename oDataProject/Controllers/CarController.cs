using Microsoft.AspNetCore.Mvc;
using Data.SeedData;
using Microsoft.AspNet.OData;

namespace oDataProject.Controllers
{
    public class CarController : ControllerBase
    {
        [HttpGet, EnableQuery]
        public IActionResult Get()
        {
            return Ok(SeedingData.Cars());
        }

    }
}
