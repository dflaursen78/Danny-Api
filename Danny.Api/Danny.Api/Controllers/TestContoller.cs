﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Danny.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TestContoller : Controller
    {
        [HttpGet]
        [Route("apiGetTest")]
        public IActionResult Get()
        {
            return Ok("ferie nu");
        }
    }
}
