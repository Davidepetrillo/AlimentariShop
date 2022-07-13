using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    internal class Affettati : Prodotto
    {
        public double peso;

        public Affettati(string nome, string descrizione, double peso, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {
            this.peso = peso;
        }
    }
}
