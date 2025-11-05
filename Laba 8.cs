using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int[] arr = { 5, -7, -2, 10, 9, -12, 3 };

        int min = Math.Abs(arr[0]);
        int max = Math.Abs(arr[0]);

        for (int i = 0; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) < min)
                min = Math.Abs(arr[i]);

            if (Math.Abs(arr[i]) > max)
                max = Math.Abs(arr[i]);
        }

        int riz = max - min;

        Console.WriteLine("Найменший за модулем елемент: " + min);
        Console.WriteLine("Найбільший за модулем елемент: " + max);
        Console.WriteLine("Різниця між ними: " + riz);
    }
}
