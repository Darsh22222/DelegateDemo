namespace DelegateDemo
{
    public delegate int operation(int a, int b);

    internal class Program
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            operation obj = new operation(Addition);
            Console.WriteLine("Add is = {0}", obj(23, 22));
            MultiDelegateCast.ImplemrntDeligate();
        }
    }
}
