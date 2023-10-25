using System.IO;
using System;
namespace Projekt4;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // ArraysExample();
        // Task1();
        // ForStatment();
        // WhileStatment();
        HomeworkTask5();
    }

    public static void ArraysExample()
    {
        // _create new int array and write third element to console_
        // create int array
        int[] intArrayWithNumbers = {1, 3, -2, 4, 2};
        // write third element of array
        Console.WriteLine(intArrayWithNumbers[4]);

        // _create new single letter array and write second element to console_
        char[] charArrayForExample2 = {'a', 'b', 'c'};

        // write second element
        Console.WriteLine(charArrayForExample2[1]);
        // _write last element of array_
       
        // get length of array
        int charArrayLength = charArrayForExample2.Length;
         // check if array isn't empty 
        if(charArrayLength != 0)
        {
            // write last element
            Console.WriteLine(charArrayForExample2[charArrayLength - 1]);
        }
        
    }


    public static void Task1()    
    {
        /**
        * Napisz program obliczający wartość funkcji kwadratowej
        * o wspólczynnikach w factors:
        * a to pierwsza komórka
        * b to druga
        * c to trzecia
        * y = a*x*x + b*x + c
        * Wyświetl y
        * Jeśli tablica jest zbyt krótka to wyślij komunikat "Zbyt malo współczynników"
        */
        // task data
        double[] factors = {3, 5, -1.6};
        double x = 2.4;

        // get array length
        int factorsArrayLength = factors.Length;

        // check if array is less than 3
        if(factorsArrayLength < 3)
        {
            // write to console text
            Console.WriteLine("Zbyt mało współczynników");
            return;
        }

        // else write answer
        Console.WriteLine($"y = {factors[0] * Math.Pow(x,2) + factors[1] * x + factors[2]}");
    }

    public static void ForStatment()
    {
        // _create for examples_

        // create double array
        double[] factors = {3, 5, -1.6};

        // create loop that goes for entire array
        Console.WriteLine("Write from first. Change to 2. Write changed from [3,5,-1.6]");
        for(int i = 0; i < factors.Length; i++)
        {
            // _write every single number from array_
            Console.WriteLine($"factors[{i}] = {factors[i]}");
            // _change every single number to 2 and write to console_
            // change number from single array to 2
            factors[i] = 2;
            // write changed number to console
            Console.WriteLine($"factors[{i}] = {factors[i]}");
        }

        // _write factors in reverse order_
        Console.WriteLine("Reverse order from [3,6,8]");
        factors = new double[]{3,6,8};

        for(int i = factors.Length-1; i > -1; i--)
        {
            Console.WriteLine($"factors[{i}] = {factors[i]}");
        }

        // _write even numbers in for from 0 to 20
        Console.WriteLine("Write even numbers from 0");

        for(int i = 0; i < 20; i += 2)
        {
            Console.Write($"{i} ");
        }

        // _write odd numbers in for from 10 to 30
        Console.WriteLine("\nWrite odd numbers from 10");
        for(int i = 10; i <= 30; i += 2)
        {
            // if you don't want know first and last number
            // check if is even
            if(i%2 == 0)
            {
                // if yes, add +i right now
                i++;
            }
            Console.Write($"{i} ");
        }
    }
    public static void WhileStatment()
    {
        char cha;
        while((cha = Console.ReadKey().KeyChar) != 'q')
        {
            Console.WriteLine("\nq - wyjsice");
            Console.WriteLine("a - wyswietl komunikat");

            if(cha == 'a')
            {
                Console.WriteLine("Co ty tu robisz?");
            }
        }
    }

    public static void HomeworkTask5()
    {
        Console.WriteLine("Wpisz dodatnią liczbę");
        int number;

        while(int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("a");
        }
    }
}
