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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
                conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmb_ChiNhanh.DataSource = Program.bds_dspm;//chứa danh sách data cung cấp cho nó
            cmb_ChiNhanh.DisplayMember = "TENCN";
            cmb_ChiNhanh.ValueMember = "TENSERVER";

        }
        public frmDangNhap()
        {
            InitializeComponent();
        }
        
        
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(tb_TaiKhoan.Text.Trim()==""|| tb_MatKhau.Text.Trim()=="")
            {
                MessageBox.Show("Tên tài khoản và mật khẩu không được để trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = tb_TaiKhoan.Text;
            Program.password = tb_MatKhau.Text;
            if (Program.KetNoi() == 0) return;
            Program.mChiNhanh = cmb_ChiNhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC sp_DangNhap '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if(Program.myReader == null)return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if(Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\nBạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoTen = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.HienThiMenu();


        }
        private int KetNoi_CSDLGOC()//chỉ tại trên form này thôi nên private
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối về CSDL gốc.\nVạn xem lại Tên Server của Publisher, và tên CSDL trong chuỗi kết nối.\n"+e.Message,"",MessageBoxButtons.OK);
                return 0;

            }


            return 1;
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM get_Subcribers");
            cmb_ChiNhanh.SelectedIndex = 1;
            cmb_ChiNhanh.SelectedIndex = 0;

        }

        private void cmb_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmb_ChiNhanh.SelectedValue.ToString();
            }
            catch(Exception ex)
            {
                
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}