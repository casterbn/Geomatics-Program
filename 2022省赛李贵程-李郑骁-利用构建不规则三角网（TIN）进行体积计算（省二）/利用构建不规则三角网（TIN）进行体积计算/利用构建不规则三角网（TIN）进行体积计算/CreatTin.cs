using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 利用构建不规则三角网_TIN_进行体积计算
{
    
    class CreatTin
    {
        public struct Side
        {
            public List<PointF> SP;
        }
        public struct Triangle
        {
            public List<PointF> TP;
            public List<Side> TS;
        }

        public  List<Triangle> T1 = new List<Triangle>();
        List<Side> S = new List<Side>();
        public Side Sameside = new Side();
        public Side Sameside1 = new Side();

        /// <summary>
        /// 找出距离几何中心最近的点
        /// </summary>
        /// <param name="datacenter"></param>
        /// <returns></returns>
        public PointF FindPoint(Datacenter datacenter)
        {
            PointF point = new PointF();
            int n = datacenter.Convex_Hull.Count;
            int sub = -1;
            double x0, y0;
            double minD = 1000000000;
            double D;

            x0 = datacenter.Convex_Hull.Sum(r => r.X) / n;
            y0 = datacenter.Convex_Hull.Sum(r => r.Y) / n;
            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                D = Math.Sqrt((datacenter.GivenPoints[i].X - x0) * (datacenter.GivenPoints[i].X - x0) + (datacenter.GivenPoints[i].Y - y0) * (datacenter.GivenPoints[i].Y - y0));
                if (D < minD)
                {
                    sub = i;
                }
            }
            return datacenter.GivenPoints[sub];
        }

        /// <summary>
        /// 判断是否在三角形外接圆内部
        /// </summary>
        /// <param name="point"></param>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public bool JudgeIncircle(PointF point, Triangle triangle)
        {
            bool IsIn = false;
            double x1, x2, x3;
            double y1, y2, y3;
            double x0, y0, r;
            double D;

            PointF A, B, C = new PointF();
            A = triangle.TP[0];
            B = triangle.TP[1];
            C = triangle.TP[2];
            x1 = A.X; x2 = B.X; x3 = C.X;
            y1 = A.Y; y2 = B.Y; y3 = C.Y;



            x0 = ((y2 - y1) * (y3 * y3 - y1 * y1 + x3 * x3 - x1 * x1) - (y3 - y1) * (y2 * y2 - y1 * y1 + x2 * x2 - x1 * x1))
                / (2 * (x3 - x1) * (y2 - y1) - 2 * (x2 - x1) * (y3 - y1));
            y0 = ((x2 - x1) * (x3 * x3 - x1 * x1 + y3 * y3 - y1 * y1) - (x3 - x1) * (x2 * x2 - x1 * x1 + y2 * y2 - y1 * y1))
                / (2 * (y3 - y1) * (x2 - x1) - 2 * (y2 - y1) * (x3 - x1));
            r = Math.Sqrt((x0 - x1) * (x0 - x1) + (y0 - y1) * (y0 - y1));

            D = Math.Sqrt((x0 - point.X) * (x0 - point.X) + (y0 - point.Y) * (y0 - point.Y));

            if (D <= r)
            {
                IsIn = true;
            }
            return IsIn;
        }
        /// <summary>
        /// 判断是否有相同边
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        public bool JudgeSameSide(Triangle t1, Triangle t2)
        {
            bool same = true;

            for (int i = 0; i < t1.TS.Count; i++)
            {
                for (int j = 0; j < t2.TS.Count; j++)
                {
                    if (t1.TS[i].SP[0].X == t2.TS[j].SP[0].X && t1.TS[i].SP[0].Y == t2.TS[j].SP[0].Y &&
                        t1.TS[i].SP[1].X == t2.TS[j].SP[1].X && t1.TS[i].SP[1].Y == t2.TS[j].SP[1].Y ||
                        t1.TS[i].SP[0].X == t2.TS[j].SP[1].X && t1.TS[i].SP[0].Y == t2.TS[j].SP[1].Y &&
                        t1.TS[i].SP[1].X == t2.TS[j].SP[0].X && t1.TS[i].SP[1].Y == t2.TS[j].SP[0].Y)
                    {
                        same = true;
                        Sameside = t1.TS[i];
                        Sameside1 = t2.TS[j];
                        break;
                    }
                    else
                    {
                        same = false;
                    }
                }
                if (same)
                {
                    break;
                }

            }
            return same;
        }
        /// <summary>
        /// 生成初始三角形
        /// </summary>
        /// <param name="datacenter"></param>
        public void CreateInitTIN(Datacenter datacenter)
        {
            PointF point = FindPoint(datacenter);

            for (int i = 0; i < datacenter.Convex_Hull.Count - 1; i++)
            {
                Side S1, S2, S3 = new Side();
                S1.SP = new List<PointF>();
                S2.SP = new List<PointF>();
                S3.SP = new List<PointF>();
                Triangle t1 = new Triangle();
                t1.TP = new List<PointF>();
                t1.TS = new List<Side>();
                t1.TP.Add(datacenter.Convex_Hull[i]);
                t1.TP.Add(datacenter.Convex_Hull[i + 1]);
                t1.TP.Add(point);

                S1.SP.Add(datacenter.Convex_Hull[i]);
                S1.SP.Add(datacenter.Convex_Hull[i + 1]);

                S2.SP.Add(datacenter.Convex_Hull[i + 1]);
                S2.SP.Add(point);

                S3.SP.Add(datacenter.Convex_Hull[i]);
                S3.SP.Add(point);

                t1.TS.Add(S1);
                t1.TS.Add(S2);
                t1.TS.Add(S3);
                T1.Add(t1);
            }

        }
        /// <summary>
        /// 生成TIN
        /// </summary>
        /// <param name="datacenter"></param>
        public void CreatePlaneTIN(Datacenter datacenter)
        {
            for (int i = 0; i < datacenter.NoneConvexPoints.Count; i++)
            {
                List<Triangle> T2 = new List<Triangle>();
                for (int j = 0; j < T1.Count; j++)
                {
                    if (JudgeIncircle(datacenter.NoneConvexPoints[i], T1[j]))
                    {
                        T2.Add(T1[j]);
                    }
                }

                for (int j = 0; j < T2.Count; j++)
                {
                    T1.Remove(T2[j]);
                }

                for (int j = 0; j < T2.Count - 1; j++)
                {
                    int ii = j + 1;
                    while (ii <= T2.Count - 1)
                    {
                        if (JudgeSameSide(T2[j], T2[ii]))
                        {
                            T2[j].TS.Remove(Sameside);
                            T2[ii].TS.Remove(Sameside1);
                        }
                        ii++;
                    }
                }

                S.Clear();
                for (int j = 0; j < T2.Count; j++)
                {
                    for (int a2 = 0; a2 < T2[j].TS.Count; a2++)
                    {
                        S.Add(T2[j].TS[a2]);
                    }
                }


                for (int j = 0; j < S.Count; j++)
                {
                    Side S1, S2, S3 = new Side();
                    S1.SP = new List<PointF>();
                    S2.SP = new List<PointF>();
                    S3.SP = new List<PointF>();
                    Triangle t1 = new Triangle();
                    t1.TP = new List<PointF>();
                    t1.TS = new List<Side>();

                    t1.TP.Add(S[j].SP[0]);
                    t1.TP.Add(S[j].SP[1]);
                    t1.TP.Add(datacenter.NoneConvexPoints[i]);

                    S1 = S[j];
                    S2.SP.Add(S[j].SP[0]);
                    S2.SP.Add(datacenter.NoneConvexPoints[i]);
                    S3.SP.Add(S[j].SP[1]);
                    S3.SP.Add(datacenter.NoneConvexPoints[i]);

                    t1.TS.Add(S1);
                    t1.TS.Add(S2);
                    t1.TS.Add(S3);


                    T1.Add(t1);
                }


            }

        }
    }
}
