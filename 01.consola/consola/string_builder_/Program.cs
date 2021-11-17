using System;
using System.Text;

namespace string_builder_
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder("Hola soy Batman");

            sb.Append("Hola soy Batman");
            sb.Append("y vivo en gothan");

            Console.WriteLine(sb);

            sb2.AppendLine(" Y VIVO EN GOTHAM");
            sb2.AppendFormat("actualmente {0: dd-mm-yyyy}", DateTime.Now);

            Console.WriteLine(sb2);

            if (sb.Capacity>1)
            {

            }
            if (sb2.Length > 1)
            {

            }

            Console.WriteLine("Hello World!");
        }
    }
}
