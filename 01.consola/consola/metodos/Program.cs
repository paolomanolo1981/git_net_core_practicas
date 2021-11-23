using System;

namespace metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase clase = new Clase();
            clase.Calcular(18);
            Console.WriteLine(clase.Sumar(1, 6));
            Console.ReadLine();
        }
    }
}
