

public class Aprozar
{
    private string Nume;
    private string Adresa;
    List<Produs> produse = new List<Produs>();
    public Aprozar(string nume, string adresa)
    {
        Nume = nume;
        Adresa = adresa;

    }

    public void AddProdus(Produs produs)
    {
        if (produs.ValidareCantitate())
        {
            produse.Add(produs);
        }
    }
    public void Afisare()
    {
        foreach (var prod in produse)
        {
            prod.AfisareProduse();

        }
    }
    public void AfiseazaProduseCuStocZero()
    {
        foreach (var prod in produse)
        {
            if (prod is ProdusLaBucata buc && buc.Getstoc() == 0)
            {
                prod.AfisareProduse();
            }
        }

    }

}