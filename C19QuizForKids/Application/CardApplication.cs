using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using C19QuizForKids.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C19QuizForKids.Application
{
    public class CardApplication
    {

        protected readonly MyContext _context;
        public CardApplication(MyContext context)
        {
            _context = context;
        }

        public List<Card> BuscarTodos()
        {
            return new CardRepository(_context).BuscarTodos();
        }


    }
}
