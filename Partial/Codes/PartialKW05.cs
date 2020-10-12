using System;
using System.Collections.Generic;
using System.Text;

namespace PartialKW.Codes
{
    class PartialKW05
    {
        internal partial struct Struct01
        {
            public Struct01(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
        internal partial struct Struct01
        {
            public double X { get; }
            public double Y { get; }

            public override string ToString() => $"({X}, {Y})";
        }


        /*public struct Coords
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }

            public override string ToString() => $"({X}, {Y})";
        }*/
    }
}
