using System;
using System.Collections.Generic;

public class Rezervare
{
    public string NumeComplet { get; set; }
    public DateTime DataInceput { get; set; }
    public int DurataZile { get; set; }
    public List<Persoana> Persoane { get; set; }

    public Rezervare(string numeComplet, DateTime dataInceput, int durataZile, List<Persoana> persoane)
    {
        NumeComplet = numeComplet;
        DataInceput = dataInceput;
        DurataZile = durataZile;
        Persoane = persoane;
    }

    public double CalculeazaCost(double pretPeZi)
    {
        return DurataZile * pretPeZi;
    }
}
