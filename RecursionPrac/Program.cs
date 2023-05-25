using System;

namespace RecursionPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacei fibo = new Fibonacei();
            //Console.WriteLine(fibo.Get(50));

            FibonaceiAdv fiboadv = new FibonaceiAdv();
            Console.WriteLine(fiboadv.Get(5000));
            
        }
    }
}
