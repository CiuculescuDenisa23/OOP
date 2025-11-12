using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creăm compania
        Companie companie = new Companie("WizzAir");

        // Creăm zboruri
        Zboruri zborLocal = new ZborLocal(101, new DateTime(2024, 5, 20), "București", "Cluj");
        Zboruri zborTransatlantic = new ZborTransatlantic(202, new DateTime(2024, 6, 15), "București", "New York");

        // Creăm rezervări
        Rezervare rezervare1 = new Rezervare("client1@gmail.com", 4, 3);
        Rezervare rezervare2 = new Rezervare("client2@gmail.com", 5, 2);
        Rezervare rezervare3 = new Rezervare("client3@gmail.com", 6, 4);

        // Adăugăm rezervări la zboruri
        zborLocal.AddRezervare(rezervare1);
        zborLocal.AddRezervare(rezervare2);
        zborTransatlantic.AddRezervare(rezervare3);

        // Adăugăm zboruri la companie
        companie.AddZbor(zborLocal);
        companie.AddZbor(zborTransatlantic);

        // Afișăm toate zborurile și rezervările
        companie.PrintZboruri();
    }
}
