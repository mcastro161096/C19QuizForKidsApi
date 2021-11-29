using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C19QuizForKids.Repository
{
    public class CardRepository
    {
        protected readonly MyContext _context;
        public CardRepository(MyContext context)
        {
            _context = context;
        }

        public List<Card> BuscarTodos()
        {
            return _context.Cards.ToList();
        }
    }
}
