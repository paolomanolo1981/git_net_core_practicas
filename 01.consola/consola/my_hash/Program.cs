using System;
using System.Collections;

namespace my_hash
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Hashtable hash = new Hashtable();

            hash.Add("Alejandro", 1.22);
            hash.Add("Rodrigo", 5.21);
            hash.Add("Mirima", 9.62);

            //recorriendo el hashtable
            foreach(DictionaryEntry item in hash)
            {
                Console.WriteLine($"item: {item.Key} valor: {item.Value}"  );
            }

            var valor = hash["Alejandro"];
            Console.WriteLine("VALOR " + valor);

            //contar
            var total = hash.Count;
            Console.WriteLine("total " + total);
            if (hash.ContainsKey("Alejandro"))
            {
                Console.WriteLine("Alejandro " );
            }

            if (hash.ContainsValue(5.21))
            {
                Console.WriteLine("5.21 ");
            }

            //7/eliminar
            hash.Remove("Alejandro");
            //recorriendo el hashtable
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine($"Eliminado:=> item: {item.Key} valor: {item.Value}");
            }

            //limpiar 
            hash.Clear();
        }
    }
}
