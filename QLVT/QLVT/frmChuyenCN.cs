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

        public delegate void getChiNhanh(String index);
        public getChiNhanh getCN;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
           
            if (cmb_ChiNhanh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh cần chuyển", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_ChiNhanh.Focus();
                return;
            }
            else
            {
                cmb_ChiNhanh.DropDownStyle = ComboBoxStyle.DropDown;
                getCN(cmb_ChiNhanh.SelectedValue.ToString());
                this.Close();
           
            }
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiNhanhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
    }
}