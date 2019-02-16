using System;
namespace PropertyTest{
    class Emp : Object {
        //자동구현속성, Property
        public int Empno  {    get;    set;    }        
        public override string ToString() {
            return $"[사원 : {Empno}]";
        }
    }
    class EmpTest {
        static void Main(string[] args) {
            Emp e = new Emp();  e.Empno = 999;
            Console.WriteLine(e.Empno);
            Console.WriteLine(e);
            Console.WriteLine(e.ToString());
        }
    }
}
