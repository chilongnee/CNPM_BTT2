namespace N4
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
            this.gridview = new System.Windows.Forms.DataGridView();
            this.lbl_dkhocphan = new System.Windows.Forms.Label();
            this.lbl_hovaten = new System.Windows.Forms.Label();
            this.lbl_lop = new System.Windows.Forms.Label();
            this.lbl_mssv = new System.Windows.Forms.Label();
            this.lbl_quequan = new System.Windows.Forms.Label();
            this.lbl_dsm = new System.Windows.Forms.Label();
            this.cbb_quequan = new System.Windows.Forms.ComboBox();
            this.txtbox_lop = new System.Windows.Forms.TextBox();
            this.txtbox_hovaten = new System.Windows.Forms.TextBox();
            this.txtbox_mssv = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(461, 152);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(240, 150);
            this.gridview.TabIndex = 0;
            this.gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_dkhocphan
            // 
            this.lbl_dkhocphan.AutoSize = true;
            this.lbl_dkhocphan.Location = new System.Drawing.Point(335, 23);
            this.lbl_dkhocphan.Name = "lbl_dkhocphan";
            this.lbl_dkhocphan.Size = new System.Drawing.Size(72, 13);
            this.lbl_dkhocphan.TabIndex = 1;
            this.lbl_dkhocphan.Text = "ĐK Học phần";
            // 
            // lbl_hovaten
            // 
            this.lbl_hovaten.AutoSize = true;
            this.lbl_hovaten.Location = new System.Drawing.Point(46, 72);
            this.lbl_hovaten.Name = "lbl_hovaten";
            this.lbl_hovaten.Size = new System.Drawing.Size(58, 13);
            this.lbl_hovaten.TabIndex = 2;
            this.lbl_hovaten.Text = "Họ và Tên";
            // 
            // lbl_lop
            // 
            this.lbl_lop.AutoSize = true;
            this.lbl_lop.Location = new System.Drawing.Point(46, 109);
            this.lbl_lop.Name = "lbl_lop";
            this.lbl_lop.Size = new System.Drawing.Size(25, 13);
            this.lbl_lop.TabIndex = 3;
            this.lbl_lop.Text = "Lop";
            // 
            // lbl_mssv
            // 
            this.lbl_mssv.AutoSize = true;
            this.lbl_mssv.Location = new System.Drawing.Point(46, 152);
            this.lbl_mssv.Name = "lbl_mssv";
            this.lbl_mssv.Size = new System.Drawing.Size(37, 13);
            this.lbl_mssv.TabIndex = 4;
            this.lbl_mssv.Text = "MSSV";
            // 
            // lbl_quequan
            // 
            this.lbl_quequan.AutoSize = true;
            this.lbl_quequan.Location = new System.Drawing.Point(401, 72);
            this.lbl_quequan.Name = "lbl_quequan";
            this.lbl_quequan.Size = new System.Drawing.Size(54, 13);
            this.lbl_quequan.TabIndex = 5;
            this.lbl_quequan.Text = "Quê quán";
            // 
            // lbl_dsm
            // 
            this.lbl_dsm.AutoSize = true;
            this.lbl_dsm.Location = new System.Drawing.Point(401, 149);
            this.lbl_dsm.Name = "lbl_dsm";
            this.lbl_dsm.Size = new System.Drawing.Size(45, 13);
            this.lbl_dsm.TabIndex = 6;
            this.lbl_dsm.Text = "DS môn";
            // 
            // cbb_quequan
            // 
            this.cbb_quequan.FormattingEnabled = true;
            this.cbb_quequan.Location = new System.Drawing.Point(461, 69);
            this.cbb_quequan.Name = "cbb_quequan";
            this.cbb_quequan.Size = new System.Drawing.Size(121, 21);
            this.cbb_quequan.TabIndex = 7;
            this.cbb_quequan.SelectedIndexChanged += new System.EventHandler(this.cbb_quequan_SelectedIndexChanged);
            // 
            // txtbox_lop
            // 
            this.txtbox_lop.Location = new System.Drawing.Point(110, 106);
            this.txtbox_lop.Name = "txtbox_lop";
            this.txtbox_lop.Size = new System.Drawing.Size(100, 20);
            this.txtbox_lop.TabIndex = 2;
            // 
            // txtbox_hovaten
            // 
            this.txtbox_hovaten.Location = new System.Drawing.Point(110, 69);
            this.txtbox_hovaten.Name = "txtbox_hovaten";
            this.txtbox_hovaten.Size = new System.Drawing.Size(100, 20);
            this.txtbox_hovaten.TabIndex = 1;
            // 
            // txtbox_mssv
            // 
            this.txtbox_mssv.Location = new System.Drawing.Point(110, 149);
            this.txtbox_mssv.Name = "txtbox_mssv";
            this.txtbox_mssv.Size = new System.Drawing.Size(100, 20);
            this.txtbox_mssv.TabIndex = 3;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(290, 357);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(371, 357);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.txtbox_mssv);
            this.Controls.Add(this.txtbox_hovaten);
            this.Controls.Add(this.txtbox_lop);
            this.Controls.Add(this.cbb_quequan);
            this.Controls.Add(this.lbl_dsm);
            this.Controls.Add(this.lbl_quequan);
            this.Controls.Add(this.lbl_mssv);
            this.Controls.Add(this.lbl_lop);
            this.Controls.Add(this.lbl_hovaten);
            this.Controls.Add(this.lbl_dkhocphan);
            this.Controls.Add(this.gridview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Label lbl_dkhocphan;
        private System.Windows.Forms.Label lbl_hovaten;
        private System.Windows.Forms.Label lbl_lop;
        private System.Windows.Forms.Label lbl_mssv;
        private System.Windows.Forms.Label lbl_quequan;
        private System.Windows.Forms.Label lbl_dsm;
        private System.Windows.Forms.ComboBox cbb_quequan;
        private System.Windows.Forms.TextBox txtbox_lop;
        private System.Windows.Forms.TextBox txtbox_hovaten;
        private System.Windows.Forms.TextBox txtbox_mssv;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
    }
}

