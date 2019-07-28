using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;

namespace _2dWrapper
{
    class Window
    {
        public void Run()
        {
            var mode = new SFML.Window.VideoMode(600, 600);
            var window = new SFML.Graphics.RenderWindow(mode, "Point Wrapper");
            window.KeyPressed += Window_KeyPressed;

            while (window.IsOpen)
            {
                window.DispatchEvents();
                //window.Draw();
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
        

        
    }
}
