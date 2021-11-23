using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using C19QuizForKids.Repository;

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
    }
}
