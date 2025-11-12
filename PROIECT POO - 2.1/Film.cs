using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace POO___Grupa_2._1___Echipa_3
{
    public abstract class Film
    {
        public string NumeFilm { get; set; }
        public string Descriere { get; set; }
        public List<RulareFilm> Rulari { get; set; } = new List<RulareFilm>();

        public Film(string numeFilm, string descriere)
        {
            NumeFilm = numeFilm;
            Descriere = descriere;
        }
    }
}
