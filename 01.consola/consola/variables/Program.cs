using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mensaje = Console.ReadLine();
            string hola;
            int edad = default(int);
            int? altura=null;
            bool verdadero=default(bool);

            if(altura == null)
            {
                //hacer algo
            }
            DateTime? fecha =new DateTime();
            fecha = null;
            int? dia = fecha?.Day;


            edad = edad + 5;
            Console.WriteLine(edad);
            Console.WriteLine(verdadero);
            Console.WriteLine(fecha);
            Console.WriteLine(dia);
            Console.ReadLine();

            var variable = edad + "Hola";


        }
    }
}
