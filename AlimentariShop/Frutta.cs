using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    internal class Frutta : Prodotto
    {

        private double peso;

        public Frutta(string nome, string descrizione, double peso, double prezzo, int iva) : base(nome, descrizione, prezzo, iva)
        {

        }

    }
}
