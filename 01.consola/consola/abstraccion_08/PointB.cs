using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraccion_08
{
    public class PointB
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        

        public void SetX(int x)
        {
            if (x < 100)
            {
                X = x;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void SetY(int y)
        {
            if (y > 50)
            {
                Y= y;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }


    }
}
