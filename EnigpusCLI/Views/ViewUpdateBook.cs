using EnigpusCLI.Models;
using EnigpusCLI.Services;
using EnigpusCLI.Utils;

namespace EnigpusCLI.Views;

public class ViewUpdateBook
{
    public static void Run(IInventoryService inventoryService)
    {
        try
        {
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"|{Util.CenterText("UPDATE BOOK", 58)}|");
            Console.WriteLine(new string('-', 60));

            Console.Write("| Enter id book: ");
            var id = Util.InputString("ID", false);

            var book = inventoryService.GetById(id);
            BookUtil.PrinBook(book);

            switch (book)
            {
                case Novel:
                    NovelForm(inventoryService, book.Code);
                    break;
                case Magazine:
                    MagazineForm(inventoryService, book.Code);
                    break;
            }
        }
        catch (Exception e)
        {
            Util.PrintError(e.Message);
        }
        
        Console.Write("Enter any key to continue...");
        Console.ReadKey();
    }
    
    
    private static void NovelForm(IInventoryService inventoryService,Guid id)
    {
        try
        {
            var novel = new Novel();
            novel.Code = id;
            
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"|{Util.CenterText("FORM BOOK NOVEL", 58)}|");
            Console.WriteLine(new string('-', 60));

            Console.Write("| Title: ");
            novel.Title = Util.InputString("Title", false);
            
            Console.Write("| Author: ");
            novel.Author = Util.InputString("Author", false) ?? "";
            
            Console.Write("| Publisher: ");
            novel.Publisher = Util.InputString("Publisher", false) ?? "";
            
            Console.Write("| Published Year: ");
            novel.PublishedYear = Util.InputNumber("Published Year", false);
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"|{$"Id: {novel.Code}",-58}|");
            Console.WriteLine($"|{$"Title: {novel.Title}",-58}|");
            Console.WriteLine($"|{$"Author: {novel.Author}",-58}|");
            Console.WriteLine($"|{$"Publisher: {novel.Publisher}",-58}|");
            Console.WriteLine($"|{$"PublishedYear: {novel.PublishedYear}",-58}|");
            Console.WriteLine(new string('=', 60));
            
            var isUpdate = Util.InputYesOrNo("Are you want to update the Book?");
            if (isUpdate)
            {
                inventoryService.UpdateBook(novel);
                Util.PrintSuccess("Successfully update novel book.");
            }
        }
        catch (Exception e)
        {
            Util.PrintError(e.Message);
        }
        
    }
    
    private static void MagazineForm(IInventoryService inventoryService, Guid id)
    {
        try
        {
            var magazine = new Magazine();
            magazine.Code = id;
            
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"|{Util.CenterText("FORM BOOK MAGAZINE", 58)}|");
            Console.WriteLine(new string('-', 60));

            Console.Write("| Title: ");
            magazine.Title = Util.InputString("Title", false) ?? "";
           
            Console.Write("| Publisher: ");
            magazine.Publisher = Util.InputString("Publisher", false) ?? "";
            
            Console.Write("| Published Year: ");
            magazine.PublishedYear = Util.InputNumber("Published Year", false);
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"|{$"Id: {magazine.Code}",-58}|");
            Console.WriteLine($"|{$"Title: {magazine.Title}",-58}|");
            Console.WriteLine($"|{$"Publisher: {magazine.Publisher}",-58}|");
            Console.WriteLine($"|{$"PublishedYear: {magazine.PublishedYear}",-58}|");
            Console.WriteLine(new string('=', 60));
            
            var isUpdate = Util.InputYesOrNo("Are you want to update the Book?");
            if (isUpdate)
            {
                inventoryService.UpdateBook(magazine);
                Util.PrintSuccess("Successfully update magazine book.");
            }
        }
        catch (Exception e)
        {
            Util.PrintError(e.Message);
        }
    }
    
}