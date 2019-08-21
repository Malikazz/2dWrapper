using System;
using System.Collections.Generic;
using SFML.System;
using System.Text;

namespace _2dWrapper
{
    public class Algorithms
    {
        public Algorithms()
        {

        }

        public void JarvisMatch(Point[] points)
        {
            Vector2f leftMostPoint;
        }


        //public double[] FindInternalAnglesOfObliqueTriangle(double sideA, double sideB, double sideC)
        //{
        //    // a / b / c
        //    double[] angles = new double[3];
        //    //c2 = a2 +b2 - 2ab cosC
        //    double _2ab;
        //    double a2b2;
        //    double cosC;
        //    double a2;
        //    double b2;
        //    double c2;
        //    double sinA;
        //    double sinB;
        //    double sinC;
        //    a2 = sideA * sideA;
        //    b2 = sideB * sideB;
        //    c2 = sideC * sideC;

        //    if (sideC > sideB && sideC > sideA)
        //    {


        //        a2b2 = a2 + b2;
        //        _2ab = (sideA * 2) * sideB;
        //        _2ab *= -1;

        //        //takes out the a2b2
        //        c2 -= a2b2;
        //        //takes out the _2ab
        //        c2 /= _2ab;
        //        //left with c2 = cosC
        //        cosC = (Math.Acos(c2) * 180 / Math.PI);
        //        //c2 is at final angle;
        //        angles[2] = cosC;
        //        sinA = Math.Asin((Math.Sin(cosC) * sideA) / sideC);
        //        angles[0] = sinA;
        //        angles[1] = 180 - (angles[0] + angles[2]);
        //        if (angles[0] + angles[1] + angles[2] > 180)
        //        {
        //            Console.WriteLine("Angles added upto over 180 error");
        //        }
        //        return angles;

        //    }
        //    else if(sideB > sideC && sideB > sideA)
        //    {
        //        a2b2 = a2 + c2;
        //        _2ab = (sideA * 2) * sideC;
        //        _2ab *= -1;

        //        //takes out the a2b2
        //        c2 -= a2b2;
        //        //takes out the _2ab
        //        c2 /= _2ab;
        //        //left with c2 = cosC
        //        cosC = (Math.Acos(c2) * 180 / Math.PI);
        //        //c2 is at final angle;
        //        angles[1] = cosC;
        //    }
        //    else
        //    {
        //        a2b2 = c2 + b2;
        //        _2ab = (sideC * 2) * sideB;
        //        _2ab *= -1;

        //        //takes out the a2b2
        //        c2 -= a2b2;
        //        //takes out the _2ab
        //        c2 /= _2ab;
        //        //left with c2 = cosC
        //        cosC = (Math.Acos(c2) * 180 / Math.PI);
        //        //c2 is at final angle;
        //        angles[0] = cosC;
        //    }
        //}
    }
}
