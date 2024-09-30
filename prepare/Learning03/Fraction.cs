/*
Fraction : class
Purpose:
    Return fractions from given user input in 
    string and decimal format
*/

public class Fraction
{
    // MEMBER VARIABLES
    private int _top;
    private int _bottom;

    // CONSTRUCTORS
    // set default constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    // set whole number constructor (eg: 5/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    // set fraction constructor (eg: 2/5, eg: 7/4)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // METHODS
    private void SetTop(int top) // setter
    {
        _top = top;
    }
    public int GetTop() // getter, display value to console
    {
        return _top;
    }
    private void SetBottom(int bottom) // setter
    {
        _bottom = bottom;
    }
    public int GetBottom() // getter, display value to console
    {
        return _bottom;
    }
    public string GetFractionString() // returns fraction in 3/4 form
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue() // returns fraction in decimal form
    {
        double decimalValue = (double)_top / _bottom;
        return decimalValue;
    }
}