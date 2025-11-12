using System;
using System.Collections.Generic;

public abstract class Zboruri
{
    public int NrZbor { get; private set; }
    public DateTime DataZbor { get; private set; }
    public string Plecare { get; private set; }
    public string Destinatie { get; private set; }
    private int NumarDePersoaneLaBord { get; set; } = 0;
    private List<Rezervare> rezervari = new List<Rezervare>();

    public Zboruri(int nrZbor, DateTime dataZbor, string plecare, string destinatie)
    {
        NrZbor = nrZbor;
        DataZbor = dataZbor;
        Plecare = plecare;
        Destinatie = destinatie;
    }

    public abstract float CalculPret(Rezervare rezervare);

    public void AddRezervare(Rezervare rezervare)
    {
        if (Validare(rezervare))
        {
            rezervare.AddPret(CalculPret(rezervare));
            rezervari.Add(rezervare);
            AddNrPasageri(rezervare);
            Console.WriteLine($"Rezervarea s-a efectuat cu un preț de {CalculPret(rezervare)} Lei.");
        }
        else
        {
            Console.WriteLine("Rezervarea nu s-a putut efectua.");
        }
    }

    public void PrintRezervari()
    {
        if (rezervari.Count == 0)
        {
            Console.WriteLine("Nu sunt rezervări pentru acest zbor.");
            return;
        }

        foreach (var rezervare in rezervari)
        {
            Console.WriteLine($"Rezervare: {rezervare.Email} - {rezervare.NrPersoane} persoane, {rezervare.Pret} Lei.");
        }
    }

    private bool Validare(Rezervare rezervare)
    {
        // Validăm numărul de persoane
        return rezervare.NrPersoane > 0 && rezervare.NrPersoane < 7; // max 6 persoane
    }

    private void AddNrPasageri(Rezervare rezervare)
    {
        NumarDePersoaneLaBord += rezervare.NrPersoane;
    }
}
