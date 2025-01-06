using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KumarTMC_2__Add2Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2numberController : ControllerBase
    {
        [HttpGet]
        [Route("Add/{num1}/{num2}")]
        public string Add(int num1, int num2){
            return $"{num1} + {num2} = {num1 + num2}.";
        }
    }
}