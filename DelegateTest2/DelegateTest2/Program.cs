using System;
namespace ConsoleApplication11{
    class Program    {
        delegate int Calc(int i, int j);
        static void Main(string[] args)        {
            Calc c1 = (i, j) => i + j;
            Console.WriteLine("3+4={0}", c1(3, 4));
        }
    }
}