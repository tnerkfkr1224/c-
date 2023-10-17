using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public abstract class Shape
    {
        private Color _color;
        //Shape's position
        private float _x, _y;     
        private bool _selected;

        public Shape(Color color)
        {
            _color = color;
            _x = 0;
            _y = 0;
        }

        public Shape() :this(Color.Yellow)
        {
        }

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }



        public abstract void Draw();



        public abstract bool IsAt(Point2D pt);     

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }

        public abstract void DrawOutline();        
    }
}
