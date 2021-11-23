using System;

namespace abstractas_virtuales
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseDerivada o = new ClaseDerivada();

            int valor = o.Restar(67 , 1);
            Console.WriteLine(valor);
            Console.ReadLine();

        }
    }
}
