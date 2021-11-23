using System;

namespace niveles_acceso
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseBase claseBase = new ClaseBase();
           // claseBase.Edad = 5;

            ClaseHereda claseHereda = new ClaseHereda();
            claseHereda.Nacionalidad = "peruana";
            claseHereda.Nombres = "Paolo";
            claseHereda.Telefono = "999966653";
            Console.WriteLine("Hello World!");

            //claseHereda.
        }
    }
}
