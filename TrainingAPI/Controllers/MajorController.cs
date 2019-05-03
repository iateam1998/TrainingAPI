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
    public class MajorController : ControllerBase
    {
        private IMajorService _majorService;

        public MajorController (IMajorService majorService)
        {
            _majorService = majorService;
        }

        public IActionResult Get()
        {
            var result = _majorService;
            return Ok(result);
        }
    }
}
