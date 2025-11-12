public class Rezervare
{
    public string Email { get; private set; }
    public int NrPersoane { get; private set; }
    public int NrBagaje { get; private set; }
    public float Pret { get; private set; }

    public Rezervare(string email, int nrPersoane, int nrBagaje)
    {
        Email = email;
        NrPersoane = nrPersoane;
        NrBagaje = nrBagaje;
    }

    public void AddPret(float pret)
    {
        Pret = pret;
    }
}
