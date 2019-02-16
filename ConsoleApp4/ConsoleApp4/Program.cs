class Adder{
    public int val { get; set; }
    public static Adder operator + (Adder a1, Adder a2)
    {
        Adder a3 = new Adder();
        a3.val = a1.val + a2.val;
        return a3;
    }   
}
class AdderTest{
    static void Main()    {
        Adder a1 = new Adder(); a1.val = 1;
        Adder a2 = new Adder(); a2.val = 1;
        Adder a3 = a1 + a2;
        System.Console.WriteLine($"{a3.val}");
    }
}