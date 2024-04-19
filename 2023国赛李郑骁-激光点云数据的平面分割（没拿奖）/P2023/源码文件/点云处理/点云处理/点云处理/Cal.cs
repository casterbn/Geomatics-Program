using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 点云处理
{
    class Cal
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void GetGrid(DataCenter data)
        {
            // 初始化栅格
            data.grid = new List<Point>[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    data.grid[i, j] = new List<Point>();
                }

            }

            foreach (var point in data.Points)
            {
                int i = (int)(point.Y / 10);
                int j = (int)(point.X / 10);
                data.grid[i, j].Add(point);

            }




        }

        public double GetDistance(Point p1,Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X)
                + (p1.Y - p2.Y) * (p1.Y - p2.Y)
                + (p1.Z - p2.Z) * (p1.Z - p2.Z)
                );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void GetH(DataCenter data)
        {
            data.sigmaH = new double[10, 10];
            data.maxH = new double[10, 10];
            data.minH = new double[10, 10];
            data.avgH = new double[10, 10];
            data.difH = new double[10, 10];



            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    ;
                    data.maxH[i, j] = data.grid[i, j][0].Z;
                    data.minH[i, j] = data.grid[i, j][0].Z;

                    double sumH = 0;

                    foreach (var point in data.grid[i,j])
                    {
                        sumH += point.Z;
                        if (point.Z>data.maxH[i, j])
                        {
                            data.maxH[i, j] = point.Z;
                        }
                        if (point.Z < data.minH[i, j])
                        {
                            data.minH[i, j] = point.Z;
                        }
                    }
                    data.avgH[i,j] = sumH / data.grid[i, j].Count();
                    data.difH[i, j] = data.maxH[i, j] - data.minH[i, j];

                    double sumDelta2 = 0;
                    foreach (var point in data.grid[i, j])
                    {
                        sumDelta2 += (point.Z - data.avgH[i, j]) * (point.Z - data.avgH[i, j]);
                    }
                    data.sigmaH[i,j]= sumDelta2 / data.grid[i, j].Count();


                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void GetMaxMinXYZ(DataCenter data)
        {
            
            data.maxX = data.Points[0].X;
            data.maxY = data.Points[0].Y;
            data.maxZ = data.Points[0].Z;
            data.minX = data.Points[0].X;
            data.minY = data.Points[0].Y;
            data.minZ = data.Points[0].Z;
            foreach (var point in data.Points)
            {


                if (point.X>data.maxX)
                {
                    data.maxX = point.X;
                }
                if (point.Y > data.maxY)
                {
                    data.maxY = point.Y;
                }
                if (point.Z > data.maxZ)
                {
                    data.maxZ = point.Z;
                }

                if (point.X < data.minX)
                {
                    data.minX = point.X;
                }
                if (point.Y < data.minY)
                {
                    data.minY = point.Y;
                }
                if (point.Z < data.minZ)
                {
                    data.minZ = point.Z;
                }



            }
        }


        public void PMNH(DataCenter data)
        {
            data.fGPMs = new List<FGPM>();

            FGPM fgpm = new FGPM();
            
            Point p1 = data.Points[0];
            Point p2 = data.Points[1];
            Point p3 = data.Points[2];

            double a = GetDistance(p1, p2);
            double b = GetDistance(p2, p3);
            double c = GetDistance(p3, p1);

            double p = (a + b + c) / 2;

            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            double A = (p2.Y - p1.Y) * (p3.Z - p1.Z)
                - (p3.Y - p1.Y) * (p2.Z - p1.Z);
            double B = (p2.Z - p1.Z) * (p3.X - p1.X)
                - (p3.Z - p1.Z) * (p2.X - p1.X);
            double C = (p2.X - p1.X) * (p3.Y - p1.Y)
                - (p3.X - p1.X) * (p2.Y - p1.Y);
            double D = 0 - A * p1.X - B * p1.Y - C * p1.Z;


            data.innerP = new bool[1000];
            data.dS = new double[1000];
            data.innerCount = 0;
            data.outCount = 0;

            for (int i = 3; i <data.PointCount ; i++)
            {
                data.dS[i] = Math.Abs(A * data.Points[i].X + B * data.Points[i].Y + C * data.Points[i].Z+D)
                    / Math.Sqrt(A * A + B * B + C * C);

                if (data.dS[i]<0.1)
                {
                    data.innerP[i] = true;
                    data.innerCount++;
                }
                else
                {
                    data.innerP[i] = false;
                    data.outCount++;
                }
;            }

            fgpm.A = A;
            fgpm.B = B;
            fgpm.C = C;
            fgpm.D = D;
            fgpm.S = s;
            fgpm.innerCount = data.innerCount;
            fgpm.outCount = data.outCount;
            //data.fGPMs.Add(fgpm);


            List<Point> list;
            for (int i = 0; i < 300; i++)
            {
                 p1 = data.Points[i*3];
                 p2 = data.Points[i*3+1];
                 p3 = data.Points[i*3+2];

                list = new List<Point>();
                foreach (var point in data.Points)
                {
                    list.Add(point);
                }

                list.RemoveAt(i * 3);
                list.RemoveAt(i * 3);
                list.RemoveAt(i * 3);


                 a = GetDistance(p1, p2);
                 b = GetDistance(p2, p3);
                 c = GetDistance(p3, p1);

                 p = (a + b + c) / 2;

                 s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                if (s<0.1)
                {
                    continue;
                }

                 A = (p2.Y - p1.Y) * (p3.Z - p1.Z)
                    - (p3.Y - p1.Y) * (p2.Z - p1.Z);
                 B = (p2.Z - p1.Z) * (p3.X - p1.X)
                    - (p3.Z - p1.Z) * (p2.X - p1.X);
                 C = (p2.X - p1.X) * (p3.Y - p1.Y)
                    - (p3.X - p1.X) * (p2.Y - p1.Y);
                 D = 0 - A * p1.X - B * p1.Y - C * p1.Z;

                fgpm = new FGPM();
                double ds;
                fgpm.innerPoint = new bool[1000];
                fgpm.A = A;
                fgpm.B = B;
                fgpm.C = C;
                fgpm.D = D;
                fgpm.S = s;
                fgpm.innerCount = 0;
                fgpm.outCount = 0;

                foreach (var point in list)
                {
                    ds = Math.Abs(A * point.X + B * point.Y + C * point.Z + D)
                    / Math.Sqrt(A * A + B * B + C * C);

                    if (ds < 0.1)
                    {
                        fgpm.innerCount++;
                    }
                    else
                    {
                        fgpm.outCount++;
                    }
                }
                data.fGPMs.Add(fgpm);
            }

            int maxInnerCount = data.fGPMs[0].innerCount;
            
            int maxIndex = 0;
            
            for (int i = 0; i < 300; i++)
            {
                if (data.fGPMs[i].innerCount>maxInnerCount)
                {
                    maxInnerCount = data.fGPMs[i].innerCount;
                    maxIndex = i;
                }
            }
            FGPM maxFGPM = data.fGPMs[maxIndex];
            int minOutCount = data.fGPMs[maxIndex].outCount;

        }




    }
}
