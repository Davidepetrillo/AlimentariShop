using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    internal class Prodotto
    {
        public long codice;
        public string nome { get; set; }
        public string descrizione { get; set; }
        public double prezzo { get; set; }
        public int iva { get; set; }


        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
            Random random = new Random();
            codice = random.Next(1000);
        }

        public string GetCodice()
        {
            string codiceConIlPadding;
            codiceConIlPadding = PadLeft();
            return codiceConIlPadding;
        }


        public double PrezzoPiuIva(double prezzo, int iva)
        {
            double prezzoFinale = prezzo + ((prezzo * iva) / 100);
            double prezzoFinaleArrotondato = Math.Round(prezzoFinale, 2);
            return prezzoFinaleArrotondato;
        }


        public string PadLeft()
        {
            string codiceString = codice.ToString();
            char zero = '0';
            return codiceString.PadLeft(8, zero);
        }


    }
}
