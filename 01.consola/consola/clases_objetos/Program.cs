using System;

namespace clases_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CuentaBancaria cuenta = new CuentaBancaria();
            cuenta.Saldo = 1500;

            CuentaBancaria cuenta2 = new CuentaBancaria();
            cuenta2.Saldo = 2200;

            int suma = cuenta.Saldo + cuenta2.Saldo;

            cuenta.MostrarSaldo(suma);
        }
    }
}
