using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica.Models;

namespace Practica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public PersonaController(ApplicationDbContext _context)
        {
            db = _context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return null;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return null;
        }

        [HttpPost]
        public ActionResult Post([FromBody] CreatePersonaModel Persona)
        {
            return null;
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id)
        {
            return null;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return null;
        }
    }
}
