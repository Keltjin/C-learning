public class ScriptureReference
{
    private string Book;
    private int Chapter;
    private int StartVerse;
    private int? EndVerse;

    // Constructor for a single verse
    public ScriptureReference(string book, int chapter, int startVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = null;
    }

    // Constructor for a verse range
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (EndVerse.HasValue)
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        else
            return $"{Book} {Chapter}:{StartVerse}";
    }
}
