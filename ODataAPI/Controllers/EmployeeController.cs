using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataAPI.Data;
namespace ODataAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ODataController
    {
       private readonly ODataDbContext _dbContext;

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger, ODataDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Employee.AsQueryable());
        }
    }
}
