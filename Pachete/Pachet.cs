
using System;

abstract class Pachet
{
    public double Greutate { get; set; }

    public Pachet(double greutate)
    {
        Greutate = greutate;
    }

   
    public abstract double Cost();

 
    public abstract int TimpLivrare();

    public override string ToString()
    {
        return $"Pachet cu greutatea: {Greutate} kg, Cost: {Cost()} EUR, Timp de livrare: {TimpLivrare()} zile.";
    }
}
