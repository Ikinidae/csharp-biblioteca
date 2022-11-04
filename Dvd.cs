//Si vuole progettare un sistema per la gestione di una biblioteca dove il bibliotecario può verificare i dati dei clienti registrati
//cognome,
//nome,
//email,
//recapito telefonico,

//Il bibliotecario può effettuare dei prestiti ai suoi clienti registrati, attraverso il sistema, sui documenti che sono di vario tipo (libri, DVD).
//I documenti sono caratterizzati da:
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

//Il bibliotecario deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo
//(Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un cliente.

//creo biblioteca
//sottoclasse dvd
public class Dvd : Documento
{
    //properties
    public string Codice { get; set; }
    public int Durata { get; set; }

    //costruttore
    public Dvd(string titolo, int anno, string settore, bool stato, int scaffale, string autore, string codice, int durata) : base(titolo, anno, settore, stato, scaffale, autore)
    {
        Codice = codice;
        Durata = durata;
    }
}
