using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A星寻路算法
{
    public class Grid
    {
        public int x;
        public int y;
        public int f;
        public int g;
        public int h;
        public Grid parent = null;
        public Grid(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void initGrid(Grid parent, Grid end)
        {
            this.parent = parent;
            if (parent != null)
            {
                this.g = parent.g + 1;
            }
            else
            {
                this.g = 1;
            }
            this.h = Math.Abs(this.x - end.x) + Math.Abs(this.y - end.y);
            this.f = this.g + this.h;
        }
    }
}