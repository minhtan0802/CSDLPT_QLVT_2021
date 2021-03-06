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
    
    public partial class frmChuyenCN : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bds_dspm_ChuyenCN = new BindingSource();
        public frmChuyenCN()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private SqlConnection conn_publisher = new SqlConnection();

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
                conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            bds_dspm_ChuyenCN.DataSource = dt;
            cmb_ChiNhanh.DataSource = bds_dspm_ChuyenCN;

            cmb_ChiNhanh.DisplayMember = "TENCN";
            cmb_ChiNhanh.ValueMember = "TENSERVER";


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
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về CSDL gốc.\nVạn xem lại Tên Server của Publisher, và tên CSDL trong chuỗi kết nối.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;

            }


            return 1;
        }
        private void frmChuyenCN_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM get_Subcribers Where TENSERVER<>'"+Program.servername+"'");
            cmb_ChiNhanh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ChiNhanh.SelectedIndex = 0;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
            BindingSource bdsNV = Program.frmNV.bdsNV;
            string CNchuyen = "";
            if (cmb_ChiNhanh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh cần chuyển", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_ChiNhanh.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn chuyển nhân viên này sang "+cmb_ChiNhanh.Text, "Xác nhận",
               MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                CNchuyen = cmb_ChiNhanh.Text;
                MessageBox.Show("cnchuyen: " + CNchuyen);
                int pos = bdsNV.Position;
                string maCN = "";
                if (CNchuyen.Contains("2")) maCN = "CN2";
                if (CNchuyen.Contains("1")) maCN = "CN1";

                string maNV = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
                string strLenh = "EXEC sp_ChuyenChiNhanhNV @MANV='" + maNV + "'" + ", @MACN='" + maCN + "'";
                try
                {
                    Program.ExecSqlNonQuery(strLenh);
                    
                    Program.frmNV.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    Program.frmNV.NHANVIENTableAdapter.Fill(Program.frmNV.DS.NhanVien);
                    MessageBox.Show("Chuyển nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    //btnUndo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiNhanhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void cmb_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmb_ChiNhanh.SelectedValue.ToString();

            if (cmb_ChiNhanh.SelectedIndex != Program.mChiNhanh)
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}