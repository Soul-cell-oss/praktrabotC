using System;

public class GenericArray<T>
{
    private T[] array;
    private int count;

    public GenericArray(int size)
    {
        array = new T[size];
        count = 0;
    }


    public void Add(T item)
    {
        if (count >= array.Length)
        {
            throw new InvalidOperationException("Массив полон.");
        }
        array[count] = item;
        count++;
    }


    public void Remove(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException("Индекс вне диапазона.");
        }

        for (int i = index; i < count - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[count - 1] = default; 
        count--;
    }


    public T Get(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException("Индекс вне диапазона.");
        }
        return array[index];
    }


    public int Length()
    {
        return count;
    }


    public void Clear()
    {
        array = new T[array.Length]; 
        count = 0; 
    }
}


public class Program
{
    public static void Main()
    {
        GenericArray<int> intArray = new GenericArray<int>(5);
        intArray.Add(1);
        intArray.Add(2);
        intArray.Add(3);

        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < intArray.Length(); i++)
        {
            Console.WriteLine(intArray.Get(i));
        }

        intArray.Remove(1);

        Console.WriteLine("\nПосле удаления элемента по индексу 1:");
        for (int i = 0; i < intArray.Length(); i++)
        {
            Console.WriteLine(intArray.Get(i));
        }

        intArray.Clear();
        Console.WriteLine($"\nДлина массива после очистки: {intArray.Length()}");
    }
}
