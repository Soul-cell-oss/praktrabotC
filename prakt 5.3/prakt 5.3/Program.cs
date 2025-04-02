using System;

public class GenericArray<T>
{

    public T[] Elements { get; private set; }

 
    public GenericArray(T[] elements)
    {
        Elements = elements;
    }

 
    public static GenericArray<T> operator +(GenericArray<T> a, GenericArray<T> b)
    {

  
        T[] combinedArray = new T[a.Elements.Length + b.Elements.Length];
        Array.Copy(a.Elements, combinedArray, a.Elements.Length);
        Array.Copy(b.Elements, 0, combinedArray, a.Elements.Length, b.Elements.Length);

        return new GenericArray<T>(combinedArray);
    }


    public void Display()
    {
        Console.WriteLine("Элементы: " + string.Join(", ", Elements));
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        GenericArray<int> intArray1 = new GenericArray<int>(new int[] { 1, 2, 3 });
        GenericArray<int> intArray2 = new GenericArray<int>(new int[] { 4, 5, 6 });


        GenericArray<int> resultIntArray = intArray1 + intArray2;
        resultIntArray.Display();

    }
}
