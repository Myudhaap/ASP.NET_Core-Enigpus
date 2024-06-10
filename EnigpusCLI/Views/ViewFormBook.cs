using EnigpusCLI.Models;
using EnigpusCLI.Services;
using EnigpusCLI.Utils;

namespace EnigpusCLI.Views;

public class ViewFormBook
{
    public static void Run(IInventoryService inventoryService)
    {
        try
        {
            Console.WriteLine("Type books:");
            Console.WriteLine("1. Novel");
            Console.WriteLine("2. Magazine");
            Console.Write("Choose Type: ");
            
            var menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    NovelForm(inventoryService);
                    break;
                case "2":
                    MagazineForm(inventoryService);
                    break;
                default:
                    Util.PrintError("Invalid menu!");
                    break;
            }
        }
        catch (Exception e)
        {
            Util.PrintError(e.Message);
        }
    }

    private static void NovelForm(IInventoryService inventoryService)
    {
        try
        {
            var novel = new Novel();
            
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"|{Util.CenterText("FORM BOOK NOVEL", 58)}|");
            Console.WriteLine(new string('-', 60));

            Console.Write("| Title: ");
            novel.Title = Util.InputString("Title", true);
            
            Console.Write("| Author: ");
            novel.Author = Util.InputString("Author", true) ?? "";
            
            Console.Write("| Publisher: ");
            novel.Publisher = Util.InputString("Publisher", true) ?? "";
            
            Console.Write("| Published Year: ");
            novel.PublishedYear = Util.InputNumber("Published Year", true);
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"|{$"Title: {novel.Title}",-58}|");
            Console.WriteLine($"|{$"Author: {novel.Author}",-58}|");
            Console.WriteLine($"|{$"Publisher: {novel.Publisher}",-58}|");
            Console.WriteLine($"|{$"PublishedYear: {novel.PublishedYear}",-58}|");
            Console.WriteLine(new string('=', 60));
            
            var isSave = Util.InputYesOrNo("Are you want to save the Book?");
            if (isSave)
            {
                inventoryService.AddBook(novel);
                Util.PrintSuccess("Successfully add novel book.");
            }
        }
        catch (Exception e)
        {
            throw;
        }
        
    }
    
    private static void MagazineForm(IInventoryService inventoryService)
    {
        try
        {
            var novel = new Magazine();
            
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"|{Util.CenterText("FORM BOOK MAGAZINE", 58)}|");
            Console.WriteLine(new string('-', 60));

            Console.Write("| Title: ");
            novel.Title = Util.InputString("Title", true) ?? "";
           
            Console.Write("| Publisher: ");
            novel.Publisher = Util.InputString("Publisher", true) ?? "";
            
            Console.Write("| Published Year: ");
            novel.PublishedYear = Util.InputNumber("Published Year", true);
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"|{$"Title: {novel.Title}",-58}|");
            Console.WriteLine($"|{$"Publisher: {novel.Publisher}",-58}|");
            Console.WriteLine($"|{$"PublishedYear: {novel.PublishedYear}",-58}|");
            Console.WriteLine(new string('=', 60));
            
            var isSave = Util.InputYesOrNo("Are you want to save the Book?");
            if (isSave)
            {
                inventoryService.AddBook(novel);
                Util.PrintSuccess("Successfully add magazine book.");
            }
        }
        catch (Exception e)
        {
            throw;
        }
        
    }
}