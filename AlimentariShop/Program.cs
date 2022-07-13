using AlimentariShop;



List<Prodotto> laMiaListaDiProdotti = new List<Prodotto>();

foreach(Prodotto prodotto in laMiaListaDiProdotti)
{
    Random random = new Random();
    long codice = random.Next(10000);
}

Prodotto Cereali = new Prodotto("Cereali", "Cereali a base di miele e cannella ", 1.99, 17, 45);
laMiaListaDiProdotti.Add(Cereali);
Frutta Banana = new Frutta("Banana", "Banane coltivate in Brasile e prodotte in Guatemala", 2, 1.69, 19, 50);
laMiaListaDiProdotti.Add(Banana);
Acqua Lete = new Acqua("Lete", "L’acqua che il tuo corpo vuole", 2.19, 18, 6, 2, "plastica", 6.30, "Appennino meridionale",60);
laMiaListaDiProdotti.Add(Lete);
CiboInScatola Tonno = new CiboInScatola("Tonno", "Nostromo - Tonno Leggero all'Olio di Oliva con -60% di Grassi, Qualità Pinne Gialle, Senza Conservanti", 6, 60, 2.99, 8, "12/09/2023",40);
laMiaListaDiProdotti.Add(Tonno);

void Identificativo(long codice, string nome)
{
    Console.WriteLine($"Codice identificativo: {codice}-{nome}");
}

Console.WriteLine();
Console.WriteLine("-------------------- Prodotti disponibili --------------------");
Console.WriteLine();
Console.WriteLine();

foreach(Prodotto prodotto in laMiaListaDiProdotti)
{
        Console.WriteLine("----- Prodotto -------");
        Console.WriteLine("Codice: " + prodotto.codice);
        Console.WriteLine("Nome: " + prodotto.nome);
        Console.WriteLine("Descrizione: " + prodotto.descrizione);

    if(prodotto == Tonno)
    {
        Console.WriteLine($"Numero scatole: {Tonno.numeroScatole}");
        Console.WriteLine($"Peso: {Tonno.peso}gr/scatola");
        Console.WriteLine($"Scadenza: {Tonno.scadenza}");
        Console.WriteLine($"Quantità disponibile a magazzino: {Tonno.QuantitaAMagazzino} scatolette");
    }
    if (prodotto == Banana)
    {
        Console.WriteLine($"Peso: {Banana.Peso}kg/p.");
        Console.WriteLine($"Quantità disponibile a magazzino: {Banana.QuantitaAMagazzino} kg");
    }
    if (prodotto == Lete)
    {
        Console.WriteLine($"Numero bottiglie: {Lete.numeroBottiglie}/confezione");
        Console.WriteLine($"Litri: {Lete.litri}/bottiglia");
        Console.WriteLine($"Quantità disponibile a magazzino: {Lete.QuantitaAMagazzino/6} casse");
        Console.WriteLine($"Materiale bottiglie: {Lete.materialeBottiglie}");
    }

        Console.WriteLine($"Prezzo: {prodotto.prezzo} euro");
        Console.WriteLine($"IVA: {prodotto.iva}%");
        Console.WriteLine($"Prezzo finale: {prodotto.PrezzoPiuIva(prodotto.prezzo, prodotto.iva)} euro");
        Console.WriteLine($"Codice esteso: {prodotto.PadLeft()}");
        Identificativo(prodotto.codice, prodotto.nome);
        Console.WriteLine("------------------");
}

