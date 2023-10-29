using System;


class Task1
{

    public static void Main()
    {
        RangeOfArray arr = new RangeOfArray(-9, 15);

        arr[-9] = 5;
        arr[-8] = 10;
        arr[15] = 7;

        Console.WriteLine(arr[-9]);
        Console.WriteLine(arr[-8]);
        Console.WriteLine(arr[15]);

    }
}


public class RangeOfArray
{
    private int[] array;
    private int startIndex;
    private int length;

    public RangeOfArray(int lowerBound, int upperBound)
    {
        if (upperBound < lowerBound)
            throw new ArgumentException("Верхняя граница должна быть больше или равна нижней границе");

        startIndex = lowerBound;
        length = upperBound - lowerBound + 1;
        array = new int[length];
    }

    public int this[int index]
    {
        get
        {
            if (index < startIndex || index >= startIndex + length)
                throw new IndexOutOfRangeException("Индекс вышел за границы");

            return array[index - startIndex];
        }
        set
        {
            if (index < startIndex || index >= startIndex + length)
                throw new IndexOutOfRangeException("Индекс вышел за границы");

            array[index - startIndex] = value;
        }
    }
}