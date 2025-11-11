using System;
using System.Collections.Generic;

class Program
{
    static List<Apartament> apartamente = new List<Apartament>
    {
        new Apartament("Strada Libertatii, nr. 12", 4, 100),
        new Apartament("Bulevardul Unirii, nr. 25", 2, 150),
        new Apartament("Calea Victoriei, nr. 37", 3, 200)
    };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMeniu:");
            Console.WriteLine("1. Adauga o rezervare");
            Console.WriteLine("2. Cauta rezervare dupa numele persoanei");
            Console.WriteLine("3. Listare toate rezervarile");
            Console.WriteLine("4. Iesire");
            Console.Write("Alege o optiune: ");

            string optiune = Console.ReadLine();

            if (optiune == "1")
            {
                AdaugaRezervare();
            }
            else if (optiune == "2")
            {
                CautaRezervare();
            }
            else if (optiune == "3")
            {
                ListareRezervari();
            }
            else if (optiune == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Optiune invalida.");
            }
        }
    }

    static void AdaugaRezervare()
    {
        Console.WriteLine("Alege un apartament:");
        for (int i = 0; i < apartamente.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {apartamente[i].Adresa},  Capacitate: {apartamente[i].Capacitate}  Pret/zi: {apartamente[i].PretPeZi}");
        }
        int apartamentIndex = int.Parse(Console.ReadLine()) - 1;
        if (apartamentIndex < 0 || apartamentIndex >= apartamente.Count)
        {
            Console.WriteLine("Optiune invalida.");
            return;
        }

        Apartament apartament = apartamente[apartamentIndex];

        
        Console.Write("Nume complet: ");
        string numeComplet = Console.ReadLine();
        Console.Write("Data inceput (yyyy-mm-dd): ");
        DateTime dataInceput = DateTime.Parse(Console.ReadLine());
        Console.Write("Durata (zile): ");
        int durata = int.Parse(Console.ReadLine());

        List<Persoana> persoane = new List<Persoana>();
        for (int i = 0; i < apartament.Capacitate; i++)
        {
            Console.Write(" Introduceti Nume persoana cazata: ");
            string numePersoana = Console.ReadLine();
            Console.Write("An nastere: ");
            int anNastere = int.Parse(Console.ReadLine());
            persoane.Add(new Persoana(numePersoana, anNastere));
        }

       
        Rezervare rezervare = new Rezervare(numeComplet, dataInceput, durata, persoane);
        apartament.Rezervari.Add(rezervare);

        Console.WriteLine($"Rezervarea a fost adaugata! Cost total: {rezervare.CalculeazaCost(apartament.PretPeZi)} lei.");
    }

    static void CautaRezervare()
    {
        
        Console.Write("Introduceti numele persoanei pentru cautare: ");
        string numeCautat = Console.ReadLine();

        bool gasit = false;
        foreach (var apartament in apartamente)
        {
            foreach (var rezervare in apartament.Rezervari)
            {
                if (rezervare.NumeComplet.Contains(numeCautat, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Rezervare pentru {rezervare.NumeComplet} la apartamentul {apartament.Adresa}.");
                    Console.WriteLine($"Data inceput: {rezervare.DataInceput.ToShortDateString()}, Durata: {rezervare.DurataZile} zile.");
                    gasit = true;
                }
            }
        }

        if (!gasit)
        {
            Console.WriteLine("Nu s-au gasit rezervari pentru aceasta persoana.");
        }
    }

    static void ListareRezervari()
    {
        
        foreach (var apartament in apartamente)
        {
            Console.WriteLine($"\nRezervari pentru apartamentul {apartament.Adresa}:");
            foreach (var rezervare in apartament.Rezervari)
            {
                Console.WriteLine($"- {rezervare.NumeComplet} - {rezervare.DataInceput.ToShortDateString()} - {rezervare.DurataZile} zile.");
            }
        }
    }
}
