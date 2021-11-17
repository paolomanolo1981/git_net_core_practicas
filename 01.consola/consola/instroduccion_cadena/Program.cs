using System;
using static System.Console;

namespace instroduccion_cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            string miCadena = "";
            string miCadena2 = string.Empty;
            string miCadena3 = "Hola Mundo";

            int numero = 7;
            string Stringnumero= numero.ToString();

            DateTime fecha = new DateTime();
            fecha = DateTime.Now;
            

            WriteLine("ToLocalTime " + fecha.ToLocalTime());
            WriteLine("ToLongDateString " + fecha.ToLongDateString());
            WriteLine("ToLongTimeString " + fecha.ToLongTimeString());
            WriteLine("ToOADate " + fecha.ToOADate());
            WriteLine("ToShortDateString " + fecha.ToShortDateString());
            WriteLine("ToShortTimeString " + fecha.ToShortTimeString());
            WriteLine("ToString " + fecha.ToString());
            WriteLine("ToUniversalTime " + fecha.ToUniversalTime());

            string fechaString = String.Format("La fecha de hoy es {0: dd/MM/yyyy hh:mm:ss}",DateTime.Now);

            Console.WriteLine(fechaString);
        }
    }
}
