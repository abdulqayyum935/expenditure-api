using System.Linq;
using ExpenditureApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenditureApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncomeController:ControllerBase
    {
        private readonly ExpenditureContext db;
        public IncomeController(ExpenditureContext _context){
            db=_context;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody]Income incomeObj)
        {
            db.Income.Add(incomeObj);
            db.SaveChanges();
            return Ok(incomeObj);
        }
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll(){
            return Ok(db.Income.ToList());
        }
    }
}