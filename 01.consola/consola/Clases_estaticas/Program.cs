using System;

namespace Clases_estaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            var instancia1 = new ClassConInstancia();
            instancia1.InstanceProperty = 1;

            var instancia2 = new ClassConInstancia();
            instancia2.InstanceProperty = 2;

            instancia1.InstanceMethod();
            instancia2.InstanceMethod();

            var f1 = FibonacciNumberCalculator.GetFibonacciNumber(8);
            var f2 = FibonacciNumberCalculator2.GetFibonacciNumber2(12);

            Console.ReadLine();
        }
    }

    public class ClassConInstancia
    {
        public int InstanceProperty { get; set; }
        public void InstanceMethod()
        {
            Console.WriteLine($"Property value: {InstanceProperty}");

        }
    }

    public class FibonacciNumberCalculator
    {
       
        public static int GetFibonacciNumber(int n)
        {
            Console.WriteLine($"Property value para f1: {n}");
            return n;
        }
           

        
    }

    public static class FibonacciNumberCalculator2
    {

        public static int GetFibonacciNumber2(int n)
        {
            Console.WriteLine($"Property value para f2: {n}");
            return n;
        }



    }
}
