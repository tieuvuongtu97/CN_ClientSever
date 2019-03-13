namespace QL_Baixe_app
{
    partial class frqlve
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
            this.btnvengay = new System.Windows.Forms.Button();
            this.btnvethang = new System.Windows.Forms.Button();
            this.btnusing = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvengay
            // 
            this.btnvengay.Location = new System.Drawing.Point(29, 50);
            this.btnvengay.Name = "btnvengay";
            this.btnvengay.Size = new System.Drawing.Size(109, 23);
            this.btnvengay.TabIndex = 0;
            this.btnvengay.Text = "vé ngày ";
            this.btnvengay.UseVisualStyleBackColor = true;
            this.btnvengay.Click += new System.EventHandler(this.btnvengay_Click);
            // 
            // btnvethang
            // 
            this.btnvethang.Location = new System.Drawing.Point(201, 49);
            this.btnvethang.Name = "btnvethang";
            this.btnvethang.Size = new System.Drawing.Size(109, 23);
            this.btnvethang.TabIndex = 1;
            this.btnvethang.Text = "vé tháng";
            this.btnvethang.UseVisualStyleBackColor = true;
            this.btnvethang.Click += new System.EventHandler(this.btnvethang_Click);
            // 
            // btnusing
            // 
            this.btnusing.Location = new System.Drawing.Point(383, 49);
            this.btnusing.Name = "btnusing";
            this.btnusing.Size = new System.Drawing.Size(107, 23);
            this.btnusing.TabIndex = 2;
            this.btnusing.Text = "vé đang sử dụng";
            this.btnusing.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(552, 49);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(108, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "thêm vé";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dtgv
            // 
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(29, 113);
            this.dtgv.Name = "dtgv";
            this.dtgv.Size = new System.Drawing.Size(631, 185);
            this.dtgv.TabIndex = 4;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(585, 307);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frqlve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(685, 342);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnusing);
            this.Controls.Add(this.btnvethang);
            this.Controls.Add(this.btnvengay);
            this.Name = "frqlve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frqlve";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvengay;
        private System.Windows.Forms.Button btnvethang;
        private System.Windows.Forms.Button btnusing;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btnexit;
    }
}