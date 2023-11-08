namespace Projekt5;

class Program
{
    static void Main(string[] args)
    {
        int index;
        int[] ints = {4,3,8,3,-2,3};

        FindValue(ints, 3, out index);

        Console.WriteLine($" index jest równy = {index}");

    }

    public static void FunctionExample()
    {
        double[] tab = {2,3,4,5,6};
        int x = 5;
        int y = 10;
        Swap(ref x, ref y);
        Console.WriteLine($"x = {x} y = {y}");
    }

    public static void ProcedureExample()
    {
        Print(5.5);
        double x = 2.5;
        Print(x * 2);
    }

    public static void Print(double x)
    {
        Console.WriteLine(x);
    }

    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static double PowerMinusOne(double x)
    {
        return x * x - 1;
    }

    public static int findValue(double[] tab, double value)
    {
        for(int i = 0; i < tab.Length; i++)
        {
            if(tab[i] == value)
            {
                return i;
            }
        }
        return -1;
    }

    public static void Swap(ref int x, ref int y)
    {
        int z = x + y;
        x = z - x;
        y = z - x;
    }

    public static bool FindValue(int[] args, int value, out int index)
    {
        for(int i = 0; i < args.Length; i++)
        {
            if(args[i] == value)
            {
                index = i;
                return true;
            }
        }
        index = -1;
        return false;
    }
}
