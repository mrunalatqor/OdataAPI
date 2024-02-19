using Dot7.OData.Demo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace Dot7.OData.Demo.Controllers;

public class EmployeeODataController: ODataController
{
    private readonly MyWorldDbContext _myWorldDbContext;
    public EmployeeODataController(MyWorldDbContext myWorldDbContext)
    {
        _myWorldDbContext = myWorldDbContext;
    }

    [EnableQuery]
    public async Task<IActionResult> Get()
    {
        return Ok(_myWorldDbContext.Employee.AsQueryable());
    }
}