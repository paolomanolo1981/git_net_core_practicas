using System;
using static System.Convert;

namespace CursoCSharp_3_conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "hola";
            int numero=5;

            cadena = numero.ToString();

            //implicitos
            int numeroEntero = 3457;
            long numeroLong = numeroEntero;


            //explicitos
            double numeroDouble = 12.56;
            int numeroEnteroDouble = (int)numeroDouble;

            Console.WriteLine(numeroEnteroDouble);

            double doubleValor = 8.45;
            int enteroValor = ToInt32(doubleValor);

            //definidos por el usuario

            // con clases de asistentes


        }

         
    }
}
