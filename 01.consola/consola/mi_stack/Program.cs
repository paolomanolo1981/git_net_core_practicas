using System;
using System.Collections;

namespace mi_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack pila = new Stack();

            pila.Push(1);
            pila.Push(5);
            pila.Push(30);
            pila.Push(3);


            foreach(var obj in pila)
            {
                Console.WriteLine(obj);
            }

            if(pila.Contains(30))
            {
                Console.WriteLine($"contiene 30");
            }else
            {
                Console.WriteLine($"NO contiene 30");
            }

            var numero = pila.Pop();
            Console.WriteLine(numero);

            //saber elementos
            int contador = pila.Count;
            Console.WriteLine($"total hay {contador} elementos");

            //limpiar la pila
            pila.Clear();


            Console.ReadLine();

        }
    }
}
