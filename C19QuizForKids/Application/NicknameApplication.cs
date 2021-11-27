using System;
using C19QuizForKids.Context;
using C19QuizForKids.Entities;
using C19QuizForKids.Repository;
using Newtonsoft.Json.Linq;

namespace C19QuizForKids.Application
{
    public class NicknameApplication
    {
        protected readonly MyContext _context;
        public NicknameApplication(MyContext context)
        {
            _context = context;
        }

        public JObject Salvar(Jogador jogador)
        {
            

            JObject objetoRetorno = new JObject();
            try
            {
                NicknameRepository nicknameRepository = new NicknameRepository(_context);
               var sucesso = nicknameRepository.Salvar(jogador);

                if (sucesso)
                {
                    objetoRetorno.Add("nickname", jogador.NickName);
                    objetoRetorno.Add("success", true);
                    return objetoRetorno;
                }
                objetoRetorno.Add("success", false);
                return objetoRetorno;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
