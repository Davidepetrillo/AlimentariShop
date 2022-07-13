using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }
        public string PartitaIva { get; set; }

        public Cliente(string nome, string cognome, string codiceFiscale, string partitaIva)
        {
            this.Nome = nome;
            this.Cognome = cognome;

            if (codiceFiscale.Length != 16)
            {
                throw new Exception("Il codice fiscale non contiene l'esatto numero di caratteri");
            }

            this.CodiceFiscale = codiceFiscale;
            this.PartitaIva = partitaIva;
        }
    }
}
