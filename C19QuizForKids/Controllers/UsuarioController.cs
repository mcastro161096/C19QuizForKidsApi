using C19QuizForKids.Application;
using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace C19QuizForKids.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        protected readonly MyContext _context;
        public UsuarioController(MyContext context)
        {
            _context = context;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                var usuarioapplication = new UsuarioApplication(_context);
                return Ok(usuarioapplication.Salvar(usuario));
            }
            catch (Exception e)
            {
                JObject objetoRetorno = new JObject();

                objetoRetorno.Add("success", false);
                objetoRetorno.Add("message", e.Message);
                return BadRequest(objetoRetorno);
            }
           
        }
        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
