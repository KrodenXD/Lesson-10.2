using System;

namespace Lesson_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            //Console.WriteLine("Input :");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Factorial of " + a + " = " + methods.Factorial(a));
            Console.WriteLine(methods.Multiply(null,null,null,10));
        }
    }
}
