namespace 点云处理
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入数据文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.获取XYZ分量的最值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点云数据栅格化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算栅格单元的几何特征信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平面拟合ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输出结果文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.计算ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 620);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(886, 29);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 588);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据表格";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1059, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "计算报告";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入数据文件ToolStripMenuItem,
            this.输出结果文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 导入数据文件ToolStripMenuItem
            // 
            this.导入数据文件ToolStripMenuItem.Name = "导入数据文件ToolStripMenuItem";
            this.导入数据文件ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.导入数据文件ToolStripMenuItem.Text = "导入数据文件";
            this.导入数据文件ToolStripMenuItem.Click += new System.EventHandler(this.导入数据文件ToolStripMenuItem_Click);
            // 
            // 计算ToolStripMenuItem
            // 
            this.计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.获取XYZ分量的最值ToolStripMenuItem,
            this.点云数据栅格化ToolStripMenuItem,
            this.计算栅格单元的几何特征信息ToolStripMenuItem,
            this.平面拟合ToolStripMenuItem});
            this.计算ToolStripMenuItem.Name = "计算ToolStripMenuItem";
            this.计算ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.计算ToolStripMenuItem.Text = "计算";
            this.计算ToolStripMenuItem.Click += new System.EventHandler(this.计算ToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(136, 24);
            this.toolStripStatusLabel1.Text = "导入数据状态：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(154, 24);
            this.toolStripStatusLabel2.Text = "还未导入数据文件";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(285, 24);
            this.toolStripStatusLabel3.Text = "                                                       ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(100, 24);
            this.toolStripStatusLabel4.Text = "计算状态：";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(118, 24);
            this.toolStripStatusLabel5.Text = "还未开始计算";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(872, 550);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1053, 464);
            this.textBox1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "点名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "X";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Y";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Z";
            this.Column4.Name = "Column4";
            // 
            // 获取XYZ分量的最值ToolStripMenuItem
            // 
            this.获取XYZ分量的最值ToolStripMenuItem.Name = "获取XYZ分量的最值ToolStripMenuItem";
            this.获取XYZ分量的最值ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.获取XYZ分量的最值ToolStripMenuItem.Text = "获取XYZ分量的最值";
            this.获取XYZ分量的最值ToolStripMenuItem.Click += new System.EventHandler(this.获取XYZ分量的最值ToolStripMenuItem_Click);
            // 
            // 点云数据栅格化ToolStripMenuItem
            // 
            this.点云数据栅格化ToolStripMenuItem.Name = "点云数据栅格化ToolStripMenuItem";
            this.点云数据栅格化ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.点云数据栅格化ToolStripMenuItem.Text = "点云数据栅格化";
            this.点云数据栅格化ToolStripMenuItem.Click += new System.EventHandler(this.点云数据栅格化ToolStripMenuItem_Click);
            // 
            // 计算栅格单元的几何特征信息ToolStripMenuItem
            // 
            this.计算栅格单元的几何特征信息ToolStripMenuItem.Name = "计算栅格单元的几何特征信息ToolStripMenuItem";
            this.计算栅格单元的几何特征信息ToolStripMenuItem.Size = new System.Drawing.Size(326, 30);
            this.计算栅格单元的几何特征信息ToolStripMenuItem.Text = "计算栅格单元的几何特征信息";
            this.计算栅格单元的几何特征信息ToolStripMenuItem.Click += new System.EventHandler(this.计算栅格单元的几何特征信息ToolStripMenuItem_Click);
            // 
            // 平面拟合ToolStripMenuItem
            // 
            this.平面拟合ToolStripMenuItem.Name = "平面拟合ToolStripMenuItem";
            this.平面拟合ToolStripMenuItem.Size = new System.Drawing.Size(326, 30);
            this.平面拟合ToolStripMenuItem.Text = "平面拟合";
            this.平面拟合ToolStripMenuItem.Click += new System.EventHandler(this.平面拟合ToolStripMenuItem_Click);
            // 
            // 输出结果文件ToolStripMenuItem
            // 
            this.输出结果文件ToolStripMenuItem.Name = "输出结果文件ToolStripMenuItem";
            this.输出结果文件ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.输出结果文件ToolStripMenuItem.Text = "输出结果文件";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 649);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "激光点云数据的平面分割";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入数据文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem 获取XYZ分量的最值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点云数据栅格化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算栅格单元的几何特征信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平面拟合ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输出结果文件ToolStripMenuItem;
    }
}

