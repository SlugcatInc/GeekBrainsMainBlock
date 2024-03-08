using System;

public class MainBlock
{
    static void Main()
    {
        string[] inputArray = { "Hello", "2", "world" };

        string[] resultArray = FilterArray(inputArray);

        Console.WriteLine("Filtered array:");
        foreach (string item in resultArray)
        {
            Console.WriteLine(item);
        }
    }

    static string[] FilterArray(string[] inputArray)
    {
        int count = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        int index = 0;
        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                resultArray[index] = item;
                index++;
            }
        }

        return resultArray;
    }
}
