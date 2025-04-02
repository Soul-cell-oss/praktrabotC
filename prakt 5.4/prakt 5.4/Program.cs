using System;

public class GenericArray<T>
{

    private T[] _elements;


    public GenericArray()
    {
        _elements = new T[0]; 
    }


    public void Add(T element)
    {
 
        T[] newArray = new T[_elements.Length + 1];
        Array.Copy(_elements, newArray, _elements.Length);
        newArray[^1] = element; 

        _elements = newArray; 
    }


    public void Remove(int index)
    {
        if (index < 0 || index >= _elements.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Индекс вне диапазона.");
        }


        T[] newArray = new T[_elements.Length - 1];
        for (int i = 0, j = 0; i < _elements.Length; i++)
        {
            if (i != index)
            {
                newArray[j++] = _elements[i]; 
            }
        }

        _elements = newArray; 
    }


    public T Get(int index)
    {
        if (index < 0 || index >= _elements.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Индекс вне диапазона.");
        }

        return _elements[index]; 
    }


    public int Length()
    {
        return _elements.Length; 
    }


    public void Display()
    {
        Console.WriteLine("Элементы:" + string.Join(", ", _elements));
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        GenericArray<int> intArray = new GenericArray<int>();
        intArray.Add(1);
        intArray.Add(2);
        intArray.Add(3);
        intArray.Display();

        intArray.Remove(1); 
        intArray.Display();

        Console.WriteLine("Элемент с индексом 1: " + intArray.Get(1));
        Console.WriteLine("Длина: " + intArray.Length());
    }
}
