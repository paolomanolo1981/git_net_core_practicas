using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_objetos
{
    public class CuentaBancaria
    {
        public int Saldo { get; set; }
        public bool Estado { get; set; }

        public static void Retirada()
        {

        }

        public static void Deposito()
        {

        }

        public   void MostrarSaldo(int saldo)
        {
            Console.WriteLine(saldo);
        }
    }
}
