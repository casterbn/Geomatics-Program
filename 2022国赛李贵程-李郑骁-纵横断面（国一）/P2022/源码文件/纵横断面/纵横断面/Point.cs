using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 纵横断面
{
    class Point
    {
        public string Name; //点名
        public double X; //X坐标值
        public double Y; //Y坐标值
        public double H; //H坐标值

        public double Distance; //距离
        public bool IsDatum; //判断是否为K点

        public Point()
        {
            IsDatum = false;
        }
        public Point(double x, double y)
        {
            this.Name = "";
            this.X = x;
            this.Y = y;
        }
        public Point(string name,double x,double y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }
}
