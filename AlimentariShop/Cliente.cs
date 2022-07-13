﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    internal class Cliente : Utilizzatore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }
        public string MetodoDiPagamento { get; set; }

        public Cliente(string nome, string cognome, string codiceFiscale, string metodoDiPagamento) : base(nome, cognome, codiceFiscale)
        {
           
            this.MetodoDiPagamento = metodoDiPagamento;
        }
    }
}
