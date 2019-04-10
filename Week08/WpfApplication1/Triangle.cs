using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApplication1
{
    class Triangle : Shape
    {
        protected override Geometry DefiningGeometry
        {
            get
            {

                PathFigure myPathFigure = new PathFigure();
                myPathFigure.StartPoint = new Point(Width/2, 0);

                LineSegment segment1 = new LineSegment();
                segment1.Point = new Point(Width, Height);
                LineSegment segment2 = new LineSegment();
                segment2.Point = new Point(0, Height);
                LineSegment segment3 = new LineSegment();
                segment3.Point = new Point(Width/2, 0);
                PathSegmentCollection myPathSegmentCollection = new PathSegmentCollection();
                myPathSegmentCollection.Add(segment1);
                myPathSegmentCollection.Add(segment2);
                myPathSegmentCollection.Add(segment3);

                myPathFigure.Segments = myPathSegmentCollection;

                PathFigureCollection myPathFigureCollection = new PathFigureCollection();
                myPathFigureCollection.Add(myPathFigure);

                PathGeometry myPathGeometry = new PathGeometry();
                myPathGeometry.Figures = myPathFigureCollection;

                return myPathGeometry;
            }
        }
    }
}
