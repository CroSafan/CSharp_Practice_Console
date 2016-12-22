using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Challenge296Intersecting_Area_Rectangles
{
    public class Point
    {
        public float x { get; set; }
        public float y { get; set; }
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class RectangleIntersection
    {
        float x11 { get; set; }
        float x12 { get; set; }
        float x21 { get; set; }
        float x22 { get; set; }

        float y11 { get; set; }
        float y12 { get; set; }
        float y21 { get; set; }
        float y22 { get; set; }

        public RectangleIntersection(Point p1, Point p2, Point p3, Point p4)
        {
            x11 = p1.x;
            x12 = p2.x;
            x21 = p3.x;
            x22 = p4.x;

            y11 = p1.y;
            y12 = p2.y;
            y21 = p3.y;
            y22 = p4.y;
        }

        public float OverlapArea()
        {

            float xOverlap = Math.Max(0, Math.Min(x12, x22) - Math.Max(x11, x21));
            float yOverLap = Math.Max(0, Math.Min(y12, y22) - Math.Max(y11, y21));

            return xOverlap * yOverLap;
        }

    }
    class Program
    {
        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/5jpt8v/20161222_challenge_296_intermediate_intersecting/
        /// </summary>
        /// <param name="args"></param>
        /// 


        static void Main(string[] args)
        {
            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(2, 2);
            Point pt3 = new Point(1, 1);
            Point pt4 = new Point(3, 3);
            RectangleIntersection rects = new RectangleIntersection(pt1, pt2, pt3, pt4);
            Console.WriteLine(rects.OverlapArea());


            Console.Read();
        }
    }
}
