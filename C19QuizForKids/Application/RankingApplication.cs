using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using C19QuizForKids.Repository;
using System.Collections.Generic;
using System.Linq;

namespace C19QuizForKids.Application
{
    public class RankingApplication
    {
        protected readonly MyContext _context;
        public RankingApplication(MyContext context)
        {
            _context = context;
        }

        public bool Salvar(Ranking ranking)
        {
            RankingRepository rankingRepository = new RankingRepository(_context);
            return rankingRepository.Salvar(ranking);
            

        }

        public List<Ranking> BuscarTodos()
        {
            var lista = new RankingRepository(_context).BuscarTodos();
            lista = lista.OrderByDescending(x => x.Pontuacao).ToList();
            return lista;
        }
    }
}
