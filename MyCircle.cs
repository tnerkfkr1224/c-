using System;
using System.Runtime.ConstrainedExecution;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyCircle : Shape
    {
        private int _radius;
        
        public MyCircle(Color color,float x,float y,int radius) : base(color)
        {
            X = x;
            Y = y;
            _radius = 50;           
        }

        public MyCircle() :this(Color.Blue,0,0,50)
        {          
        }
       

        public int Radius
        {            
        get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        

        public override void Draw()
        {
            SplashKit.FillCircle(color, X, Y, _radius);
            if (Selected) DrawOurline();
        }

        public override void DrawOurline()
        {
            SplashKit.DrawCircle(Color.Black, X , Y , _radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            return SplashKit.PointInCircle(pt,SplashKit.CircleAt(X, Y, Radius));
        }
    }
}

