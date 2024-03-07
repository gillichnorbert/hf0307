using System;
using Szuperhos;

public class Vasember : Bosszuallo, IMilliardos
{
    public Vasember() : base(150, true)
    {
    }

    public void kutyutKeszit()
    {
        Random rnd = new Random();
        float novekedes = (float)(rnd.NextDouble() * 10);
        Szuperero += novekedes;
        Console.WriteLine($"Vasember kütyüt készített! Szuperereje megnőtt {novekedes} ponttal.");
    }

    public override bool megmentiAVilagot()
    {
        if (Szuperero > 1000)
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"Vasember - {base.ToString()}";
    }
}

