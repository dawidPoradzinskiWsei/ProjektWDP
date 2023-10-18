namespace Projekt3;

class Program
{
    static void Main(string[] args)
    {
        // Task1();
        // Task2();
        // Task3();
        // Task4();
        // Task5();
        // Task6();
        // Task7();
        // Task8();
        monety();
        samogloska();
    }

    public static void Task1()
    {
        decimal balans = 56;
        bool isCreditCardValid = false;
        decimal price = 45;
        bool canPay = (balans > price) && isCreditCardValid;

        Console.WriteLine(canPay);
    } 

    public static void Task2(){
        double a = 5;
        double b = 1;
        double c = 3;
        bool isTriangle = a < (b + c) && b < (a + c) && c < (a + b);

        Console.WriteLine(isTriangle);
    }

    public static void Task3(){
        double cx = 2.56;
        double cy = 4.6;
        double cradius = 5;
        double x = 6.4;
        double y = 2.234;
        bool isOutside = (cx > x - cradius && cx < x + cradius) && (cy > y - cradius && cy < y + cradius);

        Console.WriteLine(isOutside);
    }
        public static void Task4(){
        int rx = 56;
        int ry = 34;
        int width = 23;
        int height = 12;
        int x = 23;
        int y = 11;
        bool isOnBorder = (x >= rx && x <= rx + width) && (y <= ry && y >= ry - height);
        
        Console.WriteLine(isOnBorder);    
    }

    public static void Task5()
    {
        // double x = 1.34;
        double a = 2.5;
        double b = 4;
        double c = 0;

        double delta = Math.Pow(b, 2) - (4 * a * c);

        if(delta < 0)
        {
            Console.WriteLine("Nie można otrzymać pierwiastków rzeczywistych!");
        }
        else if(delta == 0)
        {
            double singleX = -b/(2*a);
            Console.WriteLine($"x: singleX");
        }
        else
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2*a);
            double x2 = (-b + Math.Sqrt(delta)) / (2*a);
            Console.WriteLine($"x1: {x1} oraz x2: {x2}");
        }
                
    }

    public static void Task6()
    {
        int code = 16;
        int quantity = 100;
        decimal price = 3.5m;
        decimal sellPrice;
        
        if(code < 10)
        {
            sellPrice = price;
        }
        else if (code < 15)
        {
            sellPrice = 0.95m * price;
        }
        else
        {
            if(quantity < 10)
            {
                sellPrice = 1.05m * price;
            }
            else if(quantity < 20)
            {
                sellPrice = price;
            }
            else if(quantity < 100)
            {
                sellPrice = (1m - (quantity/10) * 0.01m) * price;
            }
            else
            {
                sellPrice = 0.9m * price;
            }
        }

        Console.WriteLine($"Price: {sellPrice}");
    }

    public static void Task7()
    {
        int decimalNumber = 11; 

        switch(decimalNumber)
        {
            case 0:
            {
                Console.WriteLine("Rzymianie nie znali zera");
                break;
            }
            case 1:
            {
                Console.WriteLine("I");
                break;
            }
            case 2:
            {
                Console.WriteLine("II");
                break;
            }
            case 3:
            {
                Console.WriteLine("III");
                break;
            }
            case 4:
            {
                Console.WriteLine("IV");
                break;
            }
            case 5:
            {
                Console.WriteLine("V");
                break;
            }
            case 6:
            {
                Console.WriteLine("VI");
                break;
            }
            case 7:
            {
                Console.WriteLine("VII");
                break;
            }
            case 8:
            {
                Console.WriteLine("VIII");
                break;
            }
            case 9:
            {
                Console.WriteLine("IX");
                break;
            }
            case 10:
            {
                Console.WriteLine("X");
                break;
            }
            case 11:
            {
                Console.WriteLine("XI");
                break;
            }
            case 12:
            {
                Console.WriteLine("XII");
                break;
            }
            case 13:
            {
                Console.WriteLine("XIII");
                break;
            }
            case 14:
            {
                Console.WriteLine("XIV");
                break;
            }
            case 15:
            {
                Console.WriteLine("XV");
                break;
            }
            case 16:
            {
                Console.WriteLine("XVI");
                break;
            }
            case 17:
            {
                Console.WriteLine("XVII");
                break;
            }
            case 18:
            {
                Console.WriteLine("XVIII");
                break;
            }
            case 19:
            {
                Console.WriteLine("XIX");
                break;
            }
            case 20:
            {
                Console.WriteLine("XX");
                break;
            }
            default:
            {
                Console.WriteLine("Nie obsługuję liczb spoza zakresu od 1 do 20!");
                break;
            }
        }
    }
    public static void Task8()
    {
        char hex = 'b';
        // if(hex >= '0' && hex <= '9')
        // {
        //     Console.WriteLine((int)hex - 48);
        // }
        // else if(hex >= 'A' && hex <= 'F')
        // {
        //     Console.WriteLine((int)hex - 55);
        // }
        // else if(hex >= 'a' && hex <= 'f')
        // {
        //     Console.WriteLine((int)hex - 87);
        // }
        // else
        // {
        //     Console.WriteLine("To nie jest cyfra szesnatkowa");
        // }

        // or else

        if(hex >= '0' && hex <= '9')
        {
            Console.WriteLine((int)hex - 48);
        }
        else
        {
            switch(hex)
            {
                case 'a': case 'A':
                {
                    Console.WriteLine("10");
                    break;
                }
                case 'b': case 'B':
                {
                    Console.WriteLine("11");
                    break;
                }
                case 'c': case 'C':
                {
                    Console.WriteLine("12");
                    break;
                }
                case 'd': case 'D':
                {
                    Console.WriteLine("13");
                    break;
                }
                case 'e': case 'E':
                {
                    Console.WriteLine("14");
                    break;
                }
                case 'f': case 'F':
                {
                    Console.WriteLine("15");
                    break;
                }
                default:
                {
                    Console.WriteLine("To nie jest cyfra szesnatkowa");
                    break;
                }
            }
        }
    }

    public static void monety()
    {
        int moneta = 12;

        switch(moneta)
        {
            case 1:
            {
                Console.WriteLine("1zł PLN");
                break;
            }
            case 2:
            {
                Console.WriteLine("2ZŁ PLN");
                break;
            }
            case 5:
            {
                Console.WriteLine("5ZŁ PLN");
                break;
            }
            default:
            {
                Console.WriteLine("Nie ma takiego nominału");
                break;
            }
        }
    }

    public static void samogloska()
    {
        char letter = 'A';

        switch(letter)
        {
            case 'A': case 'E': case 'I': case 'U': case 'Y': case 'a': case 'e': case 'i': case 'u': case 'y':
            {
                Console.WriteLine("samogłoska");
                break;
            }
            default:
            {
                Console.WriteLine("spółgłoska");
                break;
            }
        }
    }
}
