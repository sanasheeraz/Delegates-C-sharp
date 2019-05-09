using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Math(int value);
namespace delegateComposite
{
    class Program
    {
        public static void  EvenNumber(int value)
        {
            Console.WriteLine("Even Numbers : ");
            for(var i=2;i<value;i+=2)
            {
                Console.WriteLine(i);
            }
        }

        public void OddNumber(int value)
        {
            Console.WriteLine("Odd Numbers : ");
            for (var i = 1; i < value; i += 2)
            {
                Console.WriteLine(i);
            }
        }


        static void Start(int num)
        {
            Program compositeDelegate = new Program();
            Math One = new Math(EvenNumber);
            Math Two = new Math(compositeDelegate.OddNumber);
            Math objComposite = (Math)Delegate.Combine(One, Two);
            objComposite(num);
            Console.WriteLine();
            Object obj = objComposite.Method.ToString();
            if(obj!=null)
            {
                Console.WriteLine("The delegate invokes an instance method : " + obj);
            }
            else
            {
                Console.WriteLine("The delegate invokes only static methods " );
            }


        }
        static void Main(string[] args)
        {
            int value = 0;
            Console.WriteLine("Enter any value till which you want to display Even and Odd Numbers : ");

            try
            {
                value = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException e)
            {
                Console.WriteLine("Error : " + e);
            }
            Start(value);
            Console.ReadKey();
        }
    }
}
