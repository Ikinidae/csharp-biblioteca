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
Biblioteca biblioteca = new Biblioteca();
biblioteca.Prestito();



//classe biblioteca
public class Biblioteca
{
    //properties
    public List<Utente> Utenti { get; }
    public List<Libro> Libri { get; }
    public List<Dvd> Dvd { get; }

    //costruttore
    public Biblioteca()
    {
        Utenti = new List<Utente>();
        Utenti.Add(new Utente("Rossi", "Paolo", "paolorossi@gmail.com", 334303045));
        Utenti.Add(new Utente("Arrigoni", "Luca", "lucaarrigoni@gmail.com", 334364045));
        Utenti.Add(new Utente("Elia", "Federica", "federicaelia@gmail.com", 331324045));

        Libri = new List<Libro>();
        Libri.Add(new Libro("La solitudine dei numeri primi", 2008, "Romanzo", true, new Random().Next(0, 101), "Paolo Giordano", "9788804577027", 304));
        Libri.Add(new Libro("L'isola della paura", 2013, "Thriller psicologico", false, new Random().Next(0, 101), "Dennis Lehane", "9788868366216", 436));
        Libri.Add(new Libro("Il silenzio degli innocenti", 1988, "Thriller psicologico", true, new Random().Next(0, 101), "Thomas Harris", "9788804333746", 388));

        Dvd = new List<Dvd>();
        Dvd.Add(new Dvd("Avatar", 2008, "Fantascienza", true, new Random().Next(0, 101), "Paolo Giordano", "9788804577027", 304));
        Dvd.Add(new Dvd("Shutter Island", 2013, "Thriller psicologico", false, new Random().Next(0, 101), "Dennis Lehane", "9788868366216", 436));
        Dvd.Add(new Dvd("Il miglio verde", 1988, "Thriller psicologico", true, new Random().Next(0, 101), "Thomas Harris", "9788804333746", 388));

    }


    public void Prestito()
    {
        Console.WriteLine("Vuoi cercare un libro o un dvd? [libro/dvd] ");
        string userInput = Console.ReadLine();

        if (userInput == "libro")
        {
            Console.WriteLine("Scrivi il codice o il titolo del libro da cercare: ");
            string userInputLibro = Console.ReadLine();

            foreach (Libro libro in Libri)
            {
                if (userInputLibro == libro.Titolo || userInputLibro == libro.Isbn)
                {
                    if (libro.Stato == true)
                    {
                        Console.WriteLine("il libro ricercato è disponibile");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("il libro non è disponibile");
                    }
                }
            }
            
        }
        else if (userInput == "dvd")
        {
            Console.WriteLine("Scrivi il codice o il titolo del dvd da cercare: ");
            string userInputDvd = Console.ReadLine();

            foreach (Dvd dvd in Dvd)
            {
                if (userInputDvd == dvd.Titolo || userInputDvd == dvd.Codice)
                {
                    if (dvd.Stato == true)
                    {
                        Console.WriteLine("il dvd ricercato è disponibile");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("il dvd ricercato non è disponibile");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("inserisci un valore corretto");
            Prestito();
        }
    }
}
