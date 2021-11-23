using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractas_virtuales
{
    public abstract  class Clase : ClaseAbstracta
    {
        public override int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public abstract override int Restar(int numero1, int numero2);
    }
}
