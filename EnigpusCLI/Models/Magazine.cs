namespace EnigpusCLI.Models;

public class Magazine: Book
{
    public Magazine()
    {
    }

    public Magazine(Guid code, string title, string publisher, int publishedYear) : base(code, title, publisher, publishedYear)
    {
    }

    public override string GetTitle()
    {
        return base.Title;
    }
}