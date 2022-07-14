using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    public class Prodotto
    {
        public long codice;
        public string Nome { get; set; }
        public string descrizione { get; set; }
        public double prezzo { get; set; }
        public int iva { get; set; }
        public string Type { get; set; }
        public int QuantitaAMagazzino { get; set; }

        public Prodotto(string nome, string descrizione, double prezzo, int iva, string type, int quantitaAMagazzino)
        {
            this.Nome = nome;
            this.descrizione = descrizione;

            if (prezzo <= 0)
            {
                throw new Exception("Mi dispiace ma il prezzo del prodotto deve essere almeno 0,01euro");
            }

            this.prezzo = prezzo;

            if (iva <= 0)
            {
                throw new Exception("Mi dispiace ma l'iva del prodotto deve essere superiore allo 0%");
            }

            this.iva = iva;

            if(quantitaAMagazzino <= 0)
            {
                throw new Exception("Si prega di inserire un numero di unità positivo");
            }

            this.QuantitaAMagazzino = quantitaAMagazzino;
            this.Type = type;
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
