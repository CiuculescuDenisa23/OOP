public class Apartament
{
    public string Adresa { get; set; }
    public int Capacitate { get; set; }
    public double PretPeZi { get; set; }
    public List<Rezervare> Rezervari { get; set; } = new List<Rezervare>();

    public Apartament(string adresa, int capacitate, double pretPeZi)
    {
        Adresa = adresa;
        Capacitate = capacitate;
        PretPeZi = pretPeZi;
    }
}
