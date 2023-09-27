namespace quanlinhanvien
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tendangnhap = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttondangnhap = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonthoat2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.buttonthoat2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 118);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(117, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần mềm quản lí nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tendangnhap);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(273, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 51);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // tendangnhap
            // 
            this.tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendangnhap.Location = new System.Drawing.Point(172, 11);
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Size = new System.Drawing.Size(195, 31);
            this.tendangnhap.TabIndex = 3;
            this.tendangnhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.matkhau);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(273, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 51);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // matkhau
            // 
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.matkhau.Location = new System.Drawing.Point(172, 11);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(195, 31);
            this.matkhau.TabIndex = 3;
            this.matkhau.UseSystemPasswordChar = true;
            this.matkhau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttondangnhap
            // 
            this.buttondangnhap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttondangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondangnhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttondangnhap.Location = new System.Drawing.Point(247, 334);
            this.buttondangnhap.Name = "buttondangnhap";
            this.buttondangnhap.Size = new System.Drawing.Size(168, 41);
            this.buttondangnhap.TabIndex = 3;
            this.buttondangnhap.Text = "Đăng nhập:";
            this.buttondangnhap.UseVisualStyleBackColor = false;
            this.buttondangnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.Color.DarkRed;
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonthoat.Location = new System.Drawing.Point(500, 334);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(168, 41);
            this.buttonthoat.TabIndex = 4;
            this.buttonthoat.Text = "Thoát!!!";
            this.buttonthoat.UseVisualStyleBackColor = false;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // buttonthoat2
            // 
            this.buttonthoat2.BackColor = System.Drawing.Color.DarkRed;
            this.buttonthoat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthoat2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonthoat2.Location = new System.Drawing.Point(761, 3);
            this.buttonthoat2.Name = "buttonthoat2";
            this.buttonthoat2.Size = new System.Drawing.Size(38, 33);
            this.buttonthoat2.TabIndex = 5;
            this.buttonthoat2.Text = "X";
            this.buttonthoat2.UseVisualStyleBackColor = false;
            this.buttonthoat2.Click += new System.EventHandler(this.buttonthoat2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 244);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttondangnhap);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tendangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttondangnhap;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonthoat2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

