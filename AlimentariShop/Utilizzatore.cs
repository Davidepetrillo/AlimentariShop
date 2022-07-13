using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    public class Utilizzatore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }

        public Utilizzatore(string nome, string cognome, string codiceFiscale)
        {
            this.Nome = nome;

            this.Cognome = cognome;

            if(codiceFiscale.Length != 16)
            {
                throw new Exception("Mi dispiace ma il codice da lei inserito non è valido");
            }
            this.CodiceFiscale = codiceFiscale;

        }
    }
}
