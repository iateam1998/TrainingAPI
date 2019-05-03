using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataService.Service.ServiceAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private IClassesService1 _classesService1;

        public ClassesController(IClassesService1 classesService1)
        {
            _classesService1 = classesService1;
        }

        public IActionResult Get()
        {
            var result = _classesService1.GetClasses();
            return Ok(result);
        }
    }
}
