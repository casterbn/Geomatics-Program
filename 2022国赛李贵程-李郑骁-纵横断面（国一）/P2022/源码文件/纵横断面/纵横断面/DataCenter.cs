using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 纵横断面
{
    class DataCenter
    {
        public List<Point> DatumPoints; //已知的K点
        public List<Point> OriPoints;   //所有点包括K点
        public List<Point> test;        //测试点
        public List<Point> sanPoint;    //散点
        public List<Point> cenPoint;    //中心点

        

        public PrioFile Vertical;//纵断面
        public List<PrioFile> Hozs;//横断面

        public double RDH;
    }
}
