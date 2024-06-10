using EnigpusCLI.Models;

namespace EnigpusCLI.Services;

public interface IInventoryService
{
    Book AddBook(Book book);
    Book UpdateBook(Book book);
    void Delete(string id);
    ICollection<Book> GetAllBook();
    ICollection<Book> SearchBook(string title);
    Book GetById(string id);
}