public class ZborTransatlantic : Zboruri
{
    public ZborTransatlantic(int nrZbor, DateTime dataZbor, string plecare, string destinatie)
        : base(nrZbor, dataZbor, plecare, destinatie)
    { }

    public override float CalculPret(Rezervare rezervare)
    {
        return rezervare.NrPersoane * 500 + rezervare.NrBagaje * 50 + 100;
    }
}
