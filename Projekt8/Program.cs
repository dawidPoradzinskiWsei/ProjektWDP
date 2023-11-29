using System.Text;

namespace Projekt8;

class Program
{
    static void Main(string[] args)
    {
        // StringCreation();
        // StringIteration();
        // StringShift();
        // StringShiftWithStringBuilder();
        // StringInstanceMethods();
        // StringStaticMethods();
        DateCreation();
    }

    public static void DateCreation()
    {
        
        DateTime now = DateTime.Now;
        DateTime date = new(2002, 08, 16);

        string read = Console.ReadLine();

        if(DateTime.TryParse(read, out var data))
        {
            Console.WriteLine($" Udało się odczytać datę: {data}");
        }
        else
        {
            Console.WriteLine("Podałeś złą datę!");
        }

        Console.WriteLine(now.Year - date.Year);
        Console.WriteLine(now.AddDays(122));

        
}

    public static void StringStaticMethods()
    {
        string[] names = {"adam", "ewa", "karol"};

        Console.WriteLine(string.Concat(names));
        Console.WriteLine(string.Join(", ", names));

        Console.WriteLine(string.Compare("asd", "asdd"));
    }

    public static void StringInstanceMethods()
    {
        string str = "witam wszystkich";

        Console.WriteLine(" asda asdas bdfb asd".Replace(" ", ""));
        Console.WriteLine("     asda     asd ad     asd  ".Trim());
        Console.WriteLine(str.IndexOf("a"));
        Console.WriteLine(str.Substring(2, 5));

        str = "adam@wsei.edu.pl";

        Console.WriteLine(str.Substring(str.IndexOf('@') + 1));
    }
    public static void StringShift()
    {
        string str = "Siemka";
        string target = string.Empty;

        for(int c = 0; c < str.Length; c++)
        {
            int ascii = str[c];
            ascii += 3;
            target += (char)ascii; //konkatenacja - co to za słowo wgl
        }

        Console.WriteLine(target);
    }

    public static void StringShiftWithStringBuilder()
    {
        string str = "Tajna wiadomość";
        StringBuilder builder = new StringBuilder();

        foreach(int numericLetter in str)
        {
            char c = (char) (numericLetter + 3);
            builder.Append(c);
        }

        Console.WriteLine(builder.ToString());
    }
    public static void StringCreation()
    {
        string Message = "abcd";
        string MessageInterpolated = $"Value of Message: {Message}";
        string Path = @"C:\Program files\Program";
        string MessageRaw = @"line1
line2";
        Console.WriteLine(MessageRaw);
        Console.WriteLine(Message);
        Console.WriteLine(MessageInterpolated);
        Console.WriteLine(Path);
        
        char[] Chars = {'a','b','c','d'};
        string MessageFromChars = new(Chars);

        Console.WriteLine(MessageFromChars);
    }

    public static void StringIteration()
    {
        String str = "Bardzo dlugi string";

        foreach(char letter in str)
        {
            Console.Write(letter);
        }
        Console.Write("\n");
        for(int c = 0; c < str.Length; c++)
        {
            int i = str[c];
            Console.Write(i);
        }
        Console.Write("\n");

        foreach(int numericLetter in str)
        {
            Console.Write($"{numericLetter} ");
        }

        Console.Write("\n");

        char[] chars = {'a', 'b', 'c', 'd'};

        for(int c = 0; c < chars.Length; c++)
        {
            chars[c] = (char)((int) chars[c] + 3);
        }

        Console.WriteLine(chars);
    }
}
