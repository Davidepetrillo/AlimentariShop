using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    internal class Cliente : Utilizzatore
    { 

        public Cliente(string nome, string cognome, string codiceFiscale) : base(nome, cognome, codiceFiscale)
        {
           
        }
    }
}
