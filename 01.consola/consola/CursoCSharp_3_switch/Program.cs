using System;

namespace CursoCSharp_3_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 1;
            switch (valor)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;

                default:
                    Console.WriteLine("NInguno");
                    break;
                    
            };

            Console.ReadLine();
        }
    }
}
