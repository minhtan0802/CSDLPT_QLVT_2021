using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
   
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public DataTable get_bds_ChiNhanhTTK()
        {
            return dt;
        }
       
        public frmTaoTaiKhoan()
        {
       
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void LayDSNVChuaCoAcc(String cmd)
        {
            cmb_NhanVien.Text = "";
            dt = new DataTable();
            dt = Program.ExecSqlDataTable(cmd);
            dt.Columns.Add("Fullname");
            foreach (DataRow item in dt.Rows)
            {
                item["Fullname"] = item["HO"] + " " + item["TEN"];
            }
            this.cmb_NhanVien.DataSource =dt;//chứa danh sách data cung cấp cho nó
            this.cmb_NhanVien.DisplayMember = "Fullname";
            this.cmb_NhanVien.ValueMember = "MANV";

           
        }
        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.sp_getTaiKhoanChuaCoAcc' table. You can move, or remove it, as needed.
            BindingSource bdsChiNhanh = new BindingSource();
          
            this.cmb_ChiNhanhTTK.DataSource = Program.bds_dspm_TaoTK;  // sao chép bds_dspm đã load ở form đăng nhập  qua
        //    this.cmb_ChiNhanhTTK.DataSource = Program.bds_dspm;
            this.cmb_ChiNhanhTTK.DisplayMember = "TENCN";
            this.cmb_ChiNhanhTTK.ValueMember = "TENSERVER";
            this.cmb_ChiNhanhTTK.SelectedIndex = Program.mChiNhanh;
            this.LayDSNVChuaCoAcc("EXEC sp_getTaiKhoanChuaCoAcc");
            
            if (Program.mGroup == "CONGTY")
            {
                rdbtn_User.Visible = false;
                rdbtn_ChiNhanh.Visible = false;
                rdbtn_CongTy.Checked = true;
                cmb_ChiNhanhTTK.Enabled = true;

            }
            else
            {
                cmb_ChiNhanhTTK.Enabled = false;
                rdbtn_CongTy.Visible = false;
            }
           
            if (dt.Rows.Count == 0)
            {
             //   MessageBox.Show("Tất cả nhân viên ở chi nhánh này đã có tài khoản", "", MessageBoxButtons.OK);
              //  label_ThongBao.Text = "Tất cả nhân viên ở chi nhánh này đã có tài khoản";
                btn_TaoTaiKhoan.Enabled = false;
                rdbtn_ChiNhanh.Enabled = rdbtn_User.Enabled = rdbtn_CongTy.Enabled = cmb_NhanVien.Enabled = txt_MatKhau.Enabled = txt_TaiKhoan.Enabled =cb_ShowPass.Enabled= false;
            }
            else
            {
                rdbtn_ChiNhanh.Enabled = rdbtn_User.Enabled = rdbtn_CongTy.Enabled = cmb_NhanVien.Enabled = txt_MatKhau.Enabled = txt_TaiKhoan.Enabled = cb_ShowPass.Enabled = true;
                btn_TaoTaiKhoan.Enabled = true;
            }

        }

        

        private void btn_Thoat_Click(object sender, EventArgs e)
        {

            this.Close();
          
         BindingSource bdsChiNhanh = new BindingSource();

        this.cmb_ChiNhanhTTK.DataSource = bdsChiNhanh;
        //    Program.frmTaoAcc = null;
        }

        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            String loginName = txt_TaiKhoan.Text.Trim();
            String pass = txt_MatKhau.Text;
            String role = "";
            if (Program.mGroup.Equals("CONGTY")){
                role = "CONGTY";
                cmb_ChiNhanhTTK.Enabled = true;
            }
            else
            {
                cmb_ChiNhanhTTK.Enabled = false;
                if (rdbtn_ChiNhanh.Checked)
                {
                    role = "CHINHANH";
                }
                else role = "USER";
            }
            
           if (loginName.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản không được thiếu", "", MessageBoxButtons.OK);
                txt_TaiKhoan.Focus();
                return;
            }
            else if (pass.Trim()=="")
            {
                MessageBox.Show("Mật khẩu không được thiếu", "", MessageBoxButtons.OK);
                txt_MatKhau.Focus();
                return;
            }
            else if (!rdbtn_ChiNhanh.Checked && !rdbtn_User.Checked && !Program.mGroup.Equals("CONGTY"))
            {
                MessageBox.Show("Vui lòng chọn quyền cho tài khoản", "", MessageBoxButtons.OK);
                return;
            }
            String username = cmb_NhanVien.SelectedValue.ToString();
            int ret=Program.ExecSqlNonQuery("EXEC sp_TaoTaiKhoan '"+loginName+"','"+pass+"','"+username+"','"+role+"'");
            if (ret==0)
            {
                MessageBox.Show("Tạo tài khoản thành công", "", MessageBoxButtons.OK);
                LayDSNVChuaCoAcc("EXEC sp_getTaiKhoanChuaCoAcc");
                txt_MatKhau.Text = "";
                txt_TaiKhoan.Text = "";
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tất cả nhân viên ở chi nhánh này đã có tài khoản", "", MessageBoxButtons.OK);
                    btn_TaoTaiKhoan.Enabled = false;
                    rdbtn_ChiNhanh.Enabled = rdbtn_User.Enabled = rdbtn_CongTy.Enabled = cmb_NhanVien.Enabled = txt_MatKhau.Enabled = txt_TaiKhoan.Enabled = cb_ShowPass.Enabled = false;
                }
                else
                {
                    rdbtn_ChiNhanh.Enabled = rdbtn_User.Enabled = rdbtn_CongTy.Enabled = cmb_NhanVien.Enabled = txt_MatKhau.Enabled = txt_TaiKhoan.Enabled = cb_ShowPass.Enabled = true;
                    btn_TaoTaiKhoan.Enabled = true;
                }    
             
            }
         
        }

        

        private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_ShowPass.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
        }

        private void cmb_ChiNhanhTTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_ChiNhanhTTK.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = this.cmb_ChiNhanhTTK.SelectedValue.ToString();

            if (this.cmb_ChiNhanhTTK.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePassword;


              
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.LayDSNVChuaCoAcc("EXEC sp_getTaiKhoanChuaCoAcc");

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tất cả nhân viên ở chi nhánh này đã có tài khoản", "", MessageBoxButtons.OK);
                    btn_TaoTaiKhoan.Enabled = false;
                    rdbtn_ChiNhanh.Enabled = rdbtn_User.Enabled = rdbtn_CongTy.Enabled = cmb_NhanVien.Enabled = txt_MatKhau.Enabled = txt_TaiKhoan.Enabled =cb_ShowPass.Enabled= false;
                }
                else
                {
                    rdbtn_ChiNhanh.Enabled = rdbtn_User.Enabled = rdbtn_CongTy.Enabled = cmb_NhanVien.Enabled = txt_MatKhau.Enabled = txt_TaiKhoan.Enabled = cb_ShowPass.Enabled = true;
                    btn_TaoTaiKhoan.Enabled = true;
                }

            }

        }
    }
}