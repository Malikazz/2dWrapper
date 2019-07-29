using System;

namespace _2dWrapper
{
    class Program
    {
        static Random rng = new Random();

        static void Main(string[] args)
        {
            Point[] points = new Point[200];
           
            var window = new Window();
            for (int counter = 0; counter < 100; counter++)
            {
                points[counter] = new Point(rng.Next(20,(int)window.WindowX - 20), rng.Next(20,(int)window.WindowY - 20));
                window.AddToDraw(points[counter].PointShape);
            }
            window.Run();

            
        }
    }
}
