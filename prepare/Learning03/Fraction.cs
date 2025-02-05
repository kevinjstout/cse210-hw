public class Fraction
{
    private int _numerator;

    private int _denominator;

    public Fraction()
    {
        _numerator = 1;

        _denominator = 1;
    }

    public Fraction(int n)
    {
        _numerator = n;

        _denominator = 1;
    }

    public Fraction(int n, int d)
    {
        _numerator = n;

        _denominator = d;
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int n)
    {
        _numerator = n;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int d)
    {
        _denominator = d;
    }

    public string GetFractionString()
    {
        string nString = _numerator.ToString();
        
        string dString = _denominator.ToString();
        
        return nString + "/" + dString;
    }

    public double GetDecimalValue()
    {
        double decimalVersion = _numerator / _denominator;

        return decimalVersion;
    }

}