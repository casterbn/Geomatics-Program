using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 纵横断面
{
    class Algorithm
    {
        /// <summary>
        /// 计算方位角
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static double CalAngle(Point p1, Point p2)
        {
            double angle = 0;
            double sheta = 0;
            double dx = 0;
            double dy = 0;

            dx = p2.X - p1.X;
            dy = p2.Y - p1.Y;
            sheta = Math.Atan(dy / dx);

            if (dx != 0)
            {
                if (dy > 0 && dx > 0) angle = sheta;
                else if (dy > 0 && dx < 0) angle = Math.PI + sheta;
                else if (dy < 0 && dx < 0) angle = Math.PI + sheta;
                else if (dy < 0 && dx > 0) angle = 2 * Math.PI + sheta;
            }
            else
            {
                if (dy > 0)
                {
                    angle = Math.PI / 2;
                }
                else
                {
                    angle = 3 * Math.PI / 2;
                }
            }
            return angle;
        }

        /// <summary>
        /// 计算内插点的高程值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="oriPoints"></param>
        /// <param name="n"></param>
        /// <param name="nearPoints"></param>
        /// <returns></returns>
        public static double CalInnerH(Point a, List<Point> oriPoints, int n, out List<Point> nearPoints)
        {
            List<Point> tempPoints = new List<Point>();
            oriPoints.ForEach(o => tempPoints.Add(o));
            nearPoints = new List<Point>();
            for (int i = 0; i < tempPoints.Count; i++)
            {
                tempPoints[i].Distance = CalDistance(a, tempPoints[i]);
                if (a.Name == tempPoints[i].Name)
                {
                    tempPoints.Remove(tempPoints[i]);
                    i--;
                }
            }
            tempPoints = tempPoints.OrderBy(o => o.Distance).ToList();
            double temp1 = 0;
            double temp2 = 0;
            for (int i = 0; i < n; i++)
            {
                temp1 += tempPoints[i].H / tempPoints[i].Distance;
                temp2 += 1.0 / tempPoints[i].Distance;
                nearPoints.Add(tempPoints[i]);
            }
            return temp1 / temp2;
        }

        /// <summary>
        /// 计算断面的面积
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="h0"></param>
        /// <returns></returns>
        public static double CalS(Point start, Point end, double h0)
        {
            double deta = CalDistance(start, end);
            double S = (start.H + end.H - 2 * h0) * deta / 2;
            return S;
        }
        /// <summary>
        /// 计算距离
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static double CalDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
        /// <summary>
        /// 计算纵断面上的所有点
        /// </summary>
        /// <param name="DatumPoints"></param>
        /// <param name="oriPoints"></param>
        /// <param name="n"></param>
        /// <param name="deta"></param>
        /// <param name="nearPoints"></param>
        /// <returns></returns>
        public static PrioFile GetVerticalPoints(List<Point> DatumPoints, List<Point> oriPoints, int n, double deta, out List<Point> nearPoints, double rdh)
        {
            PrioFile Vertical = new PrioFile();
            List<Point> totalPoints = new List<Point>();
            nearPoints = new List<Point>();
            Point start = new Point();
            start = DatumPoints[0];
            totalPoints.Add(start);
            Point tempPoint;
            double sumD = 0;
            double sumS = 0;
            double InnerLC = deta;
            int num = 1;

            

            for (int i = 0; i < DatumPoints.Count - 1; i++)
            {
                Point now = DatumPoints[i];
                Point next = DatumPoints[i + 1];

                double angle = CalAngle(now, next);
                double Dis = CalDistance(now, next);

                sumD += Dis;



                next.Distance = sumD;
                double D0 = CalDistance(DatumPoints[i], DatumPoints[0]);
                while ((InnerLC - D0) < Dis)
                {
                    double Li = InnerLC - D0;
                    tempPoint = new Point();
                    tempPoint.Name = "Z" + num.ToString();
                    tempPoint.X = DatumPoints[i].X + Li * Math.Cos(angle);
                    tempPoint.Y = DatumPoints[i].Y + Li * Math.Sin(angle);
                    tempPoint.H = CalInnerH(tempPoint, oriPoints, n, out nearPoints);
                    totalPoints.Add(tempPoint);

                    InnerLC += deta;
                    num++;
                }
                totalPoints.Add(next);
            }
            for (int i = 0; i < totalPoints.Count - 1; i++)
            {
                double S = CalS(totalPoints[i], totalPoints[i + 1], rdh);
                sumS += S;
            }
            Vertical.totalPoints = totalPoints;
            Vertical.sumD = sumD;
            Vertical.sumS = sumS;

            return Vertical;
        }
        /// <summary>
        /// 计算单个横断面
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="oriPoints"></param>
        /// <param name="n"></param>
        /// <param name="deta"></param>
        /// <param name="num"></param>
        /// <param name="nearPoints"></param>
        /// <returns></returns>

        public static PrioFile GetoneHozPoints(Point start, Point end, List<Point> oriPoints, int n, double deta, int num, out List<Point> nearPoints, double rdh)
        {
            PrioFile pri = new PrioFile();
            List<Point> totalPoints = new List<Point>();
            nearPoints = new List<Point>();

            Point Middle = new Point();
            Middle.X = (start.X + end.X) / 2;
            Middle.Y = (start.Y + end.Y) / 2;
            Middle.H = CalInnerH(Middle, oriPoints, 5, out nearPoints);
            Point tempPoint;
            int intNum = 1;
            double angle = CalAngle(start, end) + Math.PI / 2;
            pri.angle = angle;
            double sumS = 0;
            for (int i = -num; i <= num; i++)
            {
                if (i == 0)
                {
                    pri.MiddlePoint = Middle;
                    totalPoints.Add(Middle);
                }
                else
                {
                    tempPoint = new Point();
                    tempPoint.Distance = i * deta;
                    tempPoint.Name = "NA" + num.ToString();
                    tempPoint.X = Middle.X + i * deta * Math.Cos(angle);
                    tempPoint.Y = Middle.Y + i * deta * Math.Sin(angle);
                    tempPoint.H = CalInnerH(tempPoint, oriPoints, n, out nearPoints);
                    totalPoints.Add(tempPoint);
                }
                intNum++;
            }
            for (int i = 0; i < totalPoints.Count - 1; i++)
            {
                double S = CalS(totalPoints[i], totalPoints[i + 1], rdh);
                sumS += S;
            }

            pri.totalPoints = totalPoints;
            pri.sumS = sumS;
            return pri;
        }
        /// <summary>
        /// 弧度转度
        /// </summary>
        /// <param name="radvalue"></param>
        /// <returns></returns>
        public static double Rad2Dms(double radvalue)
        {
            int dd, mm, sign = 1;
            double ssss, dms;
            if (radvalue < 0)
            {
                sign = -1;
                radvalue = Math.Abs(radvalue);
            }

            double temp = radvalue * 180 / Math.PI * 3600;
            dd = (int)(radvalue * 180 / Math.PI + 0.001);
            mm = (int)((temp - dd * 3600) / 60 + 0.0001);
            ssss = (temp - dd * 3600 - mm * 60);
            dms = dd + mm / 100.0 + ssss / 10000.0;
            dms = sign * dms;
            return dms;
        }
    }
}
