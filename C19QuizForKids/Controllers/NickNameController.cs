using C19QuizForKids.Application;
using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C19QuizForKids.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NicknameController : Controller
    {
        protected readonly MyContext _context;
        public NicknameController(MyContext context)
        {
            _context = context;
        }
       

        [HttpPost]
        public ActionResult Create(Jogador jogador)
        {
            try
            {
                NicknameApplication nicknameApplication = new NicknameApplication(_context);
                return Ok(nicknameApplication.Salvar(jogador));
                //return Ok();
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }
    }
}
