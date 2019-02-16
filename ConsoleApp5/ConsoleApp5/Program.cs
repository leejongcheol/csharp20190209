using System;
public class Delegate1{
    public static void Main(string[] args)    {
        Action<int, int> myMethod =Sum;
        myMethod.Invoke(10, 30);
        myMethod(10, 30);        
    }
    static void Sum(int i, int j)
    {
        Console.WriteLine(i + j);
    }
}