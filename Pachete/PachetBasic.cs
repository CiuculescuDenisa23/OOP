

using System;

class PachetBasic : Pachet
{
    public PachetBasic(double greutate) : base(greutate) { }

    public override double Cost()
    {
        return 5 * Greutate;
    }

    public override int TimpLivrare()
    {
        // Extindem operatorul ternar într-un bloc if-else
        if (Greutate > 10)
        {
            return 6;  // Dacă greutatea este mai mare de 10 kg, returnează 6 zile.
        }
        else
        {
            return 5;  // Dacă greutatea este de 10 kg sau mai puțin, returnează 5 zile.
        }
    }
}
