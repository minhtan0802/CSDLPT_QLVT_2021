using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class frmRptDSNV : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bds_dspm_ChuyenCN = new BindingSource();
        public frmRptDSNV()
        {
            InitializeComponent();
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

        }
        private void frmChuyenCN_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM get_Subcribers Where TENSERVER<>'" + Program.servername + "'");
            cmb_ChiNhanh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ChiNhanh.SelectedIndex = 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Xrpt_DSNhanVien rpt = new Xrpt_DSNhanVien();
            string tenCN = "";
            if (Program.servername.Contains("1"))
            {
                tenCN = "1";
            }
            else
            {
                tenCN = "2";
            }
            rpt.label_TieuDe.Text = "DANH SÁCH NHÂN VIÊN CHI NHÁNH " + tenCN;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void frmRptDSNV_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            if(Program.mGroup=="CHINHANH" || Program.mGroup=="USER" )
            {
                LayDSPM("SELECT * FROM get_Subcribers Where TENSERVER='" + Program.servername + "'");
                cmb_ChiNhanh.Enabled = false;
            }
            else
            {
                LayDSPM("SELECT * FROM get_Subcribers");
                cmb_ChiNhanh.Enabled = true;
            }    
           
            cmb_ChiNhanh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ChiNhanh.SelectedIndex = 0;
        }
    }
}