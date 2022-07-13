using AlimentariShop;



List<Prodotto> laMiaListaDiProdotti = new List<Prodotto>();

foreach(Prodotto prodotto in laMiaListaDiProdotti)
{
    Random random = new Random();
    long codice = random.Next(10000);
}

Prodotto Cereali = new Prodotto("Cereali", "Cereali a base di miele e cannella ", 1.99, 17);
laMiaListaDiProdotti.Add(Cereali);
Frutta Banana = new Frutta("Banana", "Banane coltivate in Brasile e prodotte in Guatemala", 2, 1.69, 19);
laMiaListaDiProdotti.Add(Banana);
Acqua Lete = new Acqua("Lete", "L’acqua che il tuo corpo vuole", 2.19, 18, 6, 2, "plastica", 6.30, "Appennino meridionale");
laMiaListaDiProdotti.Add(Lete);
CiboInScatola Tonno = new CiboInScatola("Tonno", "Nostromo - Tonno Leggero all'Olio di Oliva con -60% di Grassi, Qualità Pinne Gialle, Senza Conservanti", 6, 60, 2.99, 8, "12/09/2023");
laMiaListaDiProdotti.Add(Tonno);
// Affettati ProsciuttoCrudo = new Affettati("Prosciutto Crudo San Daniele",)...

void Identificativo(long codice, string nome)
{
    Console.WriteLine($"Codice identificativo: {codice}-{nome}");
}


foreach(Prodotto prodotto in laMiaListaDiProdotti)
{
        Console.WriteLine("----- Prodotto -------");
        Console.WriteLine("Codice: " + prodotto.codice);
        Console.WriteLine("Nome: " + prodotto.nome);
        Console.WriteLine("Descrizione: " + prodotto.descrizione);
        Console.WriteLine($"Prezzo: {prodotto.prezzo} euro");
        Console.WriteLine($"IVA: {prodotto.iva}%");
        Console.WriteLine($"Prezzo finale: {prodotto.PrezzoPiuIva(prodotto.prezzo, prodotto.iva)} euro");
        Console.WriteLine($"Codice esteso: {prodotto.PadLeft()}");
        Identificativo(prodotto.codice, prodotto.nome);
        Console.WriteLine("------------------");
}

