using AlimentariShop;

Proprietario nuovoProprietario = new Proprietario("Davide", "Petrillo", "PTRDVD96P05A509T", 12345678912, "abcdefgh");

List<Prodotto> laMiaListaDiProdotti = new List<Prodotto>();
List<Cliente> listaClienti = new List<Cliente>();

foreach(Prodotto prodotto in laMiaListaDiProdotti)
{
    Random random = new Random();
    long codice = random.Next(10000);
}

Prodotto Cereali = new Prodotto("Cereali", "Cereali Kellog's a base di miele e cannella ", 1.99, 8, "cereali", 45);
laMiaListaDiProdotti.Add(Cereali);
Frutta Banana = new Frutta("Banana", "Banane coltivate in Brasile e prodotte in Guatemala", 2, 1.69, 22, "frutta", 50);
laMiaListaDiProdotti.Add(Banana);
Acqua Lete = new Acqua("Lete", "L’acqua che il tuo corpo vuole", 2.19, 18,"acqua", 6, 2, "plastica", 6.30, "Appennino meridionale",60);
laMiaListaDiProdotti.Add(Lete);
CiboInScatola Tonno = new CiboInScatola("Tonno", "Nostromo - Tonno Leggero all'Olio di Oliva con -60% di Grassi, Qualità Pinne Gialle, Senza Conservanti", 6, 60, 2.99, 22, "cibo in scatola", "12/09/2023",40);
laMiaListaDiProdotti.Add(Tonno);


void Identificativo(long codice, string nome)
{
    Console.WriteLine($"Codice identificativo: {codice}-{nome}");
}



Console.Write("Benvenuto. Lei è il proprietario oppure un cliente ?");
Console.WriteLine(" --- [Digitare 1 per Proprietario - 2 per Cliente]");
int sceltaIniziale = int.Parse(Console.ReadLine());


if (sceltaIniziale == 1)
{
    Console.Write("La preghiamo di inserire la sua password per confermare l'identità: ");

    string pswrdProp = Console.ReadLine();

    if (pswrdProp != nuovoProprietario.Password)
    {
        Console.WriteLine("Mi dispiace ma la password non è corretta: Accesso Negato");
    }
    else if (pswrdProp == nuovoProprietario.Password)
    {
        ListinoProdotti();

        Console.WriteLine();
        Console.Write("Desidera rifornire uno dei seguenti prodotti [Si/No] ?  ");
        string sceltaRifornimento = Console.ReadLine();

        if (sceltaRifornimento == "Si")
        {
            Console.Write("Digitare il nome del prodotto da rifornire: ");
            string sceltaProdottoRifornimento = Console.ReadLine();

            bool sceltaProdottoTrovata = false;

            for(int i = 0; i < laMiaListaDiProdotti.Count; i++)
            {
                if (laMiaListaDiProdotti[i].nome == sceltaProdottoRifornimento)
                {

                    Console.Write("Inserire la quantità da rifornire :");
                    int quantitaRifornimento = int.Parse(Console.ReadLine());
                    laMiaListaDiProdotti[i].Rifornimento(quantitaRifornimento);
                    sceltaProdottoTrovata = true;

                    Console.WriteLine();
                    ListinoProdotti();
                } 

            }
            if (!sceltaProdottoTrovata)
            {
                Console.WriteLine("Mi dispiace ma il prodotto non è presente a magazzino");
            }
            
        }
        else if (sceltaRifornimento == "No")
        {
            Console.WriteLine("Grazie. Arrivederci");
        } else
        {
            Console.WriteLine("Ci dispiace ma non siamo riusciti ad interpretare la vostra richiesta");
        }

    }
}

