

using System;

class PachetAvansat : Pachet
{
    public PachetAvansat(double greutate) : base(greutate) { }

    public override double Cost()
    {
        return (6 * Greutate) + 2;
    }

    public override int TimpLivrare()
    {
        return 2;
    }
}
