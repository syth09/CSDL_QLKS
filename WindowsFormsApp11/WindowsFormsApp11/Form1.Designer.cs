namespace WindowsFormsApp11
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_magv = new System.Windows.Forms.TextBox();
            this.bt_hienthi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_tengv = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_noict = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(561, 267);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã Giảng Viên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_magv
            // 
            this.tb_magv.Location = new System.Drawing.Point(732, 26);
            this.tb_magv.Name = "tb_magv";
            this.tb_magv.Size = new System.Drawing.Size(160, 22);
            this.tb_magv.TabIndex = 2;
            // 
            // bt_hienthi
            // 
            this.bt_hienthi.Location = new System.Drawing.Point(396, 398);
            this.bt_hienthi.Name = "bt_hienthi";
            this.bt_hienthi.Size = new System.Drawing.Size(177, 51);
            this.bt_hienthi.TabIndex = 3;
            this.bt_hienthi.Text = "Hiển Thị";
            this.bt_hienthi.UseVisualStyleBackColor = true;
            this.bt_hienthi.Click += new System.EventHandler(this.bt_hienthi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên Giảng Viên";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dien Thoai";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Email";
            this.label9.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(610, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nơi Công Tác";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_tengv
            // 
            this.tb_tengv.Location = new System.Drawing.Point(732, 71);
            this.tb_tengv.Name = "tb_tengv";
            this.tb_tengv.Size = new System.Drawing.Size(160, 22);
            this.tb_tengv.TabIndex = 2;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(732, 132);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(160, 22);
            this.tb_sdt.TabIndex = 2;
            // 
            // tb_noict
            // 
            this.tb_noict.Location = new System.Drawing.Point(732, 252);
            this.tb_noict.Name = "tb_noict";
            this.tb_noict.Size = new System.Drawing.Size(160, 22);
            this.tb_noict.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(732, 191);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(160, 22);
            this.tb_email.TabIndex = 2;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(661, 398);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(177, 51);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(921, 398);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(177, 51);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1164, 570);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_hienthi);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_noict);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_tengv);
            this.Controls.Add(this.tb_magv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_magv;
        private System.Windows.Forms.Button bt_hienthi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_tengv;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_noict;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
    }
}

