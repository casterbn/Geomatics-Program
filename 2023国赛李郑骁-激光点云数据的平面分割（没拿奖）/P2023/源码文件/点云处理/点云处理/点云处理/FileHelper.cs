using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 点云处理
{
    class FileHelper
    {

        public void ReadFile(DataCenter data)
        {


            try
            {
                OpenFileDialog opf = new OpenFileDialog();  // 创建打开文件对话框
                opf.Filter = "文本文件|*.txt";
                opf.Title = "请选择要导入的文件";
                if (opf.ShowDialog() == DialogResult.OK)    // 弹出打开文件对话框
                {
                    StreamReader sr = new StreamReader(opf.FileName);   // 创建 StreamReader 对象


                    data.Points = new List<Point>();
                    Point point ;

                    string line = sr.ReadLine();
                    string[] lines;
                    data.PointCount = int.Parse(line);

                    for (int i = 0; i < data.PointCount; i++)
                    {
                        lines = sr.ReadLine().Trim().Split(',');
                        point = new Point(lines[0], double.Parse(lines[1]), double.Parse(lines[2]),double.Parse(lines[3]));
                        data.Points.Add(point);

                    }

                    
                    MessageBox.Show("导入数据文件成功！");
                }
            else
            {
                MessageBox.Show("文件打开失败！");
            }

        }
            catch (Exception)
            {
                MessageBox.Show("文件导入失败，请重新导入！");
                throw;
            }





}


    }
}
