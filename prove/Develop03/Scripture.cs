using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _cmReference;
    private List<Word> _cmWords;
    private static Random cmRandom = new Random();

    public Scripture(Reference reference, string text)
    {
        _cmReference = reference;
        _cmWords = new List<Word>();

        string[] cmSplitWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string cmWord in cmSplitWords)
        {
            _cmWords.Add(new Word(cmWord));
        }
    }

    public string GetDisplayText()
    {
        string cmText = _cmReference.GetDisplayText() + "\n\n";

        foreach (Word cmWord in _cmWords)
        {
            cmText += cmWord.GetDisplayText() + " ";
        }

        return cmText.Trim();
    }

    // NEW: guess-based hiding
    public bool TryHideWord(string guess)
    {
        foreach (Word cmWord in _cmWords)
        {
            if (!cmWord.IsHidden() &&
                cmWord.GetText().Equals(guess, StringComparison.OrdinalIgnoreCase))
            {
                cmWord.Hide();
                return true;
            }
        }

        return false;
    }

    // optional extra challenge rule (auto-hides 1 extra word)
    public void HideRandomWords(int count)
    {
        List<Word> cmVisibleWords = new List<Word>();

        foreach (Word cmWord in _cmWords)
        {
            if (!cmWord.IsHidden())
            {
                cmVisibleWords.Add(cmWord);
            }
        }

        for (int i = 0; i < count && cmVisibleWords.Count > 0; i++)
        {
            int cmIndex = cmRandom.Next(cmVisibleWords.Count);
            cmVisibleWords[cmIndex].Hide();
            cmVisibleWords.RemoveAt(cmIndex);
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word cmWord in _cmWords)
        {
            if (!cmWord.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}