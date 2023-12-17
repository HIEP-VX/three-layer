namespace GUI
{
    partial class frmDoanhThuHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDTTT = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDTTT);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbThang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 69);
            this.panel1.TabIndex = 1;
            // 
            // btnDTTT
            // 
            this.btnDTTT.Location = new System.Drawing.Point(595, 20);
            this.btnDTTT.Name = "btnDTTT";
            this.btnDTTT.Size = new System.Drawing.Size(191, 34);
            this.btnDTTT.TabIndex = 5;
            this.btnDTTT.Text = "Doanh thu từng tháng";
            this.btnDTTT.UseVisualStyleBackColor = true;
            this.btnDTTT.Click += new System.EventHandler(this.btnDTTT_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(445, 20);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(127, 34);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(336, 23);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(95, 26);
            this.txtNam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Theo Năm";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(106, 23);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(95, 26);
            this.cbThang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theo tháng";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 441);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 37);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 404);
            this.panel6.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(246, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 37);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tóm tắt";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(246, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 438);
            this.panel4.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.chart1);
            this.panel7.Controls.Add(this.dataGridView2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(556, 401);
            this.panel7.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "thống kê";
            series1.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(556, 401);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(556, 401);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(556, 37);
            this.panel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chi tiết";
            // 
            // frmDoanhThuHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 501);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDoanhThuHD";
            this.Text = "frmDoanhThuHD";
            this.Load += new System.EventHandler(this.frmDoanhThuHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDTTT;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}