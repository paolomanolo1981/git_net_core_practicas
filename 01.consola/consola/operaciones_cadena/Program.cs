using System;

namespace operaciones_cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            string villano = "gru";
            string esbirros = "Minions";
            string frase = "los minions ayudan a gru a conquistar el mundo";

            string concatenarCadenas = String.Concat(villano, " tiene ", esbirros);



            Console.WriteLine(concatenarCadenas);
           

            if (villano.Contains("gru"))
            {

            }

            if (villano.Contains("Min"))
            {

            }

            string subfrase = frase.Substring(14, 8);
            Console.WriteLine(subfrase);

            //cadena q acaba
            if(frase.EndsWith("mundo"))
            {

            }
            //insertar una cadena
            var frase2=  frase.Insert(3, " adorables");
            Console.WriteLine(frase2);

            //ubicar una posicion
            var posicion = frase.LastIndexOf("mundo");
            var frase3 =  frase.Insert(posicion, " enorme ");

            Console.WriteLine(frase3);


            Console.ReadLine();
        }
    }
}
