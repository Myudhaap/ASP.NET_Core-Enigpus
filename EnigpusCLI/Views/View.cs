using EnigpusCLI.Models;
using EnigpusCLI.Repositories;
using EnigpusCLI.Services;
using EnigpusCLI.Utils;

namespace EnigpusCLI.Views;

public class View
{
    private readonly IInventoryService _inventoryService;

    public View(IInventoryService inventoryService)
    {
        _inventoryService = inventoryService;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"|{Util.CenterText("WELCOME TO ENGIPUS", 58)}|");
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"|{" List Menu:", -58}|");
            Console.WriteLine($"|{" 1. View All Book", -58}|");
            Console.WriteLine($"|{" 2. Search Book", -58}|");
            Console.WriteLine($"|{" 3. Add Book", -58}|");
            Console.WriteLine($"|{" 4. Edit Book", -58}|");
            Console.WriteLine($"|{" 5. Delete Book", -58}|");
            Console.WriteLine($"|{" 6. Exit", -58}|");
            Console.WriteLine(new string('=', 60));
            Console.Write("Enter Menu: ");
            var menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    ViewListBook.Run(_inventoryService);
                    break;
                case "2":
                    ViewSearchBook.Run(_inventoryService);
                    break;
                case "3":
                    ViewFormBook.Run(_inventoryService);
                    break;
                case "4":
                    ViewUpdateBook.Run(_inventoryService);
                    break;
                case "5":
                    ViewDeleteBook.Run(_inventoryService);
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Util.PrintError("Invalid input menu!");
                    break;
            }
        }
    }
}