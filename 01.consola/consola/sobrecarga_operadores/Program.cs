using System;

namespace sobrecarga_operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Punto miPunto = new Punto(200, 50);
            miPunto = +miPunto;

            Console.WriteLine($"X: {miPunto.X} Y: {miPunto.Y}");

            miPunto = +miPunto;
            miPunto = +miPunto;
            miPunto = +miPunto;

            Console.WriteLine($"X: {miPunto.X} Y: {miPunto.Y}");

            Console.ReadLine();
        }
    }
}
