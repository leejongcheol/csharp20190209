using System;
delegate int SumDeli(int i, int j);
class DeliTest
{
    static void Main()
    {
        S(Sum1); S(Sum2);
    }
    //아래 메소드는 실제 할일(콜백)이 컴파일 타임에 결정되는 것이 아니라 런타임중에
    //인자로 넘어오는 델리게이트를 통해 결정된다. 이런 콜백의 구현은 델리게이트로
    static void S(SumDeli s)
    {
        Console.WriteLine(s(1, 2));
    }
    static int Sum1(int i, int j)
    {
        return i + j;
    }
    static int Sum2(int i, int j)
    {
        return i + j + 100;
    }
}