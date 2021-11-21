using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using C19QuizForKids.Repository;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C19QuizForKids.Application
{
    public class UsuarioApplication
    {
        protected readonly MyContext Db;

        public UsuarioApplication(MyContext db)
        {
            Db = db;
        }

        public JObject Salvar(Usuario usuario)
        {
            JObject objetoRetorno = new JObject();
            try
            {
                var repository = new UsuarioRepository(Db);
                if (repository.JaExiste(usuario.Email))
                {
                    objetoRetorno.Add("success", false);
                    objetoRetorno.Add("message", "Este email já está em uso.");
                    return objetoRetorno;
                }
                repository.Salvar(usuario);
                objetoRetorno.Add("success", true);
                return objetoRetorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
