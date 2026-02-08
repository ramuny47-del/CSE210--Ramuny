using System.ComponentModel.DataAnnotations;

class Reference
{
    private string _book;
    private int _chapter_number;
    private int _start_verse_number;
    private int _end_verse_number;

    public Reference(string book, int chapter, int start_verse, int end_verse)
    {
        _book = book;
        _chapter_number = chapter;
        _start_verse_number = start_verse;
        _end_verse_number = end_verse;
    }

    public string display()
    { string display_;
        if (!(_end_verse_number == 0))
        {
            display_ = _book + " " + _chapter_number +":"+ _start_verse_number +"-"+_end_verse_number;

    }
        else
        {
            display_ = _book + " " + _chapter_number +":"+ _start_verse_number;

        }
        return display_;
        }
       

}