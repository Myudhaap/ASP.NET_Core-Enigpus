using System.Collections;
using EnigpusCLI.Models;

namespace EnigpusCLI.Repositories;

public interface IBookRepository
{
    void Save(Book entity);
    void Update(Book entity);
    void Delete(Book entity);
    ICollection<Book> FindAll();
    Book? FindById(Guid id);
    ICollection<Book> FindByTitle(string title);
}