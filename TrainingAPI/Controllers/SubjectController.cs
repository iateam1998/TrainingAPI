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
    public class SubjectController : ControllerBase
    {
        private ISubjectService _subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        public IActionResult Get()
        {
            var result = _subjectService.GetSubjects();
            return Ok(result);
        }
    }
}
