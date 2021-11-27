using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using System.Collections.Generic;
using System.Linq;

namespace C19QuizForKids.Repository
{
    public class RankingRepository
    {
        
            protected readonly MyContext _context;
            public RankingRepository(MyContext context)
            {
                _context = context;
            }

            public bool Salvar(Ranking ranking)
            {
                _context.Ranking.Add(ranking);
                _context.SaveChanges();
                return true;
            }


        public List<Ranking> BuscarTodos()
        {
            return _context.Ranking.ToList();
        }
    }
}
