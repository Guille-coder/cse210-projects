using System;

public class Word
{
    string _text;
    bool _isHidden;

    public Word (string text)
    {
        _text= text;
        _isHidden=false;

    }
    public void Hide()
    {
        _isHidden=true;

    }
    public void Show()
    {
        _isHidden=false;

    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            _text= new string('_', _text.Count());
        }
    return _text;
    }

}