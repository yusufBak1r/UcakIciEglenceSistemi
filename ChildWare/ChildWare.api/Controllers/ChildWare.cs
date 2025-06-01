using ChildWare.api.Model;
using ChildWare.api.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChildWare.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChildWareController : ControllerBase
    {


     

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChildWareModel>>> GetAll()
        {
            
         
            return Ok();
        }
    }
}
