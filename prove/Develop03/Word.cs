using System;

public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;

    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        //Console.WriteLine("BBB");
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (IsHidden())
        {
            return "";
        }

        else
        {
            return _text;
        }
    
    }
}