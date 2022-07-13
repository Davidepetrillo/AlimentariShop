using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    internal class Proprietario : Utilizzatore
    {
        public string PartitaIva { get; set; }

        public Proprietario(string nome, string cognome, string codiceFiscale, string partitaIva) : base(nome, cognome, codiceFiscale)
        {
            this.PartitaIva = partitaIva;
        }
    }

}
