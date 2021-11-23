using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractas_virtuales
{
    public abstract class ClaseAbstracta
    {
        public abstract int Sumar(int numero1, int numero2);
        public virtual int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}
