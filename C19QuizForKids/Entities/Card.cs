using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C19QuizForKids.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public string Pergunta { get; set; }
        public string Explicacao { get; set; }
        public string Imagem { get; set; }
        public bool Resposta { get; set; }
    }
}
