using System;
using System.Collections.Generic;


public class Scripture
{
    private Reference _reference;
    private List<Word>_words = new List<Word>();
    public Scripture(Reference reference)
    {
        _reference = reference;

        string[] allwords  = text.Split(' ');
        foreach (string wordText in allwords)
        {
            Word newWord = new Word(wordText);
            _words.Add(newWord);

        }
    public void HideRandomWords(int numbertohide)
        {
            Random randonGenerator = new Random();
            int wordsHiddenThisTurn = 0;

            while (wordsHiddenThisTurn < numbertohide && !IsCompletelyHidden())
                {
                int randomIndex = randomGenerator.Next(_words.Count);
                if (!_words[randomIndex].IsHidden())
                {
                    _words[randomIndex].Hide();
                    wordsHiddenThisTurn++;
                }
            }
        }
    public string GetDisplayText()
    {
        string textToShow = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            textToShow += word.GetDisplayText() + " ";
        }

        return textToShow.Trim();

    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden ())
            {return false;}
        }
        return true;
    }

    }

}