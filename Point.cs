using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SFML.System;
using SFML.Graphics;

namespace _2dWrapper
{
    public class Point
    {
        public Vector2f PointVector { get; set; }
        public CircleShape PointShape { get; set; }



        //Point(int x, int y)
        //{

        //}
        public Point(float x, float y)
        {
            PointVector = new Vector2f(x, y);
            PointShape = new CircleShape(2);
            PointShape.Position = PointVector;
            PointShape.FillColor = Color.White;
            
        }
        //Point(FileStream fileOfPoints)
        //{

        //}
    }
}
