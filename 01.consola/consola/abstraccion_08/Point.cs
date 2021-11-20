using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraccion_08
{
    public class Point
    {
        private int _x;
        private int _y;
        public int c { get; private set; }

        public void SetX(int x)
        {
            if (x < 100)
            {
                _x = x;
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
                _y = y;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int GetX()
        {
            return _x;
        }
        
        public int GetY()
        {
            return _y;
        }

        public void SetC(int value)
        {
            if (value < 100)
            {
                c = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }


    }
}
