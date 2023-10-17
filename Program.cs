
using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            
            Drawing mydraw = new Drawing();

            Window window = new Window("Shape Drawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape myShape = new Shape();
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                    mydraw.AddShape(myShape);
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    mydraw.Background = SplashKit.RandomColor();                   
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    mydraw.SelectShapesAt(SplashKit.MousePosition());
                }

                if (SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in mydraw.SelectedShapes)
                    {
                        mydraw.RemoveShape(s);
                    }
                }

                mydraw.Draw();
                SplashKit.RefreshScreen();
            }

            while (!window.CloseRequested);
        }
    }
}

