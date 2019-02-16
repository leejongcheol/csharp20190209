using System;
namespace ConsoleApplication11{
    class Program    {
        static void Main(string[] args)        {
            Func<int, int,  int> c3 = (a, b) => a + b;
            Console.WriteLine("3+4={0}", c3(3, 4));
        }
        static int MySum(int i, int j)        {
            return i + j;
        }
    }
}