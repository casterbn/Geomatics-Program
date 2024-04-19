using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 点云处理
{
    public partial class Form1 : Form
    {
        DataCenter data=new DataCenter();


        public Form1()
        {
            InitializeComponent();
        }

        private void 导入数据文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHelper file = new FileHelper();
            file.ReadFile(data);
            toolStripStatusLabel2.Text = "已经导入数据文件";

            dataGridView1.RowCount = data.PointCount;
            for (int i = 0; i < data.PointCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = data.Points[i].Name;
                dataGridView1.Rows[i].Cells[1].Value = data.Points[i].X;
                dataGridView1.Rows[i].Cells[2].Value = data.Points[i].Y;
                dataGridView1.Rows[i].Cells[3].Value = data.Points[i].Z;

            }

        }

        private void 计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 获取XYZ分量的最值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal cal = new Cal();
            cal.GetMaxMinXYZ(data);
        }

        private void 点云数据栅格化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal cal = new Cal();
            cal.GetGrid(data);
        }

        private void 计算栅格单元的几何特征信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal cal = new Cal();
            cal.GetH(data);
        }

        private void 平面拟合ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal cal = new Cal();
            cal.PMNH(data);
        }
    }
}
