using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 利用构建不规则三角网_TIN_进行体积计算
{
    public  class PointF
    {
        public string Name;
        public double X;
        public double Y;
        public double H;
        public PointF()
        {

        }
        public PointF(String name, double x, double y, double h)
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.H = h;
        }
        public PointF(double x,double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
