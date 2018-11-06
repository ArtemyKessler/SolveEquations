namespace Задача_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Degree = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelBox_4 = new System.Windows.Forms.Label();
            this.TextBox_4 = new System.Windows.Forms.TextBox();
            this.TextBox_3 = new System.Windows.Forms.TextBox();
            this.TextBox_2 = new System.Windows.Forms.TextBox();
            this.TextBox_1 = new System.Windows.Forms.TextBox();
            this.LabelBox_3 = new System.Windows.Forms.Label();
            this.LabelBox_2 = new System.Windows.Forms.Label();
            this.LabelBox_1 = new System.Windows.Forms.Label();
            this.TextBox_0 = new System.Windows.Forms.TextBox();
            this.LabelBox_0 = new System.Windows.Forms.Label();
            this.Solve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plot = new System.Windows.Forms.Button();
            this.Grapths = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.X_max = new System.Windows.Forms.TextBox();
            this.X_min = new System.Windows.Forms.TextBox();
            this.TextBox_5 = new System.Windows.Forms.TextBox();
            this.LabelBox_5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grapths)).BeginInit();
            this.SuspendLayout();
            // 
            // Degree
            // 
            this.Degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Degree.FormattingEnabled = true;
            this.Degree.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Degree.Location = new System.Drawing.Point(51, 23);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(32, 21);
            this.Degree.TabIndex = 0;
            this.Degree.SelectedIndexChanged += new System.EventHandler(this.Degree_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "n = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Решение уравнения ввида";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelBox_4
            // 
            this.LabelBox_4.AutoSize = true;
            this.LabelBox_4.Location = new System.Drawing.Point(239, 59);
            this.LabelBox_4.Name = "LabelBox_4";
            this.LabelBox_4.Size = new System.Drawing.Size(36, 13);
            this.LabelBox_4.TabIndex = 3;
            this.LabelBox_4.Text = "x^4 + ";
            this.LabelBox_4.Visible = false;
            this.LabelBox_4.Click += new System.EventHandler(this.LabelBox_4_Click);
            // 
            // TextBox_4
            // 
            this.TextBox_4.Location = new System.Drawing.Point(191, 56);
            this.TextBox_4.Name = "TextBox_4";
            this.TextBox_4.Size = new System.Drawing.Size(42, 20);
            this.TextBox_4.TabIndex = 5;
            this.TextBox_4.Text = "0";
            this.TextBox_4.Visible = false;
            this.TextBox_4.TextChanged += new System.EventHandler(this.TextBox_4_TextChanged);
            this.TextBox_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // TextBox_3
            // 
            this.TextBox_3.Location = new System.Drawing.Point(281, 56);
            this.TextBox_3.Name = "TextBox_3";
            this.TextBox_3.Size = new System.Drawing.Size(42, 20);
            this.TextBox_3.TabIndex = 8;
            this.TextBox_3.Text = "0";
            this.TextBox_3.Visible = false;
            this.TextBox_3.TextChanged += new System.EventHandler(this.TextBox_3_TextChanged);
            this.TextBox_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // TextBox_2
            // 
            this.TextBox_2.Location = new System.Drawing.Point(371, 56);
            this.TextBox_2.Name = "TextBox_2";
            this.TextBox_2.Size = new System.Drawing.Size(42, 20);
            this.TextBox_2.TabIndex = 9;
            this.TextBox_2.Text = "0";
            this.TextBox_2.Visible = false;
            this.TextBox_2.TextChanged += new System.EventHandler(this.TextBox_2_TextChanged);
            this.TextBox_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // TextBox_1
            // 
            this.TextBox_1.Location = new System.Drawing.Point(461, 56);
            this.TextBox_1.Name = "TextBox_1";
            this.TextBox_1.Size = new System.Drawing.Size(42, 20);
            this.TextBox_1.TabIndex = 10;
            this.TextBox_1.Text = "0";
            this.TextBox_1.Visible = false;
            this.TextBox_1.TextChanged += new System.EventHandler(this.TextBox_1_TextChanged);
            this.TextBox_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // LabelBox_3
            // 
            this.LabelBox_3.AutoSize = true;
            this.LabelBox_3.Location = new System.Drawing.Point(329, 59);
            this.LabelBox_3.Name = "LabelBox_3";
            this.LabelBox_3.Size = new System.Drawing.Size(36, 13);
            this.LabelBox_3.TabIndex = 12;
            this.LabelBox_3.Text = "x^3 + ";
            this.LabelBox_3.Visible = false;
            this.LabelBox_3.Click += new System.EventHandler(this.LabelBox_3_Click);
            // 
            // LabelBox_2
            // 
            this.LabelBox_2.AutoSize = true;
            this.LabelBox_2.Location = new System.Drawing.Point(419, 59);
            this.LabelBox_2.Name = "LabelBox_2";
            this.LabelBox_2.Size = new System.Drawing.Size(36, 13);
            this.LabelBox_2.TabIndex = 13;
            this.LabelBox_2.Text = "x^2 + ";
            this.LabelBox_2.Visible = false;
            this.LabelBox_2.Click += new System.EventHandler(this.LabelBox_2_Click);
            // 
            // LabelBox_1
            // 
            this.LabelBox_1.AutoSize = true;
            this.LabelBox_1.Location = new System.Drawing.Point(509, 59);
            this.LabelBox_1.Name = "LabelBox_1";
            this.LabelBox_1.Size = new System.Drawing.Size(24, 13);
            this.LabelBox_1.TabIndex = 14;
            this.LabelBox_1.Text = "x + ";
            this.LabelBox_1.Visible = false;
            this.LabelBox_1.Click += new System.EventHandler(this.LabelBox_1_Click);
            // 
            // TextBox_0
            // 
            this.TextBox_0.Location = new System.Drawing.Point(539, 56);
            this.TextBox_0.Name = "TextBox_0";
            this.TextBox_0.Size = new System.Drawing.Size(42, 20);
            this.TextBox_0.TabIndex = 15;
            this.TextBox_0.Text = "0";
            this.TextBox_0.Visible = false;
            this.TextBox_0.TextChanged += new System.EventHandler(this.TextBox_0_TextChanged);
            this.TextBox_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // LabelBox_0
            // 
            this.LabelBox_0.AutoSize = true;
            this.LabelBox_0.Location = new System.Drawing.Point(587, 59);
            this.LabelBox_0.Name = "LabelBox_0";
            this.LabelBox_0.Size = new System.Drawing.Size(25, 13);
            this.LabelBox_0.TabIndex = 16;
            this.LabelBox_0.Text = " = 0";
            this.LabelBox_0.Visible = false;
            this.LabelBox_0.Click += new System.EventHandler(this.LabelBox_0_Click);
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(537, 111);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(75, 23);
            this.Solve.TabIndex = 17;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView1.Location = new System.Drawing.Point(392, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(349, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 10;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 150;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 10;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // Plot
            // 
            this.Plot.Location = new System.Drawing.Point(154, 111);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(75, 23);
            this.Plot.TabIndex = 19;
            this.Plot.Text = "Plot";
            this.Plot.UseVisualStyleBackColor = true;
            this.Plot.Click += new System.EventHandler(this.Plot_Click);
            // 
            // Grapths
            // 
            this.Grapths.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.Grapths.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Grapths.Legends.Add(legend4);
            this.Grapths.Location = new System.Drawing.Point(12, 140);
            this.Grapths.Name = "Grapths";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "XY";
            series4.YValuesPerPoint = 2;
            this.Grapths.Series.Add(series4);
            this.Grapths.Size = new System.Drawing.Size(374, 300);
            this.Grapths.TabIndex = 21;
            this.Grapths.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(551, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Range";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(392, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 106);
            this.label4.TabIndex = 23;
            this.label4.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(470, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "X min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(635, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "X max";
            // 
            // X_max
            // 
            this.X_max.Location = new System.Drawing.Point(625, 384);
            this.X_max.Name = "X_max";
            this.X_max.Size = new System.Drawing.Size(57, 20);
            this.X_max.TabIndex = 25;
            this.X_max.Text = "2";
            this.X_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // X_min
            // 
            this.X_min.Location = new System.Drawing.Point(461, 384);
            this.X_min.Name = "X_min";
            this.X_min.Size = new System.Drawing.Size(58, 20);
            this.X_min.TabIndex = 24;
            this.X_min.Text = "-2";
            this.X_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // TextBox_5
            // 
            this.TextBox_5.Location = new System.Drawing.Point(101, 56);
            this.TextBox_5.Name = "TextBox_5";
            this.TextBox_5.Size = new System.Drawing.Size(42, 20);
            this.TextBox_5.TabIndex = 29;
            this.TextBox_5.Text = "0";
            this.TextBox_5.Visible = false;
            this.TextBox_5.TextChanged += new System.EventHandler(this.TextBox_5_TextChanged);
            // 
            // LabelBox_5
            // 
            this.LabelBox_5.AutoSize = true;
            this.LabelBox_5.Location = new System.Drawing.Point(149, 59);
            this.LabelBox_5.Name = "LabelBox_5";
            this.LabelBox_5.Size = new System.Drawing.Size(36, 13);
            this.LabelBox_5.TabIndex = 28;
            this.LabelBox_5.Text = "x^5 + ";
            this.LabelBox_5.Visible = false;
            this.LabelBox_5.Click += new System.EventHandler(this.LabelBox_5_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(392, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(349, 106);
            this.label7.TabIndex = 23;
            this.label7.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.TextBox_5);
            this.Controls.Add(this.LabelBox_5);
            this.Controls.Add(this.X_max);
            this.Controls.Add(this.X_min);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Grapths);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.LabelBox_0);
            this.Controls.Add(this.TextBox_0);
            this.Controls.Add(this.LabelBox_1);
            this.Controls.Add(this.LabelBox_2);
            this.Controls.Add(this.LabelBox_3);
            this.Controls.Add(this.TextBox_1);
            this.Controls.Add(this.TextBox_2);
            this.Controls.Add(this.TextBox_3);
            this.Controls.Add(this.TextBox_4);
            this.Controls.Add(this.LabelBox_4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grapths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Degree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelBox_4;
        private System.Windows.Forms.TextBox TextBox_3;
        private System.Windows.Forms.TextBox TextBox_2;
        private System.Windows.Forms.TextBox TextBox_1;
        private System.Windows.Forms.Label LabelBox_3;
        private System.Windows.Forms.Label LabelBox_2;
        private System.Windows.Forms.Label LabelBox_1;
        private System.Windows.Forms.TextBox TextBox_0;
        private System.Windows.Forms.Label LabelBox_0;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Plot;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grapths;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox X_max;
        private System.Windows.Forms.TextBox X_min;
        private System.Windows.Forms.TextBox TextBox_4;
        private System.Windows.Forms.TextBox TextBox_5;
        private System.Windows.Forms.Label LabelBox_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Label label7;
    }
}

