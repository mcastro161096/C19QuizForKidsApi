using C19QuizForKids.Application;
using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace C19QuizForKids.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankingController : Controller
    {
        protected readonly MyContext _context;
        public RankingController(MyContext context)
        {
            _context = context;
        }


        // GET: RankingController
        public ActionResult GetAll()
        {
            try
            {
                return Ok(new RankingApplication(_context).BuscarTodos());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

      

        // POST: RankingController/Create
        [HttpPost]
        
        public ActionResult Create(Ranking ranking)
        {
            try
            {
                RankingApplication rankingApplication = new RankingApplication(_context);
                rankingApplication.Salvar(ranking);
                return Ok();
            }
            catch
            {
                return View();
            }
        }

       

    }
}
