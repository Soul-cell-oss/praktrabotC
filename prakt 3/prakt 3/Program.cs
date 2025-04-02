using System;

public class IntArrayHandler
{

    private int[] IntArray;


    public IntArrayHandler(int size)
    {
        IntArray = new int[size];
    }


    public void InputElements()
    {
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < IntArray.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            IntArray[i] = Convert.ToInt32(Console.ReadLine());
        }
    }


    public void PrintElements()
    {
        Console.WriteLine("Элементы массива:");
        foreach (var item in IntArray)
        {
            Console.WriteLine(item);
        }
    }


    public void SortArray()
    {
        Array.Sort(IntArray);
    }

 
    public int Size
    {
        get { return IntArray.Length; }
    }


    public int Scalar
    {
        set
        {
            for (int i = 0; i < IntArray.Length; i++)
            {
                IntArray[i] *= value;
            }
        }
    }


    public int this[int index]
    {
        get { return IntArray[index]; }
        set { IntArray[index] = value; }
    }


    public static IntArrayHandler operator ++(IntArrayHandler arr)
    {
        for (int i = 0; i < arr.IntArray.Length; i++)
        {
            arr.IntArray[i]++;
        }
        return arr;
    }


    public static IntArrayHandler operator --(IntArrayHandler arr)
    {
        for (int i = 0; i < arr.IntArray.Length; i++)
        {
            arr.IntArray[i]--;
        }
        return arr;
    }


    public static bool operator !(IntArrayHandler arr)
    {
        for (int i = 1; i < arr.IntArray.Length; i++)
        {
            if (arr.IntArray[i] < arr.IntArray[i - 1])
            {
                return true; 
            }
        }
        return false; 
    }


    public static IntArrayHandler operator *(IntArrayHandler arr, int scalar)
    {
        IntArrayHandler result = new IntArrayHandler(arr.Size);
        for (int i = 0; i < arr.IntArray.Length; i++)
        {
            result.IntArray[i] = arr.IntArray[i] * scalar;
        }
        return result;
    }


    public static implicit operator int[](IntArrayHandler arr)
    {
        return arr.IntArray;
    }


    public static implicit operator IntArrayHandler(int[] arr)
    {
        IntArrayHandler handler = new IntArrayHandler(arr.Length);
        for (int i = 0; i < arr.Length; i++)
        {
            handler.IntArray[i] = arr[i];
        }
        return handler;
    }
}

class Program
{
    static void Main()
    {

        IntArrayHandler intArrayHandler = new IntArrayHandler(5);


        intArrayHandler.InputElements();

 
        intArrayHandler.PrintElements();

        intArrayHandler.SortArray();
        Console.WriteLine("После сортировки:");
        intArrayHandler.PrintElements();


        Console.WriteLine($"Массив не отсортирован: {!intArrayHandler}");

        intArrayHandler++;
        Console.WriteLine("После увеличения всех элементов на 1:");
        intArrayHandler.PrintElements();


        intArrayHandler.Scalar = 2;
        Console.WriteLine("После умножения всех элементов на 2:");
        intArrayHandler.PrintElements();

        int[] array = intArrayHandler;
        Console.WriteLine("Преобразованный в одномерный массив:");
        Console.WriteLine(string.Join(", ", array));
    }
}
