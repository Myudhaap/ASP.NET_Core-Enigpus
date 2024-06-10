using System.Collections;
using EnigpusCLI.Models;

namespace EnigpusCLI.Utils;

public class BookUtil
{
    public static void PrinBooks(List<Book> books)
    {
        Console.WriteLine(new string('=', 190));
        Console.Write($"|{Util.CenterText("No",4)}|");
        Console.Write($"{Util.CenterText("Id",39)}|");
        Console.Write($"{Util.CenterText("Type",19)}|");
        Console.Write($"{Util.CenterText("Title",43)}|");
        Console.Write($"{Util.CenterText("Author",29)}|");
        Console.Write($"{Util.CenterText("Publisher",29)}|");
        Console.Write($"{Util.CenterText("Published Year",19)}|\n");
        Console.WriteLine(new string('-', 190));

        var count = 1;
        if (books.Count != 0)
        {
            
            foreach(var book in books)
            {
                if (book is Novel)
                {
                    var novel = (Novel)book;
                    Console.Write($"|{Util.CenterText(count++.ToString(),4)}|");
                    Console.Write($"{Util.CenterText(novel.Code.ToString(),39)}|");
                    Console.Write($"{Util.CenterText("Novel",19)}|");
                    Console.Write($"{Util.CenterText(novel.Title,43)}|");
                    Console.Write($"{Util.CenterText(novel.Author,29)}|");
                    Console.Write($"{Util.CenterText(novel.Publisher,29)}|");
                    Console.Write($"{Util.CenterText(novel.PublishedYear.ToString(),19)}|");
                }else if (book is Magazine)
                {
                    Console.Write($"|{Util.CenterText(count++.ToString(),4)}|");
                    Console.Write($"{Util.CenterText(book.Code.ToString(),39)}|");
                    Console.Write($"{Util.CenterText("Magazine",19)}|");
                    Console.Write($"{Util.CenterText(book.Title,43)}|");
                    Console.Write($"{Util.CenterText("-",29)}|");
                    Console.Write($"{Util.CenterText(book.Publisher,29)}|");
                    Console.Write($"{Util.CenterText(book.PublishedYear.ToString(),19)}|");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine($"|{Util.CenterText("Books not available",188)}|");
        }
        Console.WriteLine(new string('=', 190));
    }
    
        public static void PrinBook(Book book)
    {
        Console.WriteLine(new string('=', 190));
        Console.Write($"|{Util.CenterText("No",4)}|");
        Console.Write($"{Util.CenterText("Id",39)}|");
        Console.Write($"{Util.CenterText("Type",19)}|");
        Console.Write($"{Util.CenterText("Title",43)}|");
        Console.Write($"{Util.CenterText("Author",29)}|");
        Console.Write($"{Util.CenterText("Publisher",29)}|");
        Console.Write($"{Util.CenterText("Published Year",19)}|\n");
        Console.WriteLine(new string('-', 190));

        var count = 1;
        if (book != null)
        {
            if (book is Novel)
            {
                var novel = (Novel)book;
                Console.Write($"|{Util.CenterText(count++.ToString(), 4)}|");
                Console.Write($"{Util.CenterText(novel.Code.ToString(), 39)}|");
                Console.Write($"{Util.CenterText("Novel", 19)}|");
                Console.Write($"{Util.CenterText(novel.Title, 43)}|");
                Console.Write($"{Util.CenterText(novel.Author, 29)}|");
                Console.Write($"{Util.CenterText(novel.Publisher, 29)}|");
                Console.Write($"{Util.CenterText(novel.PublishedYear.ToString(), 19)}|");
            }
            else if (book is Magazine)
            {
                Console.Write($"|{Util.CenterText(count++.ToString(), 4)}|");
                Console.Write($"{Util.CenterText(book.Code.ToString(), 39)}|");
                Console.Write($"{Util.CenterText("Magazine", 19)}|");
                Console.Write($"{Util.CenterText(book.Title, 43)}|");
                Console.Write($"{Util.CenterText("-", 29)}|");
                Console.Write($"{Util.CenterText(book.Publisher, 29)}|");
                Console.Write($"{Util.CenterText(book.PublishedYear.ToString(), 19)}|");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"|{Util.CenterText("Book not found",188)}|");
        }
        Console.WriteLine(new string('=', 190));
    }
}