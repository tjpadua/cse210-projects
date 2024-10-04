using System;

public class Word
{
    private string _text;
    private bool _isHididden;

    public Word(string _text)
    {
        _text = "";

    }

    public void Hide()
    {
        Console.WriteLine("AAA");
    }

    public void Show()
    {
        Console.WriteLine("BBB");
    }

    public void IsHididden()
    {

    }

    public void GetDisplayText()
    {
        Console.WriteLine("");
    }
}