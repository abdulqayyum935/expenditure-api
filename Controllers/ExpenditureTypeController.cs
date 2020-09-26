using System.Linq;
using ExpenditureApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenditureApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenditureTypeController:ControllerBase
    {

    private readonly ExpenditureContext db;
    public ExpenditureTypeController(ExpenditureContext context){
        db=context;
    }

    [HttpPost]
    [Route("add-expenditure")]
    public IActionResult Add([FromBody]ExpenditureType expenditureType){
        db.ExpenditureType.Add(expenditureType);
        db.SaveChanges();
        return Ok(expenditureType);
    }
[HttpGet]
[Route("get-all")]
public IActionResult GetAll(){
    return Ok(db.ExpenditureType.ToList());
}
    }
}