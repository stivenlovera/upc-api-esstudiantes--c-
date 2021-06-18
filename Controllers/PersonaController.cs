﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using cumbre_estudiante.Context;
namespace cumbre_estudiante.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonaController: ControllerBase
    {
        private readonly AppDbContext context;
        public PersonaController(AppDbContext _context)
        {
            this.context = _context;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            //Error handling Try-catch
            return Ok(context.persona.ToList());
        }
    }
}
