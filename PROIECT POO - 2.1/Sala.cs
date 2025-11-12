using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace POO___Grupa_2._1___Echipa_3
{
    public class Sala
    {
        public int Id { get; set; }
        public int Capacitate { get; set; }

        public Sala(int id, int capacitate)
        {
            Id = id;
            Capacitate = capacitate;
        }
    }

}
