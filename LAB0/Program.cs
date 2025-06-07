using System;
using System.IO;

class Program
{
   static void Main()
    {
        int low;
        int high;
        Console.Write("Enter a positive Low number: ");
        low= Convert.ToInt32(Console.ReadLine());
        while (low <= 0)
        {
            Console.Write("low must be positve, Enter again: ");
            low= Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("enter a high number(greater than low):");
        high= Convert.ToInt32(Console.ReadLine());
        while (high <= low)
        {
            Console.Write("High must be greater than low, try again: ");
            high= Convert.ToInt32(Console.ReadLine());
        }

        int difference = high -low;
        Console.WriteLine("the difference is:" + difference);

        int size = high - low + 1;
        int[] numbers= new int[size];
        int index = 0;
        for (int i = low; i <= high; i++)
        {
            numbers[index++] = i;
        }


        StreamWriter writer = new StreamWriter("numbers.txt");
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            writer.WriteLine(numbers[i]);
        }
        writer.Close();
        Console.WriteLine("numbers written to file in revese order");

        string[] lines = File.ReadAllLines("numbers.txt");
        int sum = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            sum += Convert.ToInt32(lines[i]);

        }
        Console.WriteLine("sum of numbers from file:" +sum);
        Console.WriteLine("Prime numbers between low and high:");
        for (int i = low; i <= high; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}