using System;
using static System.Console;
namespace CursoCSharp_3_operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("hay " + args.Length + " elementos");

            int[] arrayEnteros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arrayEnteros2 = new int[5];

            int[] arrayEnteros3 ;

            int[,] arrayDeEnteros2Dimensiones = new int[2, 2];
            int[,] arrayDeEnteros2Dimensiones2 = { { 2,2},{ 3, 6 } };
            int[][] arrayDeEnterosEscalonados = new int[6][];
             arrayDeEnterosEscalonados[0]= new int[4] { 3,6,7,2};
            arrayDeEnterosEscalonados[1] = new int[2] { 1,3 };


            for (int i = 0; i < arrayEnteros.Length; i++)
            {
                Console.WriteLine(arrayEnteros[i]);
            }
        }
    }
}
