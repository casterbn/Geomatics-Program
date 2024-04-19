using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace 纵横断面
{
    public partial class Form1 : Form
    {

        string Report = "";
        DataCenter dataCenter = new DataCenter();
        List<Point> neatPoints1 = new List<Point>();
        List<Point> neatPoints2 = new List<Point>();
        double H1;
        double H2;
        double s = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public  void GetReport()
        {
            Report += "---------------------计算报告---------------------\r\n";

            Report += "A点的内插高程："+H1.ToString("F3")+ "       \r\n离A最近的点:        \r\n";
            for (int i = 0; i < neatPoints1 .Count; i++)
            {
                Report += "点号:" + neatPoints1[i].Name + "\t" + neatPoints1[i].Distance.ToString("F3") + "\t";

                Report += "\r\n";
            }
            Report += "B点的内插高程：" + H1.ToString("F3") + "       \r\n离B最近的点:        \r\n";
            for (int i = 0; i < neatPoints2.Count; i++)
            {
                Report += "点号:" + neatPoints2[i].Name + "\t" + neatPoints2[i].Distance.ToString("F3") + "\t";


                Report += "\r\n";

            }
            Report += "\r\n";

            Report += "AB梯形面积:" + s.ToString("F3")+"\r\n";
            Report += "\r\n";
            Report += "\r\n";
            Report += "纵断面的总长度:" + dataCenter.Vertical.sumD.ToString("F3") + "\r\n";

            Report += "\r\n";
            Report += "\r\n";


            Report += "------------------纵断面内插点：\r\n----------------";
            foreach (var item in dataCenter.Vertical.totalPoints)
            {
                Report += "点名：  " + item.Name + "       X:" + item.X.ToString("F3") + "      Y:" + item.Y.ToString("F3") + "     H:" + item.H.ToString("F3")+"\r\n";
            }


            Report += "----------------横断面内插点：\r\n------------------";
            foreach (var item in dataCenter.Hozs[0].totalPoints)
            {
                Report += "点名：  " + item.Name + "       X:" + item.X.ToString("F3") + "      Y:" + item.Y.ToString("F3") + "     H:" + item.H.ToString("F3")+"\r\n";
            }
            foreach (var item in dataCenter.Hozs[1].totalPoints)
            {
                Report += "点名：  " + item.Name + "       X:" + item.X.ToString("F3") + "      Y:" + item.Y.ToString("F3") + "     H:" + item.H.ToString("F3") + "\r\n";

            }

            textBox1.Text = Report;
        }

        private void 导入数据文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();      //文件读取
            opf.Filter = "文本文件|**.txt";
            opf.Title = "请选择要导入的数据文件";
            dataCenter.test = new List<Point>();
            dataCenter.OriPoints = new List<Point>();
            dataCenter.DatumPoints = new List<Point>();
            dataCenter.sanPoint = new List<Point>();


            if (opf.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(opf.FileName);       //创建文件流

                string[] line1 = sr.ReadLine().Split(',');
                dataCenter.RDH = double.Parse(line1[1]);

                string[] line2 = sr.ReadLine().Split(',');


                string[] line3 = sr.ReadLine().Split(',');
                Point tp1 = new Point(line3[0],double.Parse(line3[1]),double.Parse(line3[2]));
                dataCenter.test.Add(tp1);
                string[] line4 = sr.ReadLine().Split(',');
                Point tp2 = new Point(line4[0], double.Parse(line4[1]), double.Parse(line4[2]));
                dataCenter.test.Add(tp2);

                sr.ReadLine();
                

                while (!sr.EndOfStream)                             //循环读取数据
                {
                    string[] lines = sr.ReadLine().Split(',');
                    Point p = new Point();
                    p.Name = lines[0];
                    p.X = double.Parse(lines[1]);
                    p.Y = double.Parse(lines[2]);
                    p.H = double.Parse(lines[3]);
                    dataCenter.OriPoints.Add(p);
                    if (lines[0].StartsWith("K"))
                    {
                        p.IsDatum = true;
                        dataCenter.DatumPoints.Add(p);
                    }
                    else dataCenter.sanPoint.Add(p);
                }

                dataGridView1.RowCount = dataCenter.OriPoints.Count;            //显示数据到表上
                for (int i = 0; i < dataCenter.OriPoints.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = dataCenter.OriPoints[i].Name;
                    dataGridView1.Rows[i].Cells[1].Value = dataCenter.OriPoints[i].X;
                    dataGridView1.Rows[i].Cells[2].Value = dataCenter.OriPoints[i].Y;
                    dataGridView1.Rows[i].Cells[3].Value = dataCenter.OriPoints[i].H;

                }

                sr.Dispose();
            }

        }
        /// <summary>
        /// 保存示意图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存示意图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "图片文件|*.jpg";
            if (svf.ShowDialog()==DialogResult.OK)
            {
                chart1.SaveImage(svf.FileName, ChartImageFormat.Jpeg);
                MessageBox.Show("图片保存成功");
            }
        }
        /// <summary>
        /// 保存计算报告
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存计算报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Report += "ceeads";
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "文本文件|*.txt";
            if (svf.ShowDialog()==DialogResult.OK)
            { 
                StreamWriter sw = new StreamWriter(svf.FileName);
                sw.Write(Report);
            }
        }
        /// <summary>
        /// 纵断面计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 纵断面计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Point> nearPoints;
            double sumD = 0;
            dataCenter.Vertical = Algorithm.GetVerticalPoints(dataCenter.DatumPoints, dataCenter.OriPoints, 5, 10, out nearPoints, dataCenter.RDH);

        }
        /// <summary>
        /// 计算角度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 计算角度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double angle = Algorithm.CalAngle(dataCenter.test[0], dataCenter.test[1]);
            double dms = Algorithm.Rad2Dms(angle);
        }
        /// <summary>
        /// 计算纵断面长度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 计算纵断面长度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Point> nearPoints;
            double sumD = 0;
            dataCenter.Vertical = Algorithm.GetVerticalPoints(dataCenter.DatumPoints, dataCenter.OriPoints, 5, 10, out nearPoints, dataCenter.RDH);
        }
        /// <summary>
        /// 计算内插高程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 计算内插高程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            H1 = Algorithm.CalInnerH(dataCenter.test[0], dataCenter.OriPoints, 5, out neatPoints1);
            H2 = Algorithm.CalInnerH(dataCenter.test[1], dataCenter.OriPoints, 5, out neatPoints2);
            GetReport();
        }
        /// <summary>
        /// 计算梯形面积
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 计算梯形面积ToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            List<Point> nearPoints;
            dataCenter.test[0].H = Algorithm.CalInnerH(dataCenter.test[0], dataCenter.OriPoints, 5, out nearPoints);
            dataCenter.test[1].H = Algorithm.CalInnerH(dataCenter.test[1], dataCenter.OriPoints, 5, out nearPoints);
            s = Algorithm.CalS(dataCenter.test[0], dataCenter.test[1], dataCenter.RDH);
        }
        /// <summary>
        /// 计算横断面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 计算横断面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataCenter.Hozs = new List<PrioFile>();
            List<Point> nearPoints;
            for (int i = 0; i < dataCenter.DatumPoints.Count - 1; i++)
            {
                PrioFile pri = new PrioFile();
                pri = Algorithm.GetoneHozPoints(dataCenter.DatumPoints[i], dataCenter.DatumPoints[i + 1], dataCenter.OriPoints, 5, 5, 5, out nearPoints, dataCenter.RDH);
                dataCenter.Hozs.Add(pri);
            }
        }
        /// <summary>
        /// 横断面计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 横断面计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataCenter.Hozs = new List<PrioFile>();
            List<Point> nearPoints;
            for (int i = 0; i < dataCenter.DatumPoints.Count - 1; i++)
            {
                PrioFile pri = new PrioFile();
                pri = Algorithm.GetoneHozPoints(dataCenter.DatumPoints[i], dataCenter.DatumPoints[i + 1], dataCenter.OriPoints, 5, 5, 5, out nearPoints, dataCenter.RDH);
                dataCenter.Hozs.Add(pri);
            }
            Draw.DrawByChart(chart1, dataCenter.OriPoints, dataCenter.DatumPoints, dataCenter.sanPoint, dataCenter.DatumPoints, dataCenter);
            
        }
        /// <summary>
        /// 导入数据文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            导入数据文件ToolStripMenuItem_Click(sender, e);
        }
        /// <summary>
        /// 一键计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            H1 = Algorithm.CalInnerH(dataCenter.test[0], dataCenter.OriPoints, 5, out neatPoints1);
            H2 = Algorithm.CalInnerH(dataCenter.test[1], dataCenter.OriPoints, 5, out neatPoints2);
            List<Point> nearPoints;
            double sumD = 0;
            dataCenter.test[0].H = Algorithm.CalInnerH(dataCenter.test[0], dataCenter.OriPoints, 5, out nearPoints);
            dataCenter.test[1].H = Algorithm.CalInnerH(dataCenter.test[1], dataCenter.OriPoints, 5, out nearPoints);
            s = Algorithm.CalS(dataCenter.test[0], dataCenter.test[1], dataCenter.RDH);
            dataCenter.Vertical = Algorithm.GetVerticalPoints(dataCenter.DatumPoints, dataCenter.OriPoints, 5, 10, out nearPoints, dataCenter.RDH);
            dataCenter.Hozs = new List<PrioFile>();
            for (int i = 0; i < dataCenter.DatumPoints.Count - 1; i++)
            {
                PrioFile pri = new PrioFile();
                pri = Algorithm.GetoneHozPoints(dataCenter.DatumPoints[i], dataCenter.DatumPoints[i + 1], dataCenter.OriPoints, 5, 5, 5, out nearPoints, dataCenter.RDH);
                dataCenter.Hozs.Add(pri);
            }
            Draw.DrawByChart(chart1, dataCenter.OriPoints, dataCenter.DatumPoints, dataCenter.sanPoint, dataCenter.DatumPoints, dataCenter);
            GetReport();
        }
        /// <summary>
        /// 保存示意图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            保存示意图ToolStripMenuItem_Click(sender,e);
        }
        /// <summary>
        /// 保存报告
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
