using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1B_POE
{
    public class Position
    {
        private int x;
        private int y;

        public int xCoord
        {
            get { return x; }
            set { x = value; }
        }

        public int yCoord
        {
            get { return y; }
            set { y = value; }
        }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
