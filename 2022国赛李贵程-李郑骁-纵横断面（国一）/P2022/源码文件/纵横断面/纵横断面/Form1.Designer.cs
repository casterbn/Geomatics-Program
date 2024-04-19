namespace 纵横断面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入数据文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存示意图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存计算报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.纵断面计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.横断面计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算角度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算纵断面长度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算内插高程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算梯形面积ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算横断面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.计算ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入数据文件ToolStripMenuItem,
            this.保存示意图ToolStripMenuItem,
            this.保存计算报告ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.文件ToolStripMenuItem.Text = "文件（&F）";
            // 
            // 导入数据文件ToolStripMenuItem
            // 
            this.导入数据文件ToolStripMenuItem.Name = "导入数据文件ToolStripMenuItem";
            this.导入数据文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.导入数据文件ToolStripMenuItem.Text = "导入数据文件";
            this.导入数据文件ToolStripMenuItem.Click += new System.EventHandler(this.导入数据文件ToolStripMenuItem_Click);
            // 
            // 保存示意图ToolStripMenuItem
            // 
            this.保存示意图ToolStripMenuItem.Name = "保存示意图ToolStripMenuItem";
            this.保存示意图ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.保存示意图ToolStripMenuItem.Text = "保存示意图";
            this.保存示意图ToolStripMenuItem.Click += new System.EventHandler(this.保存示意图ToolStripMenuItem_Click);
            // 
            // 保存计算报告ToolStripMenuItem
            // 
            this.保存计算报告ToolStripMenuItem.Name = "保存计算报告ToolStripMenuItem";
            this.保存计算报告ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.保存计算报告ToolStripMenuItem.Text = "保存计算报告";
            this.保存计算报告ToolStripMenuItem.Click += new System.EventHandler(this.保存计算报告ToolStripMenuItem_Click);
            // 
            // 计算ToolStripMenuItem
            // 
            this.计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.纵断面计算ToolStripMenuItem,
            this.横断面计算ToolStripMenuItem,
            this.测试ToolStripMenuItem});
            this.计算ToolStripMenuItem.Name = "计算ToolStripMenuItem";
            this.计算ToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.计算ToolStripMenuItem.Text = "计算（&C）";
            // 
            // 纵断面计算ToolStripMenuItem
            // 
            this.纵断面计算ToolStripMenuItem.Name = "纵断面计算ToolStripMenuItem";
            this.纵断面计算ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.纵断面计算ToolStripMenuItem.Text = "纵断面计算";
            this.纵断面计算ToolStripMenuItem.Click += new System.EventHandler(this.纵断面计算ToolStripMenuItem_Click);
            // 
            // 横断面计算ToolStripMenuItem
            // 
            this.横断面计算ToolStripMenuItem.Name = "横断面计算ToolStripMenuItem";
            this.横断面计算ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.横断面计算ToolStripMenuItem.Text = "横断面计算";
            this.横断面计算ToolStripMenuItem.Click += new System.EventHandler(this.横断面计算ToolStripMenuItem_Click);
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算角度ToolStripMenuItem,
            this.计算纵断面长度ToolStripMenuItem,
            this.计算内插高程ToolStripMenuItem,
            this.计算梯形面积ToolStripMenuItem,
            this.计算横断面ToolStripMenuItem});
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.测试ToolStripMenuItem.Text = "测试";
            // 
            // 计算角度ToolStripMenuItem
            // 
            this.计算角度ToolStripMenuItem.Name = "计算角度ToolStripMenuItem";
            this.计算角度ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.计算角度ToolStripMenuItem.Text = "计算角度";
            this.计算角度ToolStripMenuItem.Click += new System.EventHandler(this.计算角度ToolStripMenuItem_Click);
            // 
            // 计算纵断面长度ToolStripMenuItem
            // 
            this.计算纵断面长度ToolStripMenuItem.Name = "计算纵断面长度ToolStripMenuItem";
            this.计算纵断面长度ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.计算纵断面长度ToolStripMenuItem.Text = "计算纵断面长度";
            this.计算纵断面长度ToolStripMenuItem.Click += new System.EventHandler(this.计算纵断面长度ToolStripMenuItem_Click);
            // 
            // 计算内插高程ToolStripMenuItem
            // 
            this.计算内插高程ToolStripMenuItem.Name = "计算内插高程ToolStripMenuItem";
            this.计算内插高程ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.计算内插高程ToolStripMenuItem.Text = "计算内插高程";
            this.计算内插高程ToolStripMenuItem.Click += new System.EventHandler(this.计算内插高程ToolStripMenuItem_Click);
            // 
            // 计算梯形面积ToolStripMenuItem
            // 
            this.计算梯形面积ToolStripMenuItem.Name = "计算梯形面积ToolStripMenuItem";
            this.计算梯形面积ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.计算梯形面积ToolStripMenuItem.Text = "计算梯形面积";
            this.计算梯形面积ToolStripMenuItem.Click += new System.EventHandler(this.计算梯形面积ToolStripMenuItem_Click);
            // 
            // 计算横断面ToolStripMenuItem
            // 
            this.计算横断面ToolStripMenuItem.Name = "计算横断面ToolStripMenuItem";
            this.计算横断面ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.计算横断面ToolStripMenuItem.Text = "计算横断面";
            this.计算横断面ToolStripMenuItem.Click += new System.EventHandler(this.计算横断面ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(608, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(108, 52);
            this.toolStripButton1.Text = "读取文件";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(108, 52);
            this.toolStripButton2.Text = "一键计算";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(108, 52);
            this.toolStripButton3.Text = "保存报告";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(120, 52);
            this.toolStripButton4.Text = "保存示意图";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 315);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据表格";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(594, 283);
            this.dataGridView1.TabIndex = 0;
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
            this.Column4.HeaderText = "H";
            this.Column4.Name = "Column4";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "示意图";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(594, 283);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(600, 289);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "计算报告";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(594, 283);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 395);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "纵横断面计算";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入数据文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存示意图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存计算报告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 纵断面计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 横断面计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算角度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算纵断面长度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算内插高程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算梯形面积ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算横断面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

