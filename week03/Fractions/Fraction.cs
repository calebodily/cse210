public class Fraction
{
    private int _fractionTop;
    private int _fractionBottom;

    public Fraction()
    {
        _fractionTop = 1;
        _fractionBottom = 1;
    }

    public Fraction(int top)
    {
        _fractionTop = top;
        _fractionBottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _fractionTop = top;
        _fractionBottom = bottom;
    }

    public string GetToString()
    {
        return $"{_fractionTop}/{_fractionBottom}";
    }

    public double GetToDecimal()
    {
        return (double)_fractionTop / (double)_fractionBottom;
    }
}