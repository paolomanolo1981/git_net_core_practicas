using System;

namespace clases_estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Point punto = new Point();// por referencia
            punto.X = 10;
            punto.Y = 8;

            PointStruct puntoEstructura = new PointStruct();//por valor
            puntoEstructura.X = 20;
            puntoEstructura.Y = 7;

            SumaCoordenadas(punto);
            SumaCoordenadas(puntoEstructura);


            Console.WriteLine($"Suma de coordenadas clase: X={punto.X} Y={punto.Y}");

            Console.WriteLine($"Suma de coordenadas struct: X={puntoEstructura.X} Y={puntoEstructura.Y}");

            Console.ReadLine();
        }

        public static void SumaCoordenadas (Point punto ){
            punto.X = punto.X + 10;
            punto.Y = punto.Y + 10;
        }

        public static void SumaCoordenadas(PointStruct puntoEstructura)
        {
            puntoEstructura.X = puntoEstructura.X + 10;
            puntoEstructura.Y = puntoEstructura.Y + 10;
        }
    }
}
