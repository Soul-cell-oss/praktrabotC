using System;

public class GenericClass<T>
{

    private T _value;


    public T Value
    {
        get { return _value; }
        set { _value = value; }
    }


    public GenericClass(T initialValue)
    {
        _value = initialValue;
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        GenericClass<int> intInstance = new GenericClass<int>(10);
        Console.WriteLine("Первое значение: " + intInstance.Value);
        intInstance.Value = 20;
        Console.WriteLine("второе значение: " + intInstance.Value);

    }
}
