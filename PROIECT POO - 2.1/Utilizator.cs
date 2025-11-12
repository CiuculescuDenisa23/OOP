using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace POO___Grupa_2._1___Echipa_3
{
    public class Utilizator
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; }
        public bool IsAdmin { get; set; }

        public Utilizator(string nume, string prenume, string email, string parola, bool isAdmin)
        {
            Nume = nume;
            Prenume = prenume;
            Email = email;
            Parola = parola;
            IsAdmin = isAdmin;
        }
    }

}
