using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace POO___Grupa_2._1___Echipa_3
{
    public class Rezervare
    {
        public string Nume;
        public TimeSpan Oraincepere;
        public TimeSpan Orafinala;
        public int Sala;
        public int Numarlocurirezervare;
        public Rezervare(string nume, TimeSpan oraincepere, TimeSpan orafinala, int sala, int numarlocurirezervare)
        {
            Nume = nume;
            Oraincepere = oraincepere;
            Orafinala = orafinala;
            Sala = sala;
            Numarlocurirezervare = numarlocurirezervare;
        }
    }


}
