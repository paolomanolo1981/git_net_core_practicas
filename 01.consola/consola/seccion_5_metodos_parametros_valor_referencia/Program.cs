using System;
using static System.Console;
namespace seccion_5_metodos_parametros_valor_referencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 25;
            int numero2 = 5;
            WriteLine(numero1);
            CambiarXValor(numero1);
            WriteLine(numero1);
            CambiarXReferencia(ref numero1);
            WriteLine(numero1);

            CambiarXDosValores(ref numero1,ref numero2);
            WriteLine(numero1 + "+" + numero2);

        }

        public static void CambiarXValor(int numero1)
        {
            numero1 = 10;
        }

        public static void CambiarXReferencia(ref int numero)
        {
            numero = 10;
        }

        public static void CambiarXDosValores(ref int numero1, ref int numero2)
        {
            numero1 = 20;
            numero2 = 30;
        }
    }
}
