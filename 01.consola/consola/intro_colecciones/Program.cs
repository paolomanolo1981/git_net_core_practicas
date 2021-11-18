using System;
using System.Collections.Generic;

namespace intro_colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car(){Name="car 1",Color="blue",Speed=20},
                new Car(){Name="car 2",Color="red",Speed=50},
                new Car(){Name="car 3",Color="green",Speed=10},
                new Car(){Name="car 4",Color="blue",Speed=50},
                 new Car(){Name="car 5",Color="blue",Speed=30},
                  new Car(){Name="car 6",Color="red",Speed=60},
                   new Car(){Name="car 7",Color="green",Speed=50},
            };
            cars.Sort();
            foreach(Car thisCar in cars)
            {
                Console.Write(thisCar.Color.PadRight(5) + " ");
                Console.Write(thisCar.Speed.ToString() + " ");
                Console.Write(thisCar.Name);
                Console.WriteLine();

            }
        }
    }

    public class Car : IComparable<Car>
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public int CompareTo(Car other)
        {
            //  throw new NotImplementedException();
            int compare;
            compare = String.Compare(this.Color, other.Color, true);
            if(compare==0)//los colores son iguales
            {
                compare = this.Speed.CompareTo(other.Speed);
                //usa de manera descendente el orden de la velocidad
                compare = -compare;
            }

            return compare;
        }
    }
}
