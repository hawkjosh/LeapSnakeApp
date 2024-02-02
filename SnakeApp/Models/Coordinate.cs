using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp.Models
{
    public class Coordinate
    {
        private int x; private int y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
       
    }



}
