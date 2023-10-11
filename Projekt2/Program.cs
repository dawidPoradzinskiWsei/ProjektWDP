using System.Formats.Asn1;
using System.Net;

namespace Projekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
        }
        public static void Example()
        {
            sbyte int1 = 127; // -128 - 127
            byte uint1 = 255; // 0 - 255

            short int2 = 32_767; // -32768 - 32767
            ushort uint2 = 65_535; // 0 - 65535

            int int4 = 2_147_483_647; // -2,147,483,648 - 2,147,483,647
            uint uint4 = 4_294_967_295; // 0 - 4,294,967,295

            long int8 = 9_223_372_036_854_775_807L; // 9,223,372,036,854,775,808 - 9,223,372,036,854,775,807
            ulong uint8 = 18_446_744_073_709_551_615L; // 0 - 18,446,744,073,709,551,615

            float floating = 10.45f;

            double doubling = 10.483792889642e10;

            char singleCharacter = 'o';

            // after . 

            Console.WriteLine(uint2 / 40000);
            Console.WriteLine(uint2 / 40000.0);
            Console.WriteLine(0 / 0.0);

            // decimal

            decimal perfect = 0.1m;

            Console.WriteLine(perfect * 0.1m);

            // Math

            Console.WriteLine(Math.Ceiling(0.1));

            Console.WriteLine(Math.Floor(0.1));

            Console.WriteLine(Math.Round(1.5));

            Console.WriteLine(Math.Truncate(2.6));

            Console.WriteLine(Math.Sqrt(4));

            Console.WriteLine(Math.Pow(3,2));

            int1 -= 10;
        }

        public static void Task1()
        {
            int number = 146;
            int setki = number / 100;
            number %= 100;
            int dziesiatki = number / 10;
            number %= 10;
            int jednostki = number / 1;

            Console.WriteLine($"{setki} {dziesiatki} {jednostki}");
        }


        public static void Task2()
        {
            double degree = 90;
            double sinValue = Math.Sin((Math.PI * degree) / 180);
            Console.WriteLine(sinValue);
        }

        public static void Task3()
        {
            double area = 189;
            double radius;

            area = Math.Max(area, 0);
                
            radius = Math.Sqrt((area / 180));

            Console.WriteLine(radius);
        }

        public static void Task4()
        {
            double x = 0.45;
            double a = 1.5;
            double b = 3.2;
            double c = 4;
            double y = a * Math.Pow(x, 2) + b * x + c;

            Console.WriteLine(y);
        }

        public static void Task5()
        {
            int a = 9;
            int b = 6;
            int c = 2;
            int max = Math.Max(a, b);
            max = Math.Max(max, c);
            int min = Math.Min(a, b);
            min = Math.Min(min, c);

            Console.WriteLine($"Max = {max}\n\nMin = {min}");
        }
        
        public static void Task6()
        {
            double time = 582.76;
            //double time = 1234.45; // czas w minutach
            int hours = (int)(time / 60);
            time = time - hours*60;
            int minutes = (int)Math.Truncate(time);
            int seconds = (int)(60 * (time - minutes));

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}