using EnigpusCLI.Models;

namespace EnigpusCLI.Repositories.Impls;

public class BookRepository: IBookRepository
{
    private readonly List<Book> _books = new();

    public void Save(Book book)
    {
        try
        {
            book.Code = Guid.NewGuid();
            _books.Add(book);
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public void Update(Book book)
    {
        try
        {
            var existingBook = _books.FirstOrDefault(val => val.Code == book.Code);
            if (existingBook != null)
            {
                int index = _books.IndexOf(existingBook);
                _books[index] = book;
                return;
            }

            throw new Exception("Internal Server Error");
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public void Delete(Book book)
    {
        try
        {
            _books.Remove(book);
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public ICollection<Book> FindAll()
    {
        try
        {
            return _books;
        }
        catch (Exception e)
        {
            throw;
        }
    }
    
    public Book? FindById(Guid id)
    {
        try
        {
            var existingBook = _books.FirstOrDefault(val => val.Code == id);
            return existingBook;
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public ICollection<Book> FindByTitle(string title)
    {
        try
        {
            var existingBook = _books.Where(val => val.Title.ToLower().Contains(title.ToLower())).ToList();
            return existingBook;
        }
        catch (Exception e)
        {
            throw;
        }
    }
}