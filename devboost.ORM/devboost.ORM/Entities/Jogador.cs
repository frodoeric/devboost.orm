using System;
using System.Collections.Generic;
using System.Text;

namespace devboost.ORM.Entities
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Posicao Posicao { get; set; }
        public Clube Clube { get; set; }
        public int Id_Clube { get; set; }
        public int Id_Posicao { get; set; }
    }
}
