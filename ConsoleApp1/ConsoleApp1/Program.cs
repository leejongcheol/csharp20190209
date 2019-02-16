using System;
namespace ConsoleApp1
{
    class Emp  {
        public int empno;
        public void GotoOffice()  {
            Console.WriteLine($"[{empno}]출근");
        }
    }
    class EmpTest    {
        static void Main(string[] args)   {
            Emp e = new Emp();
            e.GotoOffice();
        }
    }
}
