public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }

    // Overload the + operator
    public static MyClass operator +(MyClass a, int b)
    {
        return new MyClass(a.MyProperty + b);
    }

    public static MyClass operator +(int a, MyClass b)
    {
        return new MyClass(a + b.MyProperty);
    }
}

public class Example
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int num = obj1;    // Implicit conversion from MyClass to int

        Console.WriteLine(num); // Output: 10

        MyClass obj2 = new MyClass(20);
        MyClass num2 = obj2 + 5; // Correctly uses overloaded operator
        Console.WriteLine(num2.MyProperty); // Output: 25

        MyClass num3 = 5 + obj2; //Correctly uses overloaded operator
        Console.WriteLine(num3.MyProperty); //Output: 25
    }
}