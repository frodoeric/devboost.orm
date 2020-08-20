﻿using System;
using System.Collections.Generic;
using System.Text;

namespace devboost.ORM.Entities
{
    public class Posicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Jogador> Jogadores { get; set; }
    }
}
