namespace EnigpusCLI.Models;

public class Novel: Book
{
    public string Author { get; set; }
    
    public Novel()
    {
    }

    public Novel(Guid code, string title, string publisher, int publishedYear, string author) : base(code, title, publisher, publishedYear)
    {
        Author = author;
    }

    public override string GetTitle()
    {
        return base.Title;
    }

    public override string ToString()
    {
        return $"{
            nameof(base.Code)}: {base.Code}, " +
               $"{nameof(base.Title)}: {base.Title}, " +
               $"{nameof(Author)}: {Author}, " +
               $"{nameof(base.Publisher)}: {base.Publisher}, " +
               $"{nameof(base.PublishedYear)}: {base.PublishedYear}";
    }
}