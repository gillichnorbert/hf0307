using System;
using Szuperhos;

public class Batman : ISzuperhos, IMilliardos
{
    private float lelemenyesseg;

    public Batman()
    {
        lelemenyesseg = 100;
    }

    public bool legyoziE(ISzuperhos ellenfel)
    {
        if (ellenfel.mekkoraAzEreje() < lelemenyesseg * 2)
        {
            return true;
        }
        return false;
    }

    public int mekkoraAzEreje()
    {
        return (int)(lelemenyesseg * 2);
    }

    public void kutyutKeszit()
    {
        lelemenyesseg += 50;
        Console.WriteLine("Batman kütyüt készített! A leleményessége nőtt.");
    }

    public float Lelemenyesseg
    {
        get { return lelemenyesseg; }
        set { lelemenyesseg = value; }
    }

    public override string ToString()
    {
        return $"Batman - Leleményesség: {lelemenyesseg}";
    }
}
