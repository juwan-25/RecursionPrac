using System;

namespace RecursionPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacei fibo = new Fibonacei();
            Console.WriteLine(fibo.Get(1));
            Console.WriteLine(fibo.Get(2));
            Console.WriteLine(fibo.Get(3));
            Console.WriteLine(fibo.Get(4));
            Console.WriteLine(fibo.Get(5));
            
        }
    }
}
