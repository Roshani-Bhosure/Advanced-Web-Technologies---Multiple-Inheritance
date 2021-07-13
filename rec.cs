using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class rec:shape, cost
    {
        public rec(int a, int b) : base(a, b) { }
        public int getarea()
        {
            return height * width;
        }
        public int getcost(int a)
        {
            return a * 30;
        }
    }
}
