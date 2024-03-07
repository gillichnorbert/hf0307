using System;
using Szuperhos;

public abstract class Bosszuallo : ISzuperhos
{
    private float szuperero;
    private bool vanEGyengesege;

    public Bosszuallo(float szuperero, bool vanEGyengesege)
    {
        this.szuperero = szuperero;
        this.vanEGyengesege = vanEGyengesege;
    }

    public abstract bool megmentiAVilagot();

    public float mekkoraAzEreje()
    {
        return szuperero;
    }

    public bool legyoziE(ISzuperhos ellenfel)
    {
        if (ellenfel is Bosszuallo)
        {
            Bosszuallo bosszualloEllenfel = (Bosszuallo)ellenfel;
            if (bosszualloEllenfel.vanEGyengesege && szuperero < bosszualloEllenfel.mekkoraAzEreje())
            {
                return true;
            }
            return false;
        }
        else if (ellenfel is Batman)
        {
            Batman batmanEllenfel = (Batman)ellenfel;
            if (szuperero < 2 * batmanEllenfel.mekkoraAzEreje())
            {
                return true;
            }
            return false;
        }
        return false;
    }

    int ISzuperhos.mekkoraAzEreje()
    {
        throw new NotImplementedException();
    }

    public float Szuperero;
}


