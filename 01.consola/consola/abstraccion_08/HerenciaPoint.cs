using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraccion_08
{
    public class HerenciaPoint:PointB, IEjemplo
    {
        public int Z { get; private set; }
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SetZ(int valor) {
            Z = valor;
        }
    }
}
