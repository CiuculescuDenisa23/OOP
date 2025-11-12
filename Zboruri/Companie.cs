using System;
using System.Collections.Generic;

public class Companie
{
    private string Nume { get; set; }
    private List<Zboruri> zboruri = new List<Zboruri>();

    public Companie(string nume)
    {
        Nume = nume;
    }

    public void AddZbor(Zboruri zbor)
    {
        zboruri.Add(zbor);
    }

    public void PrintZboruri()
    {
        Console.WriteLine($"Compania: {Nume}");

        foreach (var zbor in zboruri)
        {
            Console.WriteLine($"Zborul {zbor.NrZbor} către {zbor.Destinatie} - Data: {zbor.DataZbor.ToShortDateString()}");
            zbor.PrintRezervari();
        }
    }
}
