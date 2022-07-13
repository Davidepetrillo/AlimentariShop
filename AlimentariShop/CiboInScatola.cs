using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    public class CiboInScatola : Prodotto
    {
        public double peso;
        public string scadenza;
        public int numeroScatole;

        // con 'base' stiamo chiamando il costruttore della classe prodotto (costruttore della classe base)
        public CiboInScatola(string nome, string descrizione, int numeroScatole, double peso, double prezzo, int iva, string scadenza) : base(nome, descrizione, prezzo, iva)
        {
            this.peso = peso;
            this.scadenza = scadenza;
            this.numeroScatole = numeroScatole;
        }
    }
}
