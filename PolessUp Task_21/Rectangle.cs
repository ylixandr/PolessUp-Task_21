using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolessUp_Task_21
{
    internal class Rectangle1
    {
        int x1;
        int y1;
        int x2;
        int y2;

        public Rectangle1(int x1 , int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
           
        }

        public int X1
        {
            get { return x1; }
        }

        public int X2
        {
            get { return x2; }
        }

        public int Y1
        { get { return y1; } }

        public int Y2
        { get { return y2; } }

        public double Area
        {
           
            get { return (x2-x1)*(y2-y1);}
        }


    }
}
