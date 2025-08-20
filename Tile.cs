using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace GADE_1B_POE
{
  
    public abstract class Tile
    {
        private Position pos;

        private int X { get; set; }
        private int Y { get; set; }

        public abstract char Display {  get; }

        public Tile(Position p)
        {
            pos = p;
        }


    }
}
