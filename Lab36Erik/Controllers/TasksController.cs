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
        [HttpGet("{id:int?}")] 
        public string Get(string id)
        {
            return "Got this";
        }

        //Post 

        //Put 

        //Delete 
    }
}
