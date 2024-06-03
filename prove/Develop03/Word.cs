public class Word
{
    private string Text;
    private bool IsHidden;

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public bool Hidden
    {
        get { return IsHidden;}
    }

    public override string ToString()
    {
        return IsHidden ? "____" : Text;
    }
}
