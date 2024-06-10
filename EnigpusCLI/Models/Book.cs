namespace EnigpusCLI.Models;

public abstract class Book
{
    public Guid Code { get; set; }
    public string Title { get; set; }
    public string Publisher { get; set; }
    public int PublishedYear { get; set; }

    protected Book()
    {
    }

    protected Book(Guid code, string title, string publisher, int publishedYear)
    {
        Code = code;
        Title = title;
        Publisher = publisher;
        PublishedYear = publishedYear;
    }

    public abstract string GetTitle();
}