using System;

namespace concatenar_cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string superHeroe = "superman";
            string procedencia = "kripton";
            string superPoder = "super fuerza";

            string todos = superHeroe + " " + procedencia + " " + superPoder;
            string todosConcat = string.Concat(superHeroe," ", procedencia," ",superPoder);

            string todosInteropolacion = $"{superHeroe} procede de {procedencia} y tiene {superPoder}";// (superHeroe, " ", procedencia, " ", superPoder);
            string ejemploInterpolacion = $"{3+5} es igual a 8?";

            Console.WriteLine(todos);
            Console.WriteLine(todosConcat);
            Console.WriteLine(todosInteropolacion);
            Console.WriteLine(ejemploInterpolacion);
        }
    }
}
