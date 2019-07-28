using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SFML.System;
using SFML.Graphics;

namespace _2dWrapper
{
    class Point
    {
        public Vector2f PointVector { get; set; }
        public CircleShape PointShape { get; set; }



        //Point(int x, int y)
        //{

        //}
        Point(float x, float y)
        {
            PointVector = new Vector2f(x, y);
            CircleShape circle = new CircleShape(2);
            circle.Position = PointVector;
            circle.FillColor = Color.White;
            
        }
        //Point(FileStream fileOfPoints)
        //{

        //}
    }
}
