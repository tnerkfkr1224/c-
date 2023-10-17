using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyRectangel : Shape
    {
        private int _width, _height;

        public MyRectangel() :this(Color.Green,0,0,100,100)
        {
        }

        public MyRectangel(Color clr,float x,float y,int width,int height):base(clr)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public override void Draw()
        {
            if (Selected) DrawOutline();
            SplashKit.FillRectangle(Color, X, Y, Width, Height);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(SplashKit.ColorBlack(), X - 2, Y - 2, _width + 4, _height + 4);
        }

        public override bool IsAt(Point2D pt)
        {
            if ((((pt.X >= X) && (pt.X <= (X + _width))) && (pt.Y >= Y) && (pt.Y <= (Y + _height))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
        
        
    
}
