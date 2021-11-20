using System;
using System.Collections.Generic;

namespace polimorfismo_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal a = new Animal();

            Gato gato = new Gato();
            gato.HacerRuido();

            Perro perro = new Perro();
            perro.HacerRuido();


            Lobo lobo= new Lobo();
            lobo.HacerRuido();


            List<Animal> zoo = new List<Animal>();
            zoo.Add(gato);
            zoo.Add(perro);
            zoo.Add(lobo);

            foreach(var animal in zoo)
            {
                animal.HacerRuido();
            }

            Console.ReadLine();
        }
    }
}
