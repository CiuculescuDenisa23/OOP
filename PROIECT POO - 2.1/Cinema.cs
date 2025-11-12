using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace POO___Grupa_2._1___Echipa_3
{
    public class Cinema
    {
        public List<Film> Filme { get; set; } = new List<Film>();
        public List<Sala> Sali { get; set; } = new List<Sala>();
        public List<Utilizator> Utilizatori { get; set; } = new List<Utilizator>();

        private const string FisierFilme = "filme.json";
        private const string FisierSali = "sali.json";
        private const string FisierUtilizatori = "utilizatori.json";

        public Cinema()
        {
            IncarcaDate();
        }

        public Utilizator AutentificaUtilizator(string email, string parola)
        {
            return Utilizatori.FirstOrDefault(u => u.Email == email && u.Parola == parola);
        }

        public void InregistreazaUtilizator(Utilizator utilizator)
        {
            Utilizatori.Add(utilizator);
            SalveazaDate();
        }

        public void AdaugaFilm(RulareFilm film)
        {
            Filme.Add(film);
        }

        public void ScoateFilm(int idFilm)
        {
            Filme.RemoveAll(f => f is RulareFilm && ((RulareFilm)f).Id == idFilm);
        }

        public bool RealizeazaRezervare(int idFilm, string numeClient, int numarLocuri)
        {
            var rulare = Filme.OfType<RulareFilm>().FirstOrDefault(f => ((RulareFilm)f).Id == idFilm);
            if (rulare != null && rulare.AreLocuriDisponibile(numarLocuri))
            {
                rulare.LocuriOcupate += numarLocuri;
                return true;
            }
            return false;
        }

        public void SalveazaDate()
        {
            File.WriteAllText(FisierFilme, JsonConvert.SerializeObject(Filme, Newtonsoft.Json.Formatting.Indented));
            File.WriteAllText(FisierSali, JsonConvert.SerializeObject(Sali, Newtonsoft.Json.Formatting.Indented));
            File.WriteAllText(FisierUtilizatori, JsonConvert.SerializeObject(Utilizatori, Newtonsoft.Json.Formatting.Indented));
        }

        public void IncarcaDate()
        {
            if (!File.Exists(FisierFilme))
                File.WriteAllText(FisierFilme, JsonConvert.SerializeObject(new List<RulareFilm>(), Newtonsoft.Json.Formatting.Indented));

            if (!File.Exists(FisierSali))
                File.WriteAllText(FisierSali, JsonConvert.SerializeObject(new List<Sala>(), Newtonsoft.Json.Formatting.Indented));

            if (!File.Exists(FisierUtilizatori))
                File.WriteAllText(FisierUtilizatori, JsonConvert.SerializeObject(new List<Utilizator>(), Newtonsoft.Json.Formatting.Indented));

            Filme = JsonConvert.DeserializeObject<List<RulareFilm>>(File.ReadAllText(FisierFilme))?.Cast<Film>().ToList() ?? new List<Film>();
            Sali = JsonConvert.DeserializeObject<List<Sala>>(File.ReadAllText(FisierSali)) ?? new List<Sala>();
            Utilizatori = JsonConvert.DeserializeObject<List<Utilizator>>(File.ReadAllText(FisierUtilizatori)) ?? new List<Utilizator>();
        }
    }
}
