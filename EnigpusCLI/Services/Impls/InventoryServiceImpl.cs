using EnigpusCLI.Models;
using EnigpusCLI.Repositories;
using Exception = System.Exception;

namespace EnigpusCLI.Services.Impls;

public class InventoryServiceImpl: IInventoryService
{
    private readonly IBookRepository _bookRepository; 

    public InventoryServiceImpl(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public Book AddBook(Book book)
    {
        try
        {
            _bookRepository.Save(book);
            return book;
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public Book UpdateBook(Book book)
    {
        try
        {
            switch (book)
            {
                case Novel novel:
                {
                    var existingBook = (Novel) GetById(novel.Code.ToString());
                    
                    existingBook.Title = novel.Title != "" ? novel.Title : existingBook.Title;
                    existingBook.Publisher = novel.Publisher != "" ? novel.Publisher : existingBook.Publisher;
                    existingBook.PublishedYear = novel.PublishedYear != 0 ? novel.PublishedYear : existingBook.PublishedYear;
                    existingBook.Author = novel.Author != "" ? novel.Author : existingBook.Author;

                    _bookRepository.Update(existingBook);
                    return existingBook;
                }
                case Magazine:
                {
                    var existingBook = GetById(book.Code.ToString());
                    existingBook.Title = book.Title != "" ? book.Title : existingBook.Title;
                    existingBook.Publisher = book.Publisher != "" ? book.Publisher : existingBook.Publisher;
                    existingBook.PublishedYear = book.PublishedYear != 0 ? book.PublishedYear : existingBook.PublishedYear;
                
                    _bookRepository.Update(existingBook);
                    return existingBook;
                }
                default:
                    throw new Exception("Book type is not valid!");
            }
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public void Delete(string id)
    {
        try
        {
            var existingBook = GetById(id);
            _bookRepository.Delete(existingBook);
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public ICollection<Book> GetAllBook()
    {
        try
        {
            return _bookRepository.FindAll();
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public ICollection<Book> SearchBook(string title)
    {
        try
        {
            return _bookRepository.FindByTitle(title);
        }
        catch (Exception e)
        {
            throw;
        }
    }

    public Book GetById(string id)
    {
        try
        {
            var existingBook = _bookRepository.FindById(Guid.Parse(id));
            if (existingBook != null) return existingBook;

            throw new Exception("Book not found");
        }
        catch (Exception e)
        {
            throw;
        }
    }
}