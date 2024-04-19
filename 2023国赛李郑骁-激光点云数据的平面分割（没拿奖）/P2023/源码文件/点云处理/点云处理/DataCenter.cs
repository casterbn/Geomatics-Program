using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 点云处理
{
    class DataCenter
    {
        public int PointCount;
        public List<Point> Points;
        public List<Point>[,] grid;
        public List<FGPM> fGPMs;

        public double[,] avgH;
        public double[,] maxH;
        public double[,] minH;
        public double[,] difH;
        public double[,] sigmaH;

        public double pmnhS;
        public double pmnhA;
        public double pmnhB;
        public double pmnhC;
        public double pmnhD;

        public bool[] innerP;
        public double[] dS;
        public int innerCount;
        public int outCount;

        


        public double maxX;
        public double maxY;
        public double maxZ;
        public double minX;
        public double minY;
        public double minZ;


    }

    class Point
    {
        public double X;
        public double Y;
        public double Z;
        public string Name;

        public Point(string name,double x,double y,double z)
        {
            X = x;
            Y = y;
            Z = z;

            Name = name;

        }


    }

    class FGPM
    {
        public double A;
        public double B;
        public double C;
        public double D;
        public double S;
        public int innerCount;
        public int outCount;
        public bool[] innerPoint;
    }

}
