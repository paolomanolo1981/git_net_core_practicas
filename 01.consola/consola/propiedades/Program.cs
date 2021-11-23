using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase clase = new Clase();
            clase.Campo = 12;
            clase.Apellidos = "Lopez Serrano";
          //  clase.Edad = 12;

            Console.WriteLine(clase.Edad);
            Console.ReadLine();

            Clase clase2 = new Clase();
            var estado = clase2.Estado;
            clase2.Estado = 5;
            clase2.Metodo(41);
            Console.WriteLine(clase2.Edad);


            Console.ReadLine();
        }
    }
}
