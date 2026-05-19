using System;

class Fraction
{
    private int cmTop;
    private int cmBottom;

    public Fraction()
    {
        cmTop = 1;
        cmBottom = 1;
    }

    public Fraction(int cmNumerator)
    {
        cmTop = cmNumerator;
        cmBottom = 1;
    }

    public Fraction(int cmNumerator, int cmDenominator)
    {
        cmTop = cmNumerator;
        cmBottom = cmDenominator;
    }

    public int GetTop()
    {
        return cmTop;
    }
    public void SetTop(int cmUpper)
    {
        cmTop = cmUpper;
    }

    public int GetBottom()
    {
        return cmBottom;
    }
    public void SetBottom(int cmLower)
    {
        cmBottom = cmLower;
    }

    public string GetFractionString()
    {
        return cmTop + "/" + cmBottom;
    }
    public double GetDecimalValue()
    {
        return 1.0 * cmTop / cmBottom;
    }
}