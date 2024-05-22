public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom  = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    private int GetTop()
    {
        int numerator = _top;
        return numerator;
    }

    private int GetBottom()
    {
        int denominator = _bottom;
        return denominator;
    }

    public string GetFractionString()
    {
        int numerator;
        int denominator;
        string text;

        numerator = GetTop();
        denominator = GetBottom();

        text = $"{numerator}/{denominator}";
        return text;
    }

    public double GetDecimalValue()
    {
        double numerator;
        double denominator;

        numerator = GetTop();
        denominator = GetBottom();

        return numerator / denominator;
    }

}