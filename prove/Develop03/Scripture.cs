using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; }
    public List<Word> Words { get; }

    public Scripture(Reference reference, List<Word> words)
    {
        Reference = reference;
        Words = words;
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> visibleWords = Words.FindAll(word => !word.IsHidden);

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
    }

    public string GetRenderedText()
    {
        string renderedText = $"{Reference.GetReferenceString()}: ";
        foreach (var word in Words)
        {
            renderedText += $"{word.GetRenderedText()} ";
        }
        return renderedText.Trim();
    }
}