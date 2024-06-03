using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public ScriptureReference Reference;
    private List<Word> Words;
    private Random random = new Random();

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberOfWords)
    {
        var indices = Enumerable.Range(0, Words.Count).ToList();
        for (int i = 0; i < numberOfWords; i++)
        {
            if (indices.Count == 0) break;
            int randomIndex = random.Next(indices.Count);
            Words[indices[randomIndex]].Hide();
            indices.RemoveAt(randomIndex);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.Hidden);
    }

    public override string ToString()
    {
        return $"{Reference}\n{string.Join(" ", Words)}";
    }
}
