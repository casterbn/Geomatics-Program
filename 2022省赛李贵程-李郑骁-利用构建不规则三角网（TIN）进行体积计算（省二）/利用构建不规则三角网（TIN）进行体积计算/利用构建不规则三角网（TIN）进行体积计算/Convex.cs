using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 利用构建不规则三角网_TIN_进行体积计算
{
    class Convex
    {
        List<PointF> CH = new List<PointF>();
        /// <summary>
        /// 查找四个顶点
        /// </summary>
        /// <param name="knownpoints"></param>
        /// <returns></returns>
        public List<PointF> Find_FourPeaks(List<PointF> knownpoints)
        {
            List<PointF> fourpeaks = new List<PointF>();
            double[,] MaxMin = new double[2, 2];
            MaxMin[0, 0] = knownpoints.Min(r => r.X);
            MaxMin[0, 1] = knownpoints.Min(r => r.Y);
            MaxMin[1, 0] = knownpoints.Max(r => r.X);
            MaxMin[1, 1] = knownpoints.Max(r => r.Y);

            IEnumerable<PointF> P01 = knownpoints.Where(r => r.X == MaxMin[0, 0]); // X最小值，也就是P1
            PointF[] P02 = P01.ToArray();
            fourpeaks.Add(P02[0]);
            knownpoints.Remove(P02[0]);

            P01 = knownpoints.Where(r => r.Y == MaxMin[1, 1]); //Y最大值，也就是P2
            P02 = P01.ToArray();
            fourpeaks.Add(P02[0]);
            knownpoints.Remove(P02[0]);

            P01 = knownpoints.Where(r => r.X == MaxMin[1, 0]);  //X最大值，也就是P3
            P02 = P01.ToArray();
            fourpeaks.Add(P02[0]);
            knownpoints.Remove(P02[0]);

            P01 = knownpoints.Where(r => r.Y == MaxMin[0, 1]);   //Y最小值，也就是P4
            P02 = P01.ToArray();
            fourpeaks.Add(P02[0]);
            knownpoints.Remove(P02[0]);

            return fourpeaks;

        }
        /// <summary>
        /// 判断位于左边还是右边
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <returns></returns>
        public int Judge_left(PointF p1, PointF p2, PointF p3)
        {
            int i = 1;
            if ((p1.X * p2.Y - p2.X * p1.Y + p3.X * (p1.Y - p2.Y) + p3.Y * (p2.X - p1.X)) > 0)
            {
                i = 1;
            }
            else
            {
                i = -1;
            }
            return i;
        }
        /// <summary>
        /// 计算面积
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <returns></returns>
        public double Area(PointF p1, PointF p2, PointF p3)
        {
            return Math.Abs(p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y)) / 2;
        }
        /// <summary>
        /// 找出凸包点
        /// </summary>
        /// <param name="datacenter"></param>
        public void FCH(Datacenter datacenter)
        {
            List<PointF> kownpoints = datacenter.GivenPoints.ToList();
            List<PointF> four_peaks = Find_FourPeaks(kownpoints);
            datacenter.FourPeaks = four_peaks.ToList();

            CH.Add(four_peaks[0]);
            for (int i = 0; i < four_peaks.Count; i++)
            {
                List<PointF> leftpoints = new List<PointF>();
                for (int j = 0; j < kownpoints.Count; j++)
                {
                    if (Judge_left(four_peaks[i % 4], four_peaks[(i + 1) % 4], kownpoints[j]) > 0)
                    {
                        leftpoints.Add(kownpoints[j]);
                        kownpoints.Remove(kownpoints[j]);
                        j--;
                    }
                }
                Find_CH(leftpoints, four_peaks[i % 4], four_peaks[(i + 1) % 4]);
            }
            for (int i = 0; i < CH.Count; i++)
            {
                datacenter.Convex_Hull.Add(CH[i]);
            }
            datacenter.NoneConvexPoints = datacenter.GivenPoints.ToList();
            for (int i = 0; i < datacenter.Convex_Hull.Count; i++)
            {
                datacenter.NoneConvexPoints.Remove(datacenter.Convex_Hull[i]);
            }
        }
        /// <summary>
        /// 迭代函数
        /// </summary>
        /// <param name="leftpoints"></param>
        /// <param name="head"></param>
        /// <param name="tail"></param>
        public void Find_CH(List<PointF> leftpoints, PointF head, PointF tail)
        {
            int Area_sub = -1;
            double arcmax = 0;
            for (int i = 0; i < leftpoints.Count; i++)
            {
                if (Area(leftpoints[i], head, tail) > arcmax)
                {
                    arcmax = Area(leftpoints[i], head, tail);
                    Area_sub = i;
                }
            }
            if (Area_sub == -1)
            {
                CH.Add(tail);
            }
            else
            {
                PointF mid = leftpoints[Area_sub];
                leftpoints.Remove(mid);

                List<PointF> leftpoints1 = new List<PointF>();
                for (int i = 0; i < leftpoints.Count; i++)
                {
                    if (Judge_left(head, mid, leftpoints[i]) > 0)
                    {
                        leftpoints1.Add(leftpoints[i]);
                    }
                }
                Find_CH(leftpoints1, head, mid);

                List<PointF> leftpoints2 = new List<PointF>();
                for (int i = 0; i < leftpoints.Count; i++)
                {
                    if (Judge_left(mid, tail, leftpoints[i]) > 0)
                    {
                        leftpoints2.Add(leftpoints[i]);
                    }
                }
                Find_CH(leftpoints2, mid, tail);
            }
        }
    }
}
