using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rectangle
    {
        public int Length { get; set; }
        public int Side { get; set; }

        public int Area()
        {
            return Length * Side;
        }
    }
}
