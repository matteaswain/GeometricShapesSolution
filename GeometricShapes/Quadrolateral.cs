using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Quadrolateral
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public int SideD { get; set; }

        public int  Parameter()
        {
           return SideA + SideB + SideC + SideD;
            

        }

    }
}
