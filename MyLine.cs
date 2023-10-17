using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyLine :Shape
    {
        private float _endX, _endY;

        public MyLine() : this(Color.Blue)
        {
        }

        public MyLine(Color clr) : base(clr)
        {

            _endX = 50;
            _endY = 50;
        }

        public float EndX
        {
            get
            {
                return _endX;
            }
            set
            {
                _endX = value;
            }
        }

        public float EndY
        {
            get
            {
                return _endY;
            }
            set
            {
                _endY = value;
            }
        }

        public  override void Draw()
        {
            SplashKit.DrawLine(color, X, Y, _endX, _endY);
            if (Selected)
            {
                DrawOurline();
            }
        }

        public override void DrawOurline()
        {
            SplashKit.DrawCircle(Color.Black, X, Y, 3);
            SplashKit.DrawCircle(Color.Black, EndX, EndY, 3);
        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointOnLine(pt, SplashKit.LineFrom(X,Y,EndX,EndY));
        }
    }
}