namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            c3 obj1 = new c3();
            Interface1 obj2 = (Interface1)obj1;
            Interface2 obj3 = (Interface2)obj2;
            obj2.test1();
            obj3.test1();
        }
    }
}
