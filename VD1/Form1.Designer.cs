namespace VD1
{
    partial class frm_DangKy
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
            this.components = new System.ComponentModel.Container();
            this.lb_entername = new System.Windows.Forms.Label();
            this.tb_ho = new System.Windows.Forms.TextBox();
            this.btn_ho = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_hoten = new System.Windows.Forms.Label();
            this.btn_ten = new System.Windows.Forms.Button();
            this.btn_hoten = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_entername
            // 
            this.lb_entername.AutoSize = true;
            this.lb_entername.Location = new System.Drawing.Point(12, 23);
            this.lb_entername.Name = "lb_entername";
            this.lb_entername.Size = new System.Drawing.Size(90, 20);
            this.lb_entername.TabIndex = 0;
            this.lb_entername.Text = "Nhập họ lót";
            this.lb_entername.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_ho
            // 
            this.tb_ho.Location = new System.Drawing.Point(114, 20);
            this.tb_ho.Name = "tb_ho";
            this.tb_ho.Size = new System.Drawing.Size(674, 26);
            this.tb_ho.TabIndex = 1;
            // 
            // btn_ho
            // 
            this.btn_ho.Location = new System.Drawing.Point(118, 214);
            this.btn_ho.Name = "btn_ho";
            this.btn_ho.Size = new System.Drawing.Size(138, 79);
            this.btn_ho.TabIndex = 2;
            this.btn_ho.Text = "Họ";
            this.btn_ho.UseVisualStyleBackColor = true;
            this.btn_ho.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(114, 68);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(674, 26);
            this.tb_ten.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập tên";
            // 
            // lb_hoten
            // 
            this.lb_hoten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_hoten.Location = new System.Drawing.Point(114, 108);
            this.lb_hoten.Name = "lb_hoten";
            this.lb_hoten.Size = new System.Drawing.Size(674, 82);
            this.lb_hoten.TabIndex = 6;
            this.lb_hoten.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_hoten.DoubleClick += new System.EventHandler(this.lb_hoten_DoubleClick);
            // 
            // btn_ten
            // 
            this.btn_ten.Location = new System.Drawing.Point(372, 214);
            this.btn_ten.Name = "btn_ten";
            this.btn_ten.Size = new System.Drawing.Size(136, 79);
            this.btn_ten.TabIndex = 7;
            this.btn_ten.Text = "Tên";
            this.btn_ten.UseVisualStyleBackColor = true;
            this.btn_ten.Click += new System.EventHandler(this.btn_ten_Click);
            // 
            // btn_hoten
            // 
            this.btn_hoten.Location = new System.Drawing.Point(606, 214);
            this.btn_hoten.Name = "btn_hoten";
            this.btn_hoten.Size = new System.Drawing.Size(139, 79);
            this.btn_hoten.TabIndex = 8;
            this.btn_hoten.Text = "Họ tên";
            this.btn_hoten.UseVisualStyleBackColor = true;
            this.btn_hoten.Click += new System.EventHandler(this.btn_hoten_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(372, 319);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(136, 80);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_hoten);
            this.Controls.Add(this.btn_ten);
            this.Controls.Add(this.lb_hoten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.btn_ho);
            this.Controls.Add(this.tb_ho);
            this.Controls.Add(this.lb_entername);
            this.Name = "frm_DangKy";
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DangKy_FormClosing);
            this.Load += new System.EventHandler(this.frm_DangKy_Load);
            this.Click += new System.EventHandler(this.frm_DangKy_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_entername;
        private System.Windows.Forms.TextBox tb_ho;
        private System.Windows.Forms.Button btn_ho;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_hoten;
        private System.Windows.Forms.Button btn_ten;
        private System.Windows.Forms.Button btn_hoten;
        private System.Windows.Forms.Button btn_thoat;
    }
}

