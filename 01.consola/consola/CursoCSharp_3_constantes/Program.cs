using System;

namespace CursoCSharp_3_constantes
{
    class Program
    {
        public const string NOMBRE="Pedro";
        public const int NUMERO_PEDIDO_MAXIMOS = 10;

        static void Main(string[] args)
        {
            for(int i = 0; i < 12; i++)
            {
                if (i < NUMERO_PEDIDO_MAXIMOS)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
