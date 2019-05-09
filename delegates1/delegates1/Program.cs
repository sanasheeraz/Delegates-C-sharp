using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates1
{
    class Program
    {
        public delegate void Calculator(int a, int b);
        public delegate void Calculator1(int a, int b);
        public static void add(int a, int b)
        {
            Console.WriteLine("Add : " + (a + b));
        }

        public static void sub(int a, int b)
        {
            Console.WriteLine("Sub: " + (a - b));
        }

        public static void mul(int a, int b)
        {
            Console.WriteLine("Mul : " + (a * b));
        }

        public static void div(int a, int b)
        {
            Console.WriteLine("Divide : " + (a / b));
        }
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator(add);
            //calculator(2, 4);
            calculator += new Calculator(sub);
            calculator += new Calculator(mul);
            calculator += new Calculator(div);
            calculator(4, 2);

            Calculator1 cal=delegate(int a,int b){Console.WriteLine(a+b);};
            cal(2,3);
            Console.ReadKey();
        }
    }
}
