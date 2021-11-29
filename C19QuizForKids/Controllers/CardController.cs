using C19QuizForKids.Application;
using C19QuizForKids.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C19QuizForKids.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : Controller
    {
        protected readonly MyContext _context;
        public CardController(MyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(new CardApplication(_context).BuscarTodos());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
