using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab36Erik.Controllers
{
    [Route("api/[Controller]")]
    public class TasksController : ControllerBase
    {
        //Get
        //this code uses binding to pass in an id
        [HttpGet("{id:int?}")] 
        public string Get(string id)
        {
            return $"Got this {id}";
        }

        //Post 
        [HttpPost("{id:int?}")]
        public void Post(string id)
        {

        }
        //Put 

        //Delete 
    }
}
