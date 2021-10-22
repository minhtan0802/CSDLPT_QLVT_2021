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
        public DataTable dt = new DataTable();
        private SqlConnection conn_publisher = new SqlConnection();
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
            dt = Program.ExecSqlDataTable(cmd);
            dt.Columns.Add("Fullname");
            foreach (DataRow item in dt.Rows)
            {
                item["Fullname"] = item["HO"] + " " + item["TEN"];
            }
            Program.bds_DSNVChuaCoAcc.DataSource = dt;
            cmb_NhanVien.DataSource = Program.bds_DSNVChuaCoAcc;//chứa danh sách data cung cấp cho nó
            cmb_NhanVien.DisplayMember = "Fullname";
            cmb_NhanVien.ValueMember = "MANV";

           
        }
        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            cmb_ChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmb_ChiNhanh.DisplayMember = "TENCN";
            cmb_ChiNhanh.ValueMember = "TENSERVER";
            cmb_ChiNhanh.SelectedIndex = Program.mChiNhanh;
            LayDSNVChuaCoAcc("EXEC sp_getTaiKhoanChuaCoAcc");
  
            if (Program.mGroup == "CONGTY")
            {
                rdbtn_User.Visible = false;
                rdbtn_ChiNhanh.Visible = false;
                rdbtn_CongTy.Checked = true;

            }
            else
            {
                rdbtn_CongTy.Visible = false;
            }
            cmb_ChiNhanh.SelectedIndex = 1;
            cmb_ChiNhanh.SelectedIndex = 0;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            String loginName = txt_TaiKhoan.Text.Trim();
            String pass = txt_MatKhau.Text;
            String role = "";
            if (Program.mGroup.Equals("CONGTY")){
                role = "CONGTY";
            }
            else
            {
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
                    this.Close();
                }
             
            }
         
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
        LayDSNVChuaCoAcc("EXEC sp_getTaiKhoanChuaCoAcc");
        }
    }
}