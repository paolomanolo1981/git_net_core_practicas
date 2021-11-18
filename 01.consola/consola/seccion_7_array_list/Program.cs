using System;
using System.Collections;

namespace seccion_7_array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            lista.Add(1);
            lista.Add("Batman");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            var elemento = lista[0];
            Console.WriteLine(elemento);

            var elemento1 = lista[1];
            Console.WriteLine(elemento1);

            int total = lista.Count;
            Console.WriteLine(total);

            lista.Insert(1, "SuperMan");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            lista.RemoveAt(1);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
