using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Square
    {

        public int Side { get; set; }

        public int Parameter()
        {
            return Side + Side + Side + Side;
            
        }
        public int Area()
        {
            return Side * Side;
         }

    }
}
