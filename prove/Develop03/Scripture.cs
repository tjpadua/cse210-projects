using System;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _text = text;
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word>_words = new List<Word>(numberToHide);
    }

    public string GetDisplayText()
    {
        //Console.WriteLine("");
        return "This is the Verse.";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }

}
