using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_datos
{
    public class Constantes
    {
        //constantes
        const int IVA = 7;
        const int IVA7 = 7, IVA11=11, IVA21=21;

        private int importe { get; set; }
        public int CalcularImporte(int importe)
        {
            //IVA = 11;
            return importe + (importe * IVA);
        }
    }
}
