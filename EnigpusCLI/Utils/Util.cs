namespace EnigpusCLI.Utils;

public class Util
{
    public static void PrintError(string text)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(text);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine();
    }
    
    public static void PrintSuccess(string text)
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(text);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine();
    }

    public static string InputString(string field, bool isRequired)
    {
        string? input;
        if (isRequired)
        {
            while (true)
            {
                input = Console.ReadLine();
                if (input is not "")
                {
                    break;
                }
                PrintError($"Field `{field}` required.");
                Console.Write($"| {field}: ");
            }
        }
        else
        {
            input = Console.ReadLine();
        }

        return input ?? "";
    }
    
    public static int InputNumber(string field, bool isRequired)
    {
        string input = null;
        try
        {
            if (isRequired)
            {
                while (true)
                {
                    input = Console.ReadLine();
                    if (input is not "")
                    {
                        break;
                    }

                    PrintError($"Field {field} required.");
                    Console.Write($"| {field}: ");
                }
            }
            else
            {
                input = Console.ReadLine() ?? "0";
            }

            return Convert.ToInt32(input);
        }
        catch (Exception e)
        {
            
            if (isRequired)
            {
                Util.PrintError(e.Message);
                Console.Write($"| {field}: ");
                return InputNumber(field, isRequired);
            }

            return 0;
        }
    }

    public static bool InputYesOrNo(string text)
    {
        while (true)
        {
            Console.Write(text + "(yes/no) ");
            var  input = Console.ReadLine();
            
            if (input.ToLower().Equals("yes") || input.ToLower().Equals("y"))
            {
                return true;
            } else if (input.ToLower().Equals("no") || input.ToLower().Equals("n"))
            {
                return false;
            }
            else
            {
                PrintError("Input is not valid, try again.");
            }
        }
    }
    
    public static string CenterText(string text, int width)
    {
        if (string.IsNullOrEmpty(text) || text.Length >= width)
        {
            return text;
        }

        int padding = (width - text.Length) / 2;
        return text.PadLeft(text.Length + padding).PadRight(width);
    }
}