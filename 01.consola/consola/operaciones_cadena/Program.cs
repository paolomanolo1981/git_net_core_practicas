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

            //borrar cadena
            var posicion2 = frase3.LastIndexOf("enorme");
            var frase4= frase3.Remove(posicion2, 7);

            Console.WriteLine(frase4);


            //reemplazar cadena
            var frase5 =  frase.Replace("mundo", "luna");
            Console.WriteLine(frase5);


            //dividir cadena
            var palabras = frase.Split(" ");
            foreach(var palabra in palabras)
            {
                Console.WriteLine(palabra);
            }


            //mayusculas y minuscula
            string GRU = villano.ToUpper();
            string esbirros2 = esbirros.ToLower();
            Console.WriteLine(GRU);
            Console.WriteLine(esbirros2);

            //podar cadenas
            string espaciosDelanteros = "   palabras";
            string espaciosFinales = "palabras finales     ";
            string espacios  = "     palabras finales     ";

            Console.WriteLine(espaciosDelanteros.TrimStart() +  "-");
            Console.WriteLine(espaciosFinales.TrimEnd() + "-");
            Console.WriteLine(espacios.Trim() + "-");

            Console.ReadLine();
        }
    }
}
