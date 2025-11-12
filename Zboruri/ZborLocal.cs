public class ZborLocal : Zboruri
{
    public ZborLocal(int nrZbor, DateTime dataZbor, string plecare, string destinatie)
        : base(nrZbor, dataZbor, plecare, destinatie)
    { }

    public override float CalculPret(Rezervare rezervare)
    {
        return rezervare.NrPersoane * 100 + rezervare.NrBagaje * 25;
    }
}
