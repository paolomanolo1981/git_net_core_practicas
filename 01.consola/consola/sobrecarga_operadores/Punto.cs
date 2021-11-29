using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecarga_operadores
{
    public class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto()
        {
            X = 0;
            Y = 0;
        }

        public Punto(int x , int y)
        {
            X = x;
            Y = y;
        }

        //sobrecarga_operador
        public static Punto operator +(Punto punto)
        {
            Punto nuevoPunto = new Punto();
            nuevoPunto.X = punto.X + 1;
            nuevoPunto.Y = punto.Y + 1;
            return nuevoPunto;
        }

        public static Punto operator -(Punto punto)
        {
            Punto nuevoPunto = new Punto();
            nuevoPunto.X = punto.X - 1;
            nuevoPunto.Y = punto.Y - 1;
            return nuevoPunto;
        }


    }
}
