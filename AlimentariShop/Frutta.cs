using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    internal class Frutta : Prodotto
    {

        public double Peso;

        public Frutta(string nome, string descrizione, double peso, double prezzo, int iva, int quantitaAMagazzino) : base(nome, descrizione, prezzo, iva, quantitaAMagazzino)
        {
            this.Peso = peso;
        }

    }
}
