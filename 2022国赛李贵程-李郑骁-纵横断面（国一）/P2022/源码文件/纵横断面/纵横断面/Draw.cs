using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace 纵横断面
{
    class Draw
    {
        public static void DrawByChart(Chart myChart,List<Point> totalPoints, List<Point> keyPoints,List<Point> sanPoints,List<Point> cenPoints,DataCenter datacenter)
        {
            myChart.ChartAreas.Clear();     //清空原有数据
            myChart.Series.Clear();
            myChart.Annotations.Clear();

            ChartArea area = new ChartArea();               //新建ChartArea
            double maxX = totalPoints.Max(o => o.X);        //确定Area范围
            double minX = totalPoints.Min(o => o.X);
            double maxY = totalPoints.Max(o => o.Y);
            double minY = totalPoints.Min(o => o.Y);
            area.AxisX.Maximum = maxY + 16 * (maxY - minY) / totalPoints.Count;
            area.AxisX.Minimum = minY - 16 * (maxX - minX) / totalPoints.Count;
            area.AxisY.Maximum = maxX + 16 * (maxX - minX) / totalPoints.Count;
            area.AxisY.Minimum = minX - 16 * (maxX - minX) / totalPoints.Count;

            myChart.ChartAreas.Add(area);

            Series keySr = new Series();                    //设置Series
            keySr.ChartType = SeriesChartType.Line;
            keySr.MarkerStyle = MarkerStyle.Triangle;
            keySr.MarkerSize = 10;
            keySr.MarkerColor = System.Drawing.Color.Red;
            keySr.Name = "关键点";

            Series sanSr = new Series();
            sanSr.ChartType = SeriesChartType.Point;
            sanSr.MarkerStyle = MarkerStyle.Circle;
            sanSr.MarkerSize = 7;
            sanSr.MarkerColor = System.Drawing.Color.Gray;
            sanSr.Name = "散点";

            Series hozSr = new Series();
                hozSr.ChartType = SeriesChartType.Line;
                hozSr.MarkerStyle = MarkerStyle.Circle;
                hozSr.MarkerSize = 1;
                hozSr.MarkerColor = System.Drawing.Color.Red;
                DataPoint dp1 = new DataPoint(datacenter.Hozs[0].totalPoints[0].Y, datacenter.Hozs[0].totalPoints[0].X);
                DataPoint dp2 = new DataPoint(datacenter.Hozs[0].totalPoints[datacenter.Hozs[0].totalPoints.Count-1].Y, datacenter.Hozs[0].totalPoints[datacenter.Hozs[0].totalPoints.Count-1].X);
            hozSr.Points.Add(dp1);
            hozSr.Points.Add(dp2);
                myChart.Series.Add(hozSr);

            Series hozSr2 = new Series();
            hozSr2.ChartType = SeriesChartType.Line;
            hozSr2.MarkerStyle = MarkerStyle.Circle;
            hozSr2.MarkerSize = 1;
            hozSr2.MarkerColor = System.Drawing.Color.Red;
            DataPoint dp3 = new DataPoint(datacenter.Hozs[1].totalPoints[0].Y, datacenter.Hozs[1].totalPoints[0].X);
            DataPoint dp4 = new DataPoint(datacenter.Hozs[1].totalPoints[datacenter.Hozs[1].totalPoints.Count - 1].Y, datacenter.Hozs[1].totalPoints[datacenter.Hozs[1].totalPoints.Count - 1].X);
            hozSr2.Points.Add(dp3);
            hozSr2.Points.Add(dp4);
            myChart.Series.Add(hozSr2);



            foreach (var item in keyPoints)
            {
                DataPoint dp = new DataPoint(item.Y,item.X);
                keySr.Points.Add(dp);
            }
            foreach (var item in sanPoints)
            {
                DataPoint dp = new DataPoint(item.Y,item.X);
                sanSr.Points.Add(dp);
            }


            myChart.Series.Add(keySr);
            myChart.Series.Add(sanSr);


            myChart.DataBind();

        }

    }
}
