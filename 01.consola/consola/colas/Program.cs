using System;
using System.Collections;

namespace colas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //FIFO=> primero en entrar, primero en salir 
            Queue cola = new Queue();
            cola.Enqueue(3);
             cola.Enqueue(5);
            cola.Enqueue(1);
            foreach (var c in cola)
            {
                Console.WriteLine("0 " + c);
            }

            //extraer un valor de la cola
            /* var valorCola = cola.Dequeue();
            Console.WriteLine("valorCola " + valorCola);

              valorCola = cola.Dequeue();
            Console.WriteLine("valorCola    " + valorCola);
           */
            //para observar el valor()
            var valor = cola.Peek();
            Console.WriteLine("PEEK "+valor);
            //recorrer cola
            foreach (var c in cola)
            {
                Console.WriteLine("a " + c);
            }



            //comprobar si existe un valor
            if (cola.Contains(5))
            {
                Console.WriteLine("existe 5");
            }else
            {
                Console.WriteLine("no existe 5");
            }

            //borrar valores de la cola
            cola.Clear();
            cola.Enqueue(30);
            cola.Enqueue(50);
            //conocer cuantos elementos hay en la cola
            int elementos = cola.Count;

            //recorrer cola
            foreach(var c in cola)
            {
                Console.WriteLine("e " + c);
            }

            Console.ReadLine();
        }
    }
}
