using System;
using System.Collections.Generic;
public class Word
{
    private string _text;
    private bool _isHidden;
    private string _hiddenText;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
        foreach(char letter in text)
        {
            _hiddenText += "_";
        }
    }

    public string GetText()
    {
        // TENARY OPERATOR
        // CONDITION ? True Expression : False Expression
        return _isHidden ? _hiddenText : _text;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

}
