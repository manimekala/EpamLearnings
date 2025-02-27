using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class Sample
    {
        abstract public int SumNumbers(int a, int b);
        public virtual int SubtractNumbers(int a, int b)
        {
            return a - b;
        }

    }
    interface ICheckArithmeticOps
    {
       int MultiplyNumbers(int m,int n);
        int DivideNumbers(int j, int k);
    }
    class Program : Sample,ICheckArithmeticOps
    {
    
        override public int SumNumbers(int a, int b)
        {
            return a + b;
        }
        override public int SubtractNumbers(int a,int b)
        {
            return b - a;
        }

         public int MultiplyNumbers(int m,int n)
        {
            return m * n;
        }
       public int DivideNumbers(int j,int k)
        {
            int result=0;
            try
            {
               result = j / k;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Test Solution");
            Program p = new Program();
           
            int sum = p.SumNumbers(10, 20);
            Console.WriteLine(sum);
            int sub = p.SubtractNumbers(30, 40);
            Console.WriteLine(sub);
            int mul = p.MultiplyNumbers(3, 9);
            Console.WriteLine(mul);
            int div = p.DivideNumbers(1, 0);
            Console.WriteLine(div);
            int actualDiv = p.DivideNumbers(6, 2);
            Console.WriteLine(actualDiv);
            
        }
    }
}
