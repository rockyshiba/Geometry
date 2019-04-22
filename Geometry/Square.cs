using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square
    {
        public int Side { get; set; }

        /// <summary>
        /// Calculates area of this square
        /// </summary>
        /// <returns>Area as an integer</returns>
        public int Area()
        {
            return Side * 2;
        }
    }
}
