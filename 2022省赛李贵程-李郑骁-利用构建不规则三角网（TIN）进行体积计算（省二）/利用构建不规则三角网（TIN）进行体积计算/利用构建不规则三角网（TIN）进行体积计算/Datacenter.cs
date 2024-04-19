using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 利用构建不规则三角网_TIN_进行体积计算
{
    class Datacenter
    {
        public struct Side
        {
            public List<PointF> SP;
        }
        public struct Triangle
        {
            public List<PointF> TP;
            public List<PointF> TS;
        }
        public List<PointF> GivenPoints = new List<PointF>();
        public List<PointF> FourPeaks = new List<PointF>();
        public List<PointF> Convex_Hull = new List<PointF>();
        public List<PointF> NoneConvexPoints = new List<PointF>();
        public List<Triangle> ALLT = new List<Triangle>();
        public double HeightDatum;
    }
}
