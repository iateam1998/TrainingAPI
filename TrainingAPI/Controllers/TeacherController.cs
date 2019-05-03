using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataService.Model.RequestModel;
using DataService.Service.ServiceAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrainingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public IActionResult Get([FromQuery] TeacherRequestModel requestModel)
        {
            var result = _teacherService.GetTeachers(requestModel);
            return Ok(result);
        }
    }
}
