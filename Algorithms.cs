using System;
using System.Collections.Generic;
using System.Text;

namespace _2dWrapper
{
    public class Algorithms
    {
        public Algorithms()
        {

        }

        public double FindInternalAnglesOfObliqueTriangle(double sideA, double sideB, double sideC)
        {
            //c2 = a2 +b2 - 2ab cosC
            double _2ab;
            double a2b2;
            double cosC;
            double a2;
            double b2;
            double c2;

            if (sideC > sideB && sideC > sideA)
            {
                a2 = sideA * sideA;
                b2 = sideB * sideB;
                c2 = sideC * sideC;

                a2b2 = a2 + b2;
                _2ab = (sideA * 2) * sideB;
                _2ab *= -1;

                //takes out the a2b2
                c2 -= a2b2;
                //takes out the _2ab
                c2 /= _2ab;
                //left with c2 = cosC
                cosC = (Math.Acos(c2) * 180 / Math.PI);
                //c2 is at final angle;
                return cosC;
            }
            else if(sideB > sideC && sideB > sideA)
            {
                return 0.0;
            }
            else
            {
                return 0.0;
            }
        }
    }
}
