using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 纵横断面
{
    class PrioFile
    {
        public Point start;
        public Point end;
        public double angle;


        public List<Point> totalPoints; //面上所有的点
        public Point MiddlePoint;//面上所有的点
        

        public double sumS;//断面面积

        public double sumD; //断面的投影长度

        public PrioFile()
        {
            start = new Point();
            end = new Point();
            totalPoints = new List<Point>();
            MiddlePoint = new Point();
        }
    }
}
