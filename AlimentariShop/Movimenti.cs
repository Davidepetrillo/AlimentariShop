using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentariShop
{
    internal class Movimenti
    {
        public double costoNetto;
        public double costoLordo;
        public double margine;
        public Prodotto prodotto;

        public Movimenti(double costoNetto, double costoLordo, double margine, Prodotto prodotto)
        {
            this.costoNetto = costoNetto;
            this.costoLordo = costoLordo;
            this.margine = margine;
            this.prodotto = prodotto;
        }

        public int Rifornimento(Prodotto prodotto, int quantitaDaRifornire)
        {
            prodotto.QuantitaAMagazzino = prodotto.QuantitaAMagazzino + quantitaDaRifornire;
            return prodotto.QuantitaAMagazzino;

        }

        public int Acquisto(Prodotto prodotto, int quantitaDaAcquistare)
        {
            if ((quantitaDaAcquistare < 0) || (quantitaDaAcquistare > prodotto.QuantitaAMagazzino))
            {
                throw new Exception("Mi dispiace ma l'operazione non è disponibile");
            }
            else
            {
                prodotto.QuantitaAMagazzino = prodotto.QuantitaAMagazzino - quantitaDaAcquistare;
            }

            return prodotto.QuantitaAMagazzino;
        }

    }
}
