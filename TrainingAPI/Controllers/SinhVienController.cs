﻿using System;
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
    public class SinhVienController : ControllerBase
    {
        private ISinhVienService _sinhVienService;

        public SinhVienController(ISinhVienService sinhVienService)
        {
            _sinhVienService = sinhVienService;
        }

        public IActionResult Get()
        {
            var result = _sinhVienService.GetSinhViens();
            return Ok(result);
        }
    }
}