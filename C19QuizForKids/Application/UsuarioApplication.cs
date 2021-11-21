using C19QuizForKids.Context;
using C19QuizForKids.Entities;
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

                Db.Usuarios.Add(usuario);
                Db.SaveChanges();
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
