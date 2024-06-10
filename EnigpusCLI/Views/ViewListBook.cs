using EnigpusCLI.Services;
using EnigpusCLI.Utils;

namespace EnigpusCLI.Views;

public class ViewListBook
{
    public static void Run(IInventoryService inventoryService)
    {
        try
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"|{Util.CenterText("LIST BOOK", 58)}|");
            Console.WriteLine(new string('-', 60));
            Console.WriteLine();

            var books = inventoryService.GetAllBook().ToList();
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