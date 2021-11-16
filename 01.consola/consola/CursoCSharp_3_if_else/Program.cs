using System;

namespace CursoCSharp_3_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bandera = true;
            if(bandera)
            {

            }
            else
            {

            }

            if(bandera.GetType()==typeof(bool)) 
            {
                Console.WriteLine("tipo");
            }else
            {
                Console.WriteLine("NO tipo");
            }
        }
    }
}
