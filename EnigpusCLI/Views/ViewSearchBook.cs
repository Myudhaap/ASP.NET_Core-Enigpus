using EnigpusCLI.Models;
using EnigpusCLI.Services;
using EnigpusCLI.Utils;

namespace EnigpusCLI.Views;

public class ViewSearchBook
{
    public static void Run(IInventoryService inventoryService)
    {
        try
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"|{Util.CenterText("SEARCH BOOK", 58)}|");
            Console.WriteLine(new string('-', 60));

            Console.Write("| Enter title book: ");
            var title = Util.InputString("Title", false);

            var books = inventoryService.SearchBook(title).ToList();
            BookUtil.PrinBooks(books);
        }
        catch (Exception e)
        {
            Util.PrintError(e.Message);
        }

        Console.Write("Enter any key to continue...");
        Console.ReadKey();
    }
}