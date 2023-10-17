using System;
using System.Collections.Generic;
using SplashKitSDK;


namespace ShapeDrawer
{
    public class Drawing
    {
        //List<Shape> is a List of referneces to Shape objects
        private readonly List<Shape> _shapes;
        private Color _background;


        //this is used to refer to current object
        //default constructor
        public Drawing() : this(Color.White) { }

        //constructor
        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;

        }

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result;
                result = new List<Shape>();
                foreach (Shape s in _shapes)
                {
                    if (s.Selected)
                    {
                        result.Add(s);
                    }
                }
                return result;
            }
        }

        //number of shapes within the collection
        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }

        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }


        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape sh in _shapes)
            {
                sh.Draw();
            }
        }


        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(pt))
                {
                    s.Selected = true;
                }
                else
                {
                    s.Selected = false;
                }
            }
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape(Shape s)
        {
            _shapes.Remove(s);
        }
    }
}








