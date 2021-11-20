using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo_08
{
    public class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Hace miauuuuu");
        }
    }
}
