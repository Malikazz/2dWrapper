using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;

namespace _2dWrapper
{
    public class Window
    {
        public uint WindowX { get; set; }
        public uint WindowY { get; set; }
        public int MAXDRAWABLEOBJECTS { get; set; }
        SFML.Graphics.Drawable[] drawables;

        private int _indexOfDrawables;
        public Window(uint windowX = 600, uint windowY = 600, int drawableObjectLimit = 200)
        {
            MAXDRAWABLEOBJECTS = drawableObjectLimit;
            drawables = new SFML.Graphics.Drawable[MAXDRAWABLEOBJECTS];
            WindowX = windowX;
            WindowY = windowY;
        }


        Point point = new Point(200, 200);
        public void Run()
        {
            var mode = new SFML.Window.VideoMode(WindowX, WindowY);
            var window = new SFML.Graphics.RenderWindow(mode, "Point Wrapper");
            window.KeyPressed += Window_KeyPressed;

            while (window.IsOpen)
            {
                window.DispatchEvents();
                for(int counter = 0; counter < drawables.Length; counter++)
                {
                    if (drawables[counter] != null)
                    {
                        window.Draw(drawables[counter]);
                    }
                }
                window.Display();
            }
        }

        private void Window_KeyPressed(object sender, SFML.Window.KeyEventArgs e)
        {
            var window = (SFML.Window.Window)sender;
            if(e.Code == SFML.Window.Keyboard.Key.Escape)
            {
                window.Close();
            }
        }
        

        /// <summary>
        /// This will need to be changed if you want drawables to be mutable,
        /// as there is not way to edit the array accuratly besides restarting.
        /// </summary>
        /// <param name="shapeToDraw"></param>
        public void AddToDraw(SFML.Graphics.Drawable shapeToDraw)
        {
            drawables[_indexOfDrawables] = shapeToDraw;
            _indexOfDrawables++;
        }
    }
}
