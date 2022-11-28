using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class MultiDelegateCast
    {
        public delegate int DelOp(int x, int y);
        public static void ImplemrntDeligate()
        {
            DelOp obj = Operation.Add;
            obj += Operation.Square;
            obj(5, 5);
            obj(8, 3);
        }
        public class Operation
        {
            public static int Add(int a, int b)
            {
                Console.WriteLine("Addition = {0}", a+b);
                return (a + b);
            }
            public static int Square(int a, int b)
            {
                Console.WriteLine("Multiple = {0}", a + b);
                return (a + b);
            }
        }
    }
}
