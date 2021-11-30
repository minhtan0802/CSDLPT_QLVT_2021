
namespace QLVT
{
    partial class frmTaoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoTaiKhoan));
            this.cmb_NhanVien = new System.Windows.Forms.ComboBox();
            this.cb_ShowPass = new System.Windows.Forms.CheckBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TaoTaiKhoan = new System.Windows.Forms.Button();
            this.rdbtn_CongTy = new System.Windows.Forms.RadioButton();
            this.rdbtn_User = new System.Windows.Forms.RadioButton();
            this.rdbtn_ChiNhanh = new System.Windows.Forms.RadioButton();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.cmb_ChiNhanhTTK = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_NhanVien
            // 
            this.cmb_NhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_NhanVien.FormattingEnabled = true;
            this.cmb_NhanVien.Location = new System.Drawing.Point(526, 143);
            this.cmb_NhanVien.Name = "cmb_NhanVien";
            this.cmb_NhanVien.Size = new System.Drawing.Size(292, 28);
            this.cmb_NhanVien.TabIndex = 18;
            // 
            // cb_ShowPass
            // 
            this.cb_ShowPass.AutoSize = true;
            this.cb_ShowPass.BackColor = System.Drawing.Color.Transparent;
            this.cb_ShowPass.Location = new System.Drawing.Point(526, 310);
            this.cb_ShowPass.Name = "cb_ShowPass";
            this.cb_ShowPass.Size = new System.Drawing.Size(140, 21);
            this.cb_ShowPass.TabIndex = 17;
            this.cb_ShowPass.Text = "Hiển thị mật khẩu";
            this.cb_ShowPass.UseVisualStyleBackColor = false;
            this.cb_ShowPass.CheckedChanged += new System.EventHandler(this.cb_ShowPass_CheckedChanged);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_Thoat.Location = new System.Drawing.Point(719, 398);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(143, 31);
            this.btn_Thoat.TabIndex = 16;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TaoTaiKhoan
            // 
            this.btn_TaoTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.btn_TaoTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btn_TaoTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btn_TaoTaiKhoan.Location = new System.Drawing.Point(523, 398);
            this.btn_TaoTaiKhoan.Name = "btn_TaoTaiKhoan";
            this.btn_TaoTaiKhoan.Size = new System.Drawing.Size(143, 31);
            this.btn_TaoTaiKhoan.TabIndex = 15;
            this.btn_TaoTaiKhoan.Text = "TẠO";
            this.btn_TaoTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_TaoTaiKhoan.Click += new System.EventHandler(this.btn_TaoTaiKhoan_Click);
            // 
            // rdbtn_CongTy
            // 
            this.rdbtn_CongTy.AutoSize = true;
            this.rdbtn_CongTy.BackColor = System.Drawing.Color.Transparent;
            this.rdbtn_CongTy.Location = new System.Drawing.Point(559, 352);
            this.rdbtn_CongTy.Name = "rdbtn_CongTy";
            this.rdbtn_CongTy.Size = new System.Drawing.Size(77, 21);
            this.rdbtn_CongTy.TabIndex = 14;
            this.rdbtn_CongTy.TabStop = true;
            this.rdbtn_CongTy.Text = "Công ty";
            this.rdbtn_CongTy.UseVisualStyleBackColor = false;
            // 
            // rdbtn_User
            // 
            this.rdbtn_User.AutoSize = true;
            this.rdbtn_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rdbtn_User.Location = new System.Drawing.Point(709, 352);
            this.rdbtn_User.Name = "rdbtn_User";
            this.rdbtn_User.Size = new System.Drawing.Size(59, 21);
            this.rdbtn_User.TabIndex = 9;
            this.rdbtn_User.TabStop = true;
            this.rdbtn_User.Text = "User";
            this.rdbtn_User.UseVisualStyleBackColor = false;
            // 
            // rdbtn_ChiNhanh
            // 
            this.rdbtn_ChiNhanh.AutoSize = true;
            this.rdbtn_ChiNhanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rdbtn_ChiNhanh.Location = new System.Drawing.Point(559, 352);
            this.rdbtn_ChiNhanh.Name = "rdbtn_ChiNhanh";
            this.rdbtn_ChiNhanh.Size = new System.Drawing.Size(93, 21);
            this.rdbtn_ChiNhanh.TabIndex = 8;
            this.rdbtn_ChiNhanh.TabStop = true;
            this.rdbtn_ChiNhanh.Text = "Chi nhánh";
            this.rdbtn_ChiNhanh.UseVisualStyleBackColor = false;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(527, 277);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(292, 27);
            this.txt_MatKhau.TabIndex = 6;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(525, 208);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(292, 27);
            this.txt_TaiKhoan.TabIndex = 4;
            this.txt_TaiKhoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmb_ChiNhanhTTK
            // 
            this.cmb_ChiNhanhTTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ChiNhanhTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ChiNhanhTTK.FormattingEnabled = true;
            this.cmb_ChiNhanhTTK.Location = new System.Drawing.Point(526, 80);
            this.cmb_ChiNhanhTTK.Name = "cmb_ChiNhanhTTK";
            this.cmb_ChiNhanhTTK.Size = new System.Drawing.Size(292, 28);
            this.cmb_ChiNhanhTTK.TabIndex = 2;
            this.cmb_ChiNhanhTTK.SelectedIndexChanged += new System.EventHandler(this.cmb_ChiNhanhTTK_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(570, -5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(247, 45);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "TẠO TÀI KHOẢN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mật khẩu";
            // 
            // frmTaoTaiKhoan
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(874, 451);
            this.Controls.Add(this.rdbtn_CongTy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmb_NhanVien);
            this.Controls.Add(this.cb_ShowPass);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TaoTaiKhoan);
            this.Controls.Add(this.cmb_ChiNhanhTTK);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.rdbtn_ChiNhanh);
            this.Controls.Add(this.rdbtn_User);
            this.Name = "frmTaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_ChiNhanhTTK;
        private System.Windows.Forms.RadioButton rdbtn_User;
        private System.Windows.Forms.RadioButton rdbtn_ChiNhanh;
        private System.Windows.Forms.RadioButton rdbtn_CongTy;
        private System.Windows.Forms.Button btn_TaoTaiKhoan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.CheckBox cb_ShowPass;
        private System.Windows.Forms.ComboBox cmb_NhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}