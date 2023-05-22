using ExampleApi.Shared.EF;
using ExampleApi.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;

namespace ExampleApi.Controllers
{
 
    //[Route("api/[controller]")]
    public class TeamsController : ODataController
    {
        private readonly ILogger<TeamsController> _logger;

        public TeamsController(ILogger<TeamsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [EnableQuery]
        public ActionResult<IEnumerable<Team>> Get()
        {
            ExampleDBContext db = new ExampleDBContext();
            db.Database.EnsureCreated();            

            return Ok(db.Teams.AsNoTracking().AsQueryable());
        }
    }
}