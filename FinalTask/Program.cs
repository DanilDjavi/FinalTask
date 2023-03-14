using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inputArray = { "один", "два", "три", "четыре", "пять", "six", "x", "z" };
        string[] outputArray = new string[inputArray.Length];
        int j = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                outputArray[j] = inputArray[i];
                j++;
            }
        }

        Array.Resize(ref outputArray, j);

        Console.Write("Исходный массив: ");
        foreach (string element in inputArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Новый массив: ");
        foreach (string element in outputArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Для выхода нажмите Enter");
        Console.ReadLine();
    }
}