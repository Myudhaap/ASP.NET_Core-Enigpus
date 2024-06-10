using EnigpusCLI.Services;
using EnigpusCLI.Utils;

namespace EnigpusCLI.Views;

public class ViewDeleteBook
{
    public static void Run(IInventoryService inventoryService)
    {
        try
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"|{Util.CenterText("DELETE BOOK", 58)}|");
            Console.WriteLine(new string('-', 60));

            Console.Write("| Enter id book: ");
            var id = Util.InputString("ID", false);

            var book = inventoryService.GetById(id);
            BookUtil.PrinBook(book);

            var isDelete = Util.InputYesOrNo("Are you want to delete the Book?");
            if (isDelete)
            {
                inventoryService.Delete(book.Code.ToString());
                Util.PrintSuccess("Successfully delete novel book.");
            }
        }
        catch (Exception e)
        {
            Util.PrintError(e.Message);
        }
        
        Console.Write("Enter any key to continue...");
        Console.ReadKey();
    }
}