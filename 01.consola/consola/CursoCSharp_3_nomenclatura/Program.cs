using System;

namespace CursoCSharp_3_nomenclatura
{
    class Program
    {
        private readonly string _estaEsMiCadena;


        static void Main(string[] args)
        {
            // camel case
            var estoEsUnaVariable ="Camel";

            //pascal
            var EstoEsUnaVariable = "Pascal";
            


        }

        public int SumaDosNumeros(int numeroUno, int numeroDos)
        {
            var resultado = numeroUno + numeroDos;
            return resultado;

        }
        //mal
        public int Sumar(int a,int b)
        {
            var c = a + b;
            return c;

        }
    }
}
