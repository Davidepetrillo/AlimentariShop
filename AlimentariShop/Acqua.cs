using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    internal class Acqua : Prodotto
    {
        public int numeroBottiglie;
        public double litri;
        public string materialeBottiglie;
        public double ph;
        public string sorgente;

        public Acqua(string nome, string descrizione, double prezzo, int iva, int numeroBottiglie, double litri, string materiale, double ph, string sorgente, int quantitaAMagazzino) : base(nome, descrizione, prezzo, iva, quantitaAMagazzino)
        {
            this.numeroBottiglie = numeroBottiglie;
            this.litri = litri;
            this.materialeBottiglie = materiale;
            this.ph = ph;
            this.sorgente = sorgente;
        }
    }

}
