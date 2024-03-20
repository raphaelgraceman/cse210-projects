using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top;
    private int _bottom;

    //Calling the special constructor
    public Fraction()
    {
        // constructor with no parameter and initializes the no. to 1/1
        _top = 1;
        _bottom = 1;
    }

    //Special constructor with one parameter call wholeNumber
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //A constructor with 2 parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Create Getters
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}