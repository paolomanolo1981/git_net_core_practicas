using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    public class Clase
    {
        public int Campo;
        public string Nombre { get; set; }
        public readonly string identificador = "XX";

        public Clase()
        {

        }

        //metodo
        public void Calcular(int edad)
        {
            //operación de nuestro método
            Console.WriteLine(edad + 15);
        }

        public int Sumar(int numero1 , int numero2)
        {
            return numero1 + numero2;
        }
    }
}
