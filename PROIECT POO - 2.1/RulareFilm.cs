using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace POO___Grupa_2._1___Echipa_3
{
    public class RulareFilm : Film
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Sala { get; set; }
        public int NumarMaximLocuri { get; set; }
        public int LocuriOcupate { get; set; }

        public RulareFilm(int id, string numeFilm, string descriere, DateTime data, int sala, int numarMaximLocuri)
            : base(numeFilm, descriere)
        {
            Id = id;
            Data = data;
            Sala = sala;
            NumarMaximLocuri = numarMaximLocuri;
            LocuriOcupate = 0;
        }

        public bool AreLocuriDisponibile(int numarLocuri)
        {
            return LocuriOcupate + numarLocuri <= NumarMaximLocuri;
        }
    }

}
