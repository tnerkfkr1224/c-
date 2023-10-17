using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }

        public static void Main()
        {
            
            Window window = new Window("Shape Drawer", 800, 600);
            Drawing mydraw = new Drawing();
            ShapeKind kindToAdd=ShapeKind.Circle;

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();


                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }

                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }

                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;

                    if(kindToAdd ==ShapeKind.Circle)
                    {
                        MyCircle newCircle = new MyCircle();                       
                        newShape = newCircle;
                    }

                    else if (kindToAdd == ShapeKind.Rectangle)
                    {
                        MyRectangel newRect = new MyRectangel();                        
                        newShape = newRect;
                    }

                    else
                    {
                        MyLine newLine = new MyLine();
                        newShape = newLine ;
                    }


                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
                    mydraw.AddShape(newShape);
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    mydraw.SelectShapesAt(SplashKit.MousePosition());
                }


                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    mydraw.Background = SplashKit.RandomColor();
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
