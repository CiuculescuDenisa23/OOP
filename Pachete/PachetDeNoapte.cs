
using System;

class PachetPesteNoapte : Pachet
{
    public PachetPesteNoapte(double greutate) : base(greutate) { }

    public override double Cost()
    {
        return 10 * Greutate;
    }

    public override int TimpLivrare()
    {
        return 1;
    }
}
