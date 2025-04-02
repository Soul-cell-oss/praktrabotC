using System;

public class Program
{

    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Массив не может быть пустым.");
        }

        T max = array[0]; 

        foreach (T item in array)
        {
            if (item.CompareTo(max) > 0) 
            {
                max = item; 
            }
        }

        return max;
    }

    public static void Main(string[] args)
    {
        // Пример использования с массивом целых чисел
        int[] intArray = { 3, 5, 1, 9, 2 };
        int maxInt = FindMax(intArray);
        Console.WriteLine("Max int: " + maxInt);

    }
}
