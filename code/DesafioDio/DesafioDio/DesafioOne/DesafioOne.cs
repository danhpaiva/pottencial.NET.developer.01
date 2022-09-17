/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int multiplication = 1, sum = 0;
        string number = Console.ReadLine();
        char[] arrayNumber = number.ToCharArray();
        int counter = 0;
        foreach (var item in arrayNumber)
        {
            multiplication *= int.Parse(arrayNumber.GetValue(counter).ToString());
            sum += int.Parse(arrayNumber.GetValue(counter).ToString());
            counter++;
        }

        Console.WriteLine(multiplication - sum);
    }
}
*/