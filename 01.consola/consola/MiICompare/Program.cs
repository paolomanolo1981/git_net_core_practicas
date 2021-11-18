using System;
using System.Collections.Generic;

namespace MiICompare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<Persona> personas = new List<Persona>()
            {
                new Persona(){nombre="elena", edad=50},
                new Persona(){nombre="katty", edad=41},
                new Persona(){nombre="paolo", edad=40},
                new Persona(){nombre="manuel", edad=60},
               new Persona(){nombre="jimmy", edad=40}


            };
            foreach(Persona obj in personas)
            {
                Console.WriteLine(obj.nombre + " edad: " + obj.edad);
            }

            personas.Sort();

            Console.WriteLine("==========================");
            foreach (Persona obj in personas)
            {
                Console.WriteLine(obj.nombre + " edad: " + obj.edad);
            }
            Console.ReadLine();
        }

        
    }

    public class Persona : IComparable
    {
        public string nombre { get; set; }
        public int edad { get; set; }

        public int CompareTo(object obj)
        {
            Persona objTemporal = (Persona)obj;
           
            if(this.edad>objTemporal.edad)
            {
                return 1;
            }
            if (this.edad < objTemporal.edad)
            {
                return -1;
            }
            return 0;
        }
    }
}
