using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    internal class Proprietario : Utilizzatore
    {
        public long PartitaIva { get; set; }

        internal string Password;

        public Proprietario(string nome, string cognome, string codiceFiscale, long partitaIva, string password) : base(nome, cognome, codiceFiscale)
        {
            if(partitaIva > 99999999999)
            {
                throw new Exception("Mi dispiace ma la partita Iva da lei inserita non è corretta");
            }

            this.PartitaIva = partitaIva;
            this.Password = password;
        }
    }

}
