using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propiedades
{
    public class Clase
    {
        public int Campo;
        public string Nombre { get; set; }
        public string Apellidos{ get; set; }
        public int Edad { get; private set; }
        public int Estado = 1;
        public readonly string identificador;

        public Clase()
        {
            identificador = "ABCD";
            Edad = 21;
        }

        public void Metodo(int edad)
        {
            Edad = edad;
            //identificador = "XXX";
        }

    }
}
