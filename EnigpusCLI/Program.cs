using EnigpusCLI.Repositories.Impls;
using EnigpusCLI.Services.Impls;
using EnigpusCLI.Views;

public class Program
{
    public static void Main(string[] args)
    {
        Run();
    }

    public static void Run()
    {
        var bookRepository = new BookRepositoryImpl();
        var inventoryService = new InventoryServiceImpl(bookRepository);
        
        var view = new View(inventoryService);
        
        view.Run();
    }
}