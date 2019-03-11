namespace QL_Baixe_app
{
    partial class frHome
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
            this.btkhongcogi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAcc = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnDangky = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btkhongcogi
            // 
            this.btkhongcogi.BackColor = System.Drawing.Color.White;
            this.btkhongcogi.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btkhongcogi.ForeColor = System.Drawing.Color.Red;
            this.btkhongcogi.Location = new System.Drawing.Point(-17, 12);
            this.btkhongcogi.Name = "btkhongcogi";
            this.btkhongcogi.Size = new System.Drawing.Size(1054, 40);
            this.btkhongcogi.TabIndex = 112;
            this.btkhongcogi.Text = "HỆ THỐNG QUẢN LÍ BÃI GỬI XE";
            this.btkhongcogi.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 170);
            this.button3.TabIndex = 115;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 170);
            this.button4.TabIndex = 116;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "Xin chào!";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbAcc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-17, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 507);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            // 
            // lbAcc
            // 
            this.lbAcc.AutoSize = true;
            this.lbAcc.ForeColor = System.Drawing.Color.Red;
            this.lbAcc.Location = new System.Drawing.Point(75, 18);
            this.lbAcc.Name = "lbAcc";
            this.lbAcc.Size = new System.Drawing.Size(25, 13);
            this.lbAcc.TabIndex = 119;
            this.lbAcc.Text = "acc";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundImage = global::QL_Baixe_app.Properties.Resources.icons8_shutdown_80;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.Location = new System.Drawing.Point(890, 58);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 31);
            this.btnLogout.TabIndex = 117;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BackgroundImage = global::QL_Baixe_app.Properties.Resources.icons8_account_80;
            this.btnThongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThongke.ForeColor = System.Drawing.Color.Red;
            this.btnThongke.Location = new System.Drawing.Point(623, 136);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(280, 170);
            this.btnThongke.TabIndex = 114;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThongke.UseVisualStyleBackColor = true;
            // 
            // btnDangky
            // 
            this.btnDangky.BackgroundImage = global::QL_Baixe_app.Properties.Resources.icons8_add_user_group_woman_man_401;
            this.btnDangky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDangky.ForeColor = System.Drawing.Color.Red;
            this.btnDangky.Location = new System.Drawing.Point(265, 136);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(280, 170);
            this.btnDangky.TabIndex = 113;
            this.btnDangky.Text = "Đăng kí khách hàng";
            this.btnDangky.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // frHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.btkhongcogi);
            this.Name = "frHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frHome";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btkhongcogi;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAcc;
    }
}