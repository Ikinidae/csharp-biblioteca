//Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:
//cognome,
//nome,
//email,
//recapito telefonico,

//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.



//classe utente
public class Utente
{
    //properties
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefono { get; set; }

    //costruttore
    public Utente(string cognome, string nome, string email, int telefono)
    {
        Cognome = cognome;
        Nome = nome;
        Email = email;
        Telefono = telefono;
    }
}


//superclasse documento
public class Documento
{
    //properties
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public bool Stato { get; set; }
    public int Scaffale { get; set; }
    public string Autore { get; set; }

    //costruttore
    public Documento(string titolo, int anno, string settore, bool stato, int scaffale, string autore)
    {
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        Stato = stato;
        Scaffale = scaffale;
        Autore = autore;
    }
}

//sottoclasse libro
public class Libro : Documento
{
    //properties
    public string Isbn { get; set; }
    public int Pagine { get; set; }

    //costruttore
    public Libro(string titolo, int anno, string settore, bool stato, int scaffale, string autore, string isbn, int pagine) : base(titolo, anno, settore, stato, scaffale, autore)
    {
        Isbn = isbn;
        Pagine = pagine;
    }
}


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


//classe biblioteca
public class Biblioteca
{
    //costruttore
    public Biblioteca()
    {
        List<Utente> utenti = new List<Utente>();
    }
}