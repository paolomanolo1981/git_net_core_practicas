using System;

namespace abstraccion_08
{
    class Program
    {
        static void MainA(string[] args)
        {
           
            Persona persona = new Persona();

            Point punto = new Point();
            punto.SetX(40);
            punto.SetY(70);
            punto.SetC(90);
            Console.WriteLine(punto.GetX());
            Console.WriteLine(punto.GetY());
            Console.WriteLine(punto.c);

            Console.ReadLine();


        }

        static void Main(string[] args)
        {

            

            HerenciaPoint punto = new HerenciaPoint();
            punto.SetX(40);
            punto.SetY(70);
            punto.SetZ(100);
          
            Console.WriteLine(punto.X);
            Console.WriteLine(punto.Y);
            Console.WriteLine(punto.Z);

            Console.ReadLine();


        }
    }
}
