using C19QuizForKids.Context;
using C19QuizForKids.Entities;

namespace C19QuizForKids.Application
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
            RankingRepository rankingRepository = new RankingRepository(_context);
            return rankingRepository.Salvar(ranking);
            

        }
    }
}
