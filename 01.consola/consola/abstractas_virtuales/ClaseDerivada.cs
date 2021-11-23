using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractas_virtuales
{
    public class ClaseDerivada : Clase
    {
        public override int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}
