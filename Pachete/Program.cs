
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      
        List<Pachet> listaPachete = new List<Pachet>
        {
            new PachetBasic(8),
            new PachetAvansat(5),
            new PachetPesteNoapte(3),
            new PachetBasic(12),
            new PachetAvansat(15)
        };

      
        foreach (Pachet pachet in listaPachete)
        {
            Console.WriteLine(pachet);
        }
    }
}
