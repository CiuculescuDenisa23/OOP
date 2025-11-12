using POO___Grupa_2._1___Echipa_3;
using Newtonsoft.Json;
//tets
class Program
{
    static void Main(string[] args)
    {
        Cinema cinema = new Cinema();

        while (true)
        {
            Console.WriteLine("1. Autentificare\n2. Inregistrare\n3. Iesire");
            string optiune = Console.ReadLine();

            if (optiune == "1")
            {
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Parola: ");
                string parola = Console.ReadLine();

                var utilizatorAutentificat = cinema.AutentificaUtilizator(email, parola);
                if (utilizatorAutentificat == null)
                {
                    Console.WriteLine("Autentificare esuata!");
                    continue;
                }

                if (utilizatorAutentificat.IsAdmin)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Adauga Film\n2. Scoate Film\n3. Afiseaza Filme\n4. Afiseaza Clienti\n5. Iesire");
                        string adminOptiune = Console.ReadLine();

                        switch (adminOptiune)
                        {
                            case "1":
                                Console.Write("Nume film: ");
                                string numeFilm = Console.ReadLine();
                                Console.Write("Descriere: ");
                                string descriere = Console.ReadLine();
                                Console.Write("Data (yyyy-mm-dd): ");
                                DateTime data = DateTime.Parse(Console.ReadLine());
                                Console.Write("Sala: ");
                                int sala = int.Parse(Console.ReadLine());
                                Console.Write("Numar maxim locuri: ");
                                int nrMaxLocuri = int.Parse(Console.ReadLine());
                                int idFilm = cinema.Filme.Count + 1;
                                cinema.AdaugaFilm(new RulareFilm(idFilm, numeFilm, descriere, data, sala, nrMaxLocuri));
                                break;
                            case "2":
                                Console.Write("ID Film de scos: ");
                                int idFilmDeSters = int.Parse(Console.ReadLine());
                                cinema.ScoateFilm(idFilmDeSters);
                                break;
                            case "3":
                                foreach (var film in cinema.Filme.OfType<RulareFilm>())
                                {
                                    Console.WriteLine($"ID: {film.Id}, {film.NumeFilm} ({film.Data.ToShortDateString()})");
                                }
                                break;
                            case "4":
                                foreach (var client in cinema.Utilizatori)
                                {
                                    Console.WriteLine($"{client.Nume} {client.Prenume} ({client.Email})");
                                }
                                break;
                            case "5":
                                cinema.SalveazaDate();
                                return;
                            default:
                                Console.WriteLine("Optiune invalida!");
                                break;
                        }
                    }
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("1. Vezi filme disponibile\n2. Fa o rezervare\n3. Iesire");
                        string clientOptiune = Console.ReadLine();

                        switch (clientOptiune)
                        {
                            case "1":
                                foreach (var film in cinema.Filme.OfType<RulareFilm>())
                                {
                                    Console.WriteLine($"ID: {film.Id}, {film.NumeFilm} ({film.Data.ToShortDateString()})");
                                }
                                break;
                            case "2":
                                Console.Write("ID film: ");
                                int idFilmRezervare = int.Parse(Console.ReadLine());
                                Console.Write("Numar locuri: ");
                                int nrLocuri = int.Parse(Console.ReadLine());
                                bool succes = cinema.RealizeazaRezervare(idFilmRezervare, utilizatorAutentificat.Nume, nrLocuri);
                                Console.WriteLine(succes ? "Rezervare reusita!" : "Rezervare esuata!");
                                break;
                            case "3":
                                return;
                            default:
                                Console.WriteLine("Optiune invalida!");
                                break;
                        }
                    }
                }
            }
            else if (optiune == "2")
            {
                Console.Write("Nume: ");
                string nume = Console.ReadLine();
                Console.Write("Prenume: ");
                string prenume = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Parola: ");
                string parola = Console.ReadLine();
                Console.WriteLine("Esti admin? (da/nu): ");
                bool isAdmin = Console.ReadLine().ToLower() == "da";

                var utilizatorNou = new Utilizator(nume, prenume, email, parola, isAdmin);
                cinema.InregistreazaUtilizator(utilizatorNou);
                Console.WriteLine("Inregistrare reusita!");
            }
            else if (optiune == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Optiune invalida!");
            }
        }
    }
}
