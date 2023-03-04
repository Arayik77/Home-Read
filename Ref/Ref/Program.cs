namespace Ref
{
    internal class Program
    {

        static void Foo(ref int a)
        {
            a = -5;
        }
        static void Main(string[] args)
        {
            int a = 10;
            Foo(ref a);
            Console.WriteLine(a);
        }
    }
}