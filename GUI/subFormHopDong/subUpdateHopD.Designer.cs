namespace GUI
{
    partial class subUpdateHopD
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
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dateTimeNL = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(165, 73);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(228, 20);
            this.txtMa.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNL
            // 
            this.txtNL.Location = new System.Drawing.Point(165, 154);
            this.txtNL.Name = "txtNL";
            this.txtNL.Size = new System.Drawing.Size(228, 20);
            this.txtNL.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nơi lập";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(108, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 22);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "CẬP NHẬT HỢP ĐỒNG";
            // 
            // dateTimeNL
            // 
            this.dateTimeNL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNL.Location = new System.Drawing.Point(164, 114);
            this.dateTimeNL.Name = "dateTimeNL";
            this.dateTimeNL.Size = new System.Drawing.Size(228, 20);
            this.dateTimeNL.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ngày lập";
            // 
            // subUpdateHopD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 269);
            this.Controls.Add(this.dateTimeNL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle);
            this.Name = "subUpdateHopD";
            this.Text = "subUpdateHopD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dateTimeNL;
        private System.Windows.Forms.Label label2;
    }
}