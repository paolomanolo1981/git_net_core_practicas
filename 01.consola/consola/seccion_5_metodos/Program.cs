using System;

namespace seccion_5_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            EstoEsUnMetodo();
            Console.WriteLine( Saludo("paolo", "pecho"));
            Console.WriteLine(FuncionSinParametros());
        }

        public static void EstoEsUnMetodo()//solo ejecutan código
        {
            //codigo del método
            Console.WriteLine("Aqui soy un método");

        }
        
        //no le pasan parámetros y devuelve valor
        public static int FuncionSinParametros()
        {
            return 66;
        }

        //se le pasan parámetros y devuelve valor
        public static int FuncionConParametros(int valor)
        {
            return valor;
        }

        //devuelve valor y recibe parametros
        public static string Saludo(string nombres,string apellidos)
        {
            //codigo de la función
            return "Mi nombre es: " + nombres + " " + apellidos;
        }

         
        
    }
}