else if (sceltaIniziale == 2)
{
    Console.WriteLine();
    Console.WriteLine("La preghiamo di inserire i suoi dati: ");
    Console.WriteLine();
    Console.Write("Inserisci il tuo nome: ");
    string nomeNuovoCliente = Console.ReadLine();
    Console.Write("Inserisci il tuo cognome: ");
    string cognomeNuovoCliente = Console.ReadLine();
    Console.Write("Inserisci il tuo codice fiscale: ");
    string codiceFiscaleNuovoCliente = Console.ReadLine();
    Console.Write("Scelga un metodo di pagamento: ");
    Console.WriteLine(" --- [Digitare 1 per Cash - 2 per Carta]");
    int sceltaInizialeCliente = int.Parse(Console.ReadLine());

    string metodoPagamentoNuovoCliente;

    string sceltaMetodoDiPagamento()
    {
        if (sceltaInizialeCliente == 1)
        {
            metodoPagamentoNuovoCliente = "Cash";

        }
        else if (sceltaInizialeCliente == 2)
        {
            metodoPagamentoNuovoCliente = "Carta";
        }
        return metodoPagamentoNuovoCliente;
    }

    Cliente nuovoCliente = new Cliente(nomeNuovoCliente, cognomeNuovoCliente, codiceFiscaleNuovoCliente);

    listaClienti.Add(nuovoCliente);
    DescrizioneCliente();
    Console.WriteLine();
    ListinoProdotti();

    Console.Write("Desideri acquistare uno dei nostri prodotti [Si/No] ? ");
    string sceltaCliente = Console.ReadLine();


    if(sceltaCliente == "Si")
    {
        Console.Write("Digitare il nome del prodotto da acquistare: ");
        string sceltaProdottoDaAcquistare = Console.ReadLine();

        bool sceltaProdottoTrovata = false;

        for (int i = 0; i < laMiaListaDiProdotti.Count; i++)
        {
            if (laMiaListaDiProdotti[i].nome == sceltaProdottoDaAcquistare)
            {

                Console.Write("Inserire la quantità che si desidera acquistare :");
                int quantitaAcquisto = int.Parse(Console.ReadLine());
                laMiaListaDiProdotti[i].Acquisto(quantitaAcquisto);
                sceltaProdottoTrovata = true;
                double prezzoPerIlCliente = laMiaListaDiProdotti[i].PrezzoPiuIva(laMiaListaDiProdotti[i].prezzo, laMiaListaDiProdotti[i].iva);
                double prezzoPerIlClienteFinale = prezzoPerIlCliente * quantitaAcquisto;

                Console.WriteLine();

                Console.WriteLine($"Il prezzo per acquistare il prodotto è di : {prezzoPerIlClienteFinale} euro");
                Console.Write("Desidera confermare l'acquisto [Si/No] ? ");
                string confermaAcquistoCliente = Console.ReadLine();

                if(confermaAcquistoCliente == "Si")
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------------- Fattura fiscale --------------------");
                    Console.WriteLine();
                    Console.WriteLine("Nome: " + nomeNuovoCliente);
                    Console.WriteLine("Cognome: " + cognomeNuovoCliente);
                    Console.WriteLine("Codice Fiscale: " + codiceFiscaleNuovoCliente);
                    Console.WriteLine();
                    Console.WriteLine("------------------------ Prodotto -----------------------");
                    Console.WriteLine("Codice: " + laMiaListaDiProdotti[i].codice);
                    Console.WriteLine("Nome: " + laMiaListaDiProdotti[i].nome);
                    Console.WriteLine($"Prezzo: {laMiaListaDiProdotti[i].prezzo} euro");
                    Console.WriteLine($"IVA: {laMiaListaDiProdotti[i].iva}%");
                    Console.WriteLine($"Prezzo finale: {laMiaListaDiProdotti[i].PrezzoPiuIva(laMiaListaDiProdotti[i].prezzo, laMiaListaDiProdotti[i].iva)} euro");
                    Console.WriteLine($"Codice esteso: {laMiaListaDiProdotti[i].PadLeft()}");
                    Identificativo(laMiaListaDiProdotti[i].codice, laMiaListaDiProdotti[i].nome);
                    Console.WriteLine("PREZZO : " + prezzoPerIlClienteFinale + "euro");
                }
            }

        }
        if (!sceltaProdottoTrovata)
        {
            Console.WriteLine("Mi dispiace ma il prodotto non è presente nel negozio");
        }
    } else if(sceltaCliente == "No")
    {
        Console.WriteLine("Grazie per il tuo tempo. Arrivederci");
    } else
    {
        Console.WriteLine("Ci dispiace ma non siamo riusciti ad interpretare la vostra richiesta");
    }
}























    void DescrizioneCliente()
    {
        Console.WriteLine();
        Console.WriteLine("----- I tuoi dati -------");
        Console.WriteLine();

        foreach (Cliente cliente in listaClienti)
        {
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("Cognome: " + cliente.Cognome);
            Console.WriteLine("Codice Fiscale: " + cliente.CodiceFiscale);
            Console.WriteLine();
        }
    }



    void ListinoProdotti()
    {

        Console.WriteLine();
        Console.WriteLine("-------------------- Prodotti disponibili --------------------");
        Console.WriteLine();
        Console.WriteLine();

        foreach (Prodotto prodotto in laMiaListaDiProdotti)
        {
            Console.WriteLine("----- Prodotto -------");
            Console.WriteLine("Codice: " + prodotto.codice);
            Console.WriteLine("Nome: " + prodotto.nome);
            Console.WriteLine("Descrizione: " + prodotto.descrizione);

            if (prodotto.Type == "cibo in scatola")
            {
                Console.WriteLine($"Numero scatole: {Tonno.numeroScatole}");
                Console.WriteLine($"Peso: {Tonno.peso}gr/scatola");
                Console.WriteLine($"Scadenza: {Tonno.scadenza}");
                Console.WriteLine($"Quantità disponibile a magazzino: {Tonno.QuantitaAMagazzino} scatolette");
            }
            if (prodotto.Type == "frutta")
            {
                Console.WriteLine($"Peso: {Banana.Peso}kg/p.");
                Console.WriteLine($"Quantità disponibile a magazzino: {Banana.QuantitaAMagazzino} kg");
            }
            if (prodotto.Type == "acqua")
            {
                Console.WriteLine($"Numero bottiglie: {Lete.numeroBottiglie}/confezione");
                Console.WriteLine($"Litri: {Lete.litri}/bottiglia");
                Console.WriteLine($"Quantità disponibile a magazzino: {Lete.QuantitaAMagazzino / 6} casse");
                Console.WriteLine($"Materiale bottiglie: {Lete.materialeBottiglie}");
            }

            Console.WriteLine($"Prezzo: {prodotto.prezzo} euro");
            Console.WriteLine($"IVA: {prodotto.iva}%");
            Console.WriteLine($"Prezzo finale: {prodotto.PrezzoPiuIva(prodotto.prezzo, prodotto.iva)} euro");
            Console.WriteLine($"Codice esteso: {prodotto.PadLeft()}");
            Console.WriteLine($"Categoria, {prodotto.Type}");
            Identificativo(prodotto.codice, prodotto.nome);
            Console.WriteLine("------------------");
        }

    }
