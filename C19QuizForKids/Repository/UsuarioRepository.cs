using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C19QuizForKids.Repository
{
    public class UsuarioRepository
    {
        protected readonly MyContext Db;

        public UsuarioRepository(MyContext db)
        {
            Db = db;
        }

        public bool JaExiste(string email)
        {
           return Db.Usuarios
                .Any(x => x.Email == email);
        }


        public bool Salvar(Usuario usuario)
        {
            Db.Usuarios.Add(usuario);
            Db.SaveChanges();
            return true;
        }


    }
}
