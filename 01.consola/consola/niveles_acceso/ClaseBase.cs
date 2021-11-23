using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niveles_acceso
{
    public class ClaseBase
    {
        public string Telefono { get; set; }
        private int Edad { get; set; }
        internal string Nombres { get; set; }
        protected string Apellidos { get; set; }
        protected internal string Nacionalidad { get; set; }

        public ClaseBase()
        {
            Edad = 16;
            Apellidos = "Lopez";
        }


        public void Sumar(int a, int b)
        {

        }
    }
}
