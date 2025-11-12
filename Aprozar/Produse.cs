public abstract class Produs
{
    private string Nume;
    public float Cantitate;
    private float Pretunitar;
    public Produs(string nume, float cantitate, float pretunitar)
    {
        Nume = nume;
       //if (ValidareCantitate())
      // {
            Cantitate = cantitate;
       // }
        Pretunitar = pretunitar;
    }
    public abstract bool ValidareCantitate();
    public void AfisareProduse()
    {
        Console.WriteLine($"{Nume},{Cantitate},{Pretunitar}");
    }

}
public class ProdusLaBucata:Produs
{
    private int Stoc;
    public ProdusLaBucata(string nume, float cantitate, float pretunitar,int stoc):base(nume,cantitate,pretunitar)
    {
        Stoc = stoc;

    }
    public override bool ValidareCantitate( )
    {
        if(Cantitate > 0 && Cantitate<1000)
        {
            return true;
        }
        return false;
    }
    public int Getstoc()
    {
        return Stoc;

    }
}

public class ProdusLaKg: Produs
{
    private string Unitatemasura;
    public ProdusLaKg(string nume, float cantitate, float pretunitar, string unitatemasura) : base(nume, cantitate, pretunitar)
    { 
        Unitatemasura = unitatemasura;
    }
    public override bool ValidareCantitate( )
    {
        if (Cantitate > 0 && Cantitate < 100)
        {
            return true;
        }
        return false;
    }
}