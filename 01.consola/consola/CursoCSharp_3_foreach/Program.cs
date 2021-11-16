using System;
using System.Collections.Generic;

namespace CursoCSharp_3_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            var listaDeNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var numero in listaDeNumeros)
            {
                Console.WriteLine(numero);
            }  

            var listaPersonas = new List<Persona> {
                new Persona { Nombre = "carlos", Apellido = "Fonseca" },
                new Persona { Nombre = "hector", Apellido = "rivera" }
            };

            
            foreach  (Persona persona in listaPersonas)
            {
                Console.WriteLine(persona.Nombre + " " + persona.Apellido);
            }
            
               

             
        }

       
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }


    }
}
