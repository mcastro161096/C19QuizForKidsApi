using C19QuizForKids.Context;
using C19QuizForKids.Entities;

namespace C19QuizForKids.Repository
{
    public class NicknameRepository
    {

        protected readonly MyContext _context;
        public NicknameRepository(MyContext context)
        {
            _context = context;
        }

        public bool Salvar(Jogador nickname)
        {
            _context.Nickname.Add(nickname);
            _context.SaveChanges();
            return true;
        }
    }
}