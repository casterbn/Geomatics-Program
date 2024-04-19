using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace 利用构建不规则三角网_TIN_进行体积计算
{

    public partial class Form1 : Form
    {

        Datacenter datacenter = new Datacenter();
        string Report = "";
        double zoom = 3;
        Point[] go = { new Point(0, 0), new Point(0, 0) };
        PointF[] p;
        PointF[] ph;
        PointF[] tp;
        Point[] q;
        Point[] qh;
        Point[] tq;
        List<CreatTin.Triangle> T = new List<CreatTin.Triangle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void 导入数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadIn();
        }
        /// <summary>
        /// 文件读取
        /// </summary>
        public void ReadIn()
        {
            if (datacenter.GivenPoints.Count!=0)
            {
                datacenter.GivenPoints.Clear();
                datacenter.Convex_Hull.Clear();
                datacenter.FourPeaks.Clear();
                datacenter.NoneConvexPoints.Clear();
                dataGridView1.Rows.Clear();
                Report = "";
            }

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "文本文件|*.txt";
            opf.Title = "请选择要导入的数据文件";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(opf.FileName);
                int givenPointNum = 0;

                while (!sr.EndOfStream)
                {
                    PointF gPoint = new PointF();
                    string[] line = sr.ReadLine().Trim().Split(',');
                    if (line.Length == 2)
                    {
                        datacenter.HeightDatum = double.Parse(line[1]);
                    }
                    else if (line.Length == 4)
                    {
                        gPoint.Name = line[0];
                        gPoint.X = double.Parse(line[1]);
                        gPoint.Y = double.Parse(line[2]);
                        gPoint.H = double.Parse(line[3]);
                        datacenter.GivenPoints.Add(gPoint);
                        givenPointNum++;
                    }
                }
            }
            dataGridView1.RowCount = datacenter.GivenPoints.Count;
            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = datacenter.GivenPoints[i].Name;
                dataGridView1.Rows[i].Cells[1].Value = datacenter.GivenPoints[i].X;
                dataGridView1.Rows[i].Cells[2].Value = datacenter.GivenPoints[i].Y;
                dataGridView1.Rows[i].Cells[3].Value = datacenter.GivenPoints[i].H;
            }

            DrawPoints(go[0], zoom);
        }
        /// <summary>
        /// 画散点
        /// </summary>
        /// <param name="g"></param>
        /// <param name="zoom"></param>
        public void DrawPoints(Point g, double zoom)
        {
            double xAverage = 0;
            double yAverage = 0;
            double xMax = 0;
            double yMax = 0;
            p = new PointF[datacenter.GivenPoints.Count];
            q = new Point[datacenter.GivenPoints.Count];
            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                p[i] = new PointF(datacenter.GivenPoints[i].X, datacenter.GivenPoints[i].Y);
                xAverage += p[i].X;
                yAverage += p[i].Y;
            }
            xAverage /= datacenter.GivenPoints.Count;
            yAverage /= datacenter.GivenPoints.Count;

            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                p[i].X -= xAverage;
                p[i].Y -= yAverage;
                if (xMax < p[i].X)
                {
                    xMax = p[i].X;
                }
                if (yMax < p[i].Y)
                {
                    yMax = p[i].Y;
                }
            }
            int picHeight = pictureBox1.Size.Height;
            int picWidth = pictureBox1.Size.Width;
            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                q[i].X = (int)(picWidth / 2 + g.X + p[i].X * picHeight / zoom / xMax);
                q[i].Y = (int)(picHeight / 2 - g.Y - p[i].Y * picHeight / zoom / xMax);
            }

            Bitmap bmp = new Bitmap(picWidth, picHeight);
            Image img = bmp;
            Graphics gra = Graphics.FromImage(img);

            Bitmap redDotb = new Bitmap(3, 3);
            Image redDoti = redDotb;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    redDotb.SetPixel(i, j, Color.Black);
                }
            }
            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                gra.DrawImage(redDoti, q[i].X, q[i].Y);
            }
            pictureBox1.Image = img;

        }

        /// <summary>
        /// 画凸包线
        /// </summary>
        /// <param name="g"></param>
        /// <param name="zoom"></param>
        public void DrawCHLines(Point g,double zoom)
        {
            double xAverage=0;
            double yAverage = 0;
            double xMax = 0;
            double yMax = 0;
            p = new PointF[datacenter.GivenPoints.Count];
            q = new Point[datacenter.GivenPoints.Count];
            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                p[i] = new PointF(datacenter.GivenPoints[i].X, datacenter.GivenPoints[i].Y);
                xAverage += p[i].X;
                yAverage += p[i].Y;
            }
            xAverage /= datacenter.GivenPoints.Count;
            yAverage /= datacenter.GivenPoints.Count;

            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                p[i].X -= xAverage;
                p[i].Y -= yAverage;
                if (xMax<p[i].X)
                {
                    xMax = p[i].X;
                }
                if (yMax<p[i].Y)
                {
                    yMax = p[i].Y;
                }
            }
            int picHeight = pictureBox1.Size.Height;
            int picWidth = pictureBox1.Size.Width;
            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                q[i].X = (int)(picWidth / 2 + g.X + p[i].X * picHeight / zoom / xMax);
                q[i].Y = (int)(picHeight / 2 - g.Y -p[i].Y * picHeight / zoom / xMax);   
            }

            Bitmap bmp = new Bitmap(picWidth, picHeight);
            Image img = bmp;
            Graphics gra = Graphics.FromImage(img);

            Bitmap redDotb = new Bitmap(3 , 3);
            Image redDoti = redDotb;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    redDotb.SetPixel(i, j, Color.Black);
                }
            }
            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                gra.DrawImage(redDoti,q[i].X,q[i].Y);
            }


            ph = new PointF[datacenter.Convex_Hull.Count];
            qh = new Point[datacenter.Convex_Hull.Count];
            for (int i = 0; i < datacenter.Convex_Hull.Count; i++)
            {
                ph[i] = new PointF(datacenter.Convex_Hull[i].X, datacenter.Convex_Hull[i].Y);
                ph[i].X -= xAverage;
                ph[i].Y -= yAverage;
                qh[i].Y = (int)(picHeight / 2 - g.Y - ph[i].Y * picHeight / zoom / xMax);
                qh[i].X = (int)(picWidth / 2 + g.X + ph[i].X * picHeight / zoom / xMax);
            }
            Pen pen = new Pen(Color.Red,1);
            gra.DrawLines(pen, qh);

            Bitmap chpb = new Bitmap(4, 4);
            Image chpi = chpb;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    chpb.SetPixel(i, j, Color.Red);
                }
            }
            for (int i = 0; i < datacenter.Convex_Hull.Count; i++)
            {
                gra.DrawImage(chpi, qh[i].X,qh[i].Y);
            }

            pictureBox1.Image = img;
            tabControl1.SelectedIndex = 1;
        }
        /// <summary>
        /// 画三角形
        /// </summary>
        /// <param name="a"></param>
        /// <param name="zoom"></param>
        public void DrawTriAngle(Point g,double zoom)
        {
            double xAverage = 0;
            double yAverage = 0;
            double xMax = 0;
            double yMax = 0;
            p = new PointF[datacenter.GivenPoints.Count];
            q = new Point[datacenter.GivenPoints.Count];
            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                p[i] = new PointF(datacenter.GivenPoints[i].X, datacenter.GivenPoints[i].Y);
                xAverage += p[i].X;
                yAverage += p[i].Y;
            }
            xAverage /= datacenter.GivenPoints.Count;
            yAverage /= datacenter.GivenPoints.Count;

            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                p[i].X -= xAverage;
                p[i].Y -= yAverage;
                if (xMax < p[i].X)
                {
                    xMax = p[i].X;
                }
                if (yMax < p[i].Y)
                {
                    yMax = p[i].Y;
                }
            }
            int picHeight = pictureBox1.Size.Height;
            int picWidth = pictureBox1.Size.Width;
            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                q[i].X = (int)(picWidth / 2 + g.X + p[i].X * picHeight / zoom / xMax);
                q[i].Y = (int)(picHeight / 2 - g.Y - p[i].Y * picHeight / zoom / xMax);
            }

            Bitmap bmp = new Bitmap(picWidth, picHeight);
            Image img = bmp;
            Graphics gra = Graphics.FromImage(img);

            Bitmap redDotb = new Bitmap(3, 3);
            Image redDoti = redDotb;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    redDotb.SetPixel(i, j, Color.Black);
                }
            }
            for (int i = 0; i < datacenter.GivenPoints.Count; i++)
            {
                gra.DrawImage(redDoti, q[i].X, q[i].Y);
            }


            ph = new PointF[datacenter.Convex_Hull.Count];
            qh = new Point[datacenter.Convex_Hull.Count];
            for (int i = 0; i < datacenter.Convex_Hull.Count; i++)
            {
                ph[i] = new PointF(datacenter.Convex_Hull[i].X, datacenter.Convex_Hull[i].Y);
                ph[i].X -= xAverage;
                ph[i].Y -= yAverage;
                qh[i].Y = (int)(picHeight / 2 - g.Y - ph[i].Y * picHeight / zoom / xMax);
                qh[i].X = (int)(picWidth / 2 + g.X + ph[i].X * picHeight / zoom / xMax);
            }
            Pen pen = new Pen(Color.Red, 1);
            gra.DrawLines(pen, qh);

            Bitmap chpb = new Bitmap(4, 4);
            Image chpi = chpb;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    chpb.SetPixel(i, j, Color.Red);
                }
            }
            for (int i = 0; i < datacenter.Convex_Hull.Count; i++)
            {
                gra.DrawImage(chpi, qh[i].X, qh[i].Y);
            }


            for (int i= 0; i <T.Count; i++)
            {
                tp = new PointF[3];
                tq = new Point[3];
                for (int j = 0; j < 3; j++)
                {
                    tp[j] = new PointF(T[i].TP[j].X,T[i].TP[j].Y);
                    tp[j].X -= xAverage;
                    tp[j].Y -= yAverage;
                    tq[j].Y = (int)(picHeight / 2 - g.Y - tp[j].Y * picHeight / zoom / xMax);
                    tq[j].X = (int)(picWidth / 2 + g.X + tp[j].X * picHeight / zoom / xMax);
                }
                Pen grpen = new Pen(Color.Gray);
                gra.DrawLines(grpen, tq);
            }




            pictureBox1.Image = img;
            tabControl1.SelectedIndex = 1;
        }

        /// <summary>
        /// 输出报告
        /// </summary>
        public void GetReport()
        {
            Report = "";

            Report += "————————————四个顶点——————————————\r\n\r\n";
            for (int i = 0; i < datacenter.FourPeaks.Count; i++)
            {
                Report += "P" + (i+1) + " :   点名：" + datacenter.FourPeaks[i].Name +
                    "   X坐标：" + datacenter.FourPeaks[i].X.ToString() +
                    "   Y坐标：" + datacenter.FourPeaks[i].Y.ToString() +"\r\n";
            }
            Report += "\r\n\r\n";
            Report += "————————————凸包点——————————————\r\n\r\n";
            for (int i = 0; i < datacenter.Convex_Hull.Count; i++)
            {
                Report += "序号" + (i + 1) + " :   点名：" + datacenter.Convex_Hull[i].Name +
                    "   X坐标：" + datacenter.Convex_Hull[i].X.ToString() +
                    "   Y坐标：" + datacenter.Convex_Hull[i].Y.ToString() + "\r\n";
            }

            Report += "\r\n\r\n\r\n";
            Report += "————————————三角形——————————————\r\n\r\n";
            for (int i = 0; i < T.Count; i++)
            {
                Report += "序号：" + (i + 1)+"\r\n";
                for (int j = 0; j < 3; j++)
                {
                    Report +=":     点名：" + T[i].TP[j].Name +
                        "   X坐标：" + T[i].TP[j].X.ToString() +
                        "   Y坐标：" + T[i].TP[j].Y.ToString() + 
                        "   H坐标：" + T[i].TP[j].H.ToString()+"\r\n";
                }

            }
            textBox1.Text = Report;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            zoom *= 0.9;
            DrawTriAngle(go[0], zoom);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            zoom *= 1.1;
            DrawTriAngle(go[0], zoom);

        }

        private void 生成凸包ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datacenter.GivenPoints.Count==0)
            {
                MessageBox.Show("请先导入数据文件");
                return;
            }
            Convex convex = new Convex();
            convex.FCH(datacenter);
            DrawCHLines(go[0],zoom);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReadIn();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (datacenter.GivenPoints.Count == 0)
            {
                MessageBox.Show("请先导入数据文件");
                return;
            }
            Convex convex = new Convex();
            convex.FCH(datacenter);
            DrawCHLines(go[0], zoom);
        }

        private void 保存报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datacenter.GivenPoints.Count==0||datacenter.Convex_Hull.Count==0)
            {
                return;
            }
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "文本文件|*.txt";
            if (svf.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(svf.FileName);
                sw.Write(Report);
            }
        }

        private void 保存示意图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "图形文件|*.jpg";
            if (svf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(svf.FileName);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (datacenter.GivenPoints.Count == 0)
            {
                MessageBox.Show("请先导入数据文件");
                return;
            }
            Convex convex = new Convex();
            convex.FCH(datacenter);
            DrawCHLines(go[0], zoom);
            CreatTin creattin = new CreatTin();
            creattin.CreateInitTIN(datacenter);
            creattin.CreatePlaneTIN(datacenter);
            T = creattin.T1;
            DrawTriAngle(go[0], zoom);
            
            GetReport();
            dataGridView2.RowCount = T.Count;
            for (int i = 0; i < T.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = i;
                dataGridView2.Rows[i].Cells[1].Value = T[i].TP[0].Name;
                dataGridView2.Rows[i].Cells[2].Value = T[i].TP[1].Name;
                dataGridView2.Rows[i].Cells[3].Value = T[i].TP[2].Name;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CreatTin creattin = new CreatTin();
            creattin.CreateInitTIN(datacenter);
            creattin.CreatePlaneTIN(datacenter);
            T = creattin.T1;
            DrawTriAngle(go[0],zoom);
        }

        private void 生成三角形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatTin creattin = new CreatTin();
            creattin.CreateInitTIN(datacenter);
            creattin.CreatePlaneTIN(datacenter);
            T = creattin.T1;
            DrawTriAngle(go[0], zoom);
        }
    }
}
