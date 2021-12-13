using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class Frpt_HoatDongCuaNhanVienTheoThang : DevExpress.XtraEditors.XtraForm
    {
        int manv;
        public Frpt_HoatDongCuaNhanVienTheoThang()
        {
            InitializeComponent();
        }

        private void Frpt_HoatDongCuaNhanVienTheoThang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.HOTENNV' table. You can move, or remove it, as needed.
            this.HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.HOTENNVTableAdapter.Fill(this.dS.HOTENNV);
            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "CONGTY")
                cmbChiNhanh.Enabled = true;
            else
                cmbChiNhanh.Enabled = false;
            }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
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
                this.HOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.HOTENNVTableAdapter.Fill(this.dS.HOTENNV);
            }
        }

        private void cmbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                manv = int.Parse(cmbHoTen.SelectedValue.ToString());
            }
            catch(Exception ex) { }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                Xrpt_HoatDongCuaNhanVienTheoThang rpt = new Xrpt_HoatDongCuaNhanVienTheoThang(manv, dptFrom.DateTime, dptTo.DateTime, cmbLoai.Text.Substring(0, 1));
                rpt.labelTieude.Text = "DANH SÁCH CÁC PHIẾU " + cmbLoai.Text.ToUpper() + " CỦA NHÂN VIÊN THEO THÁNG";
                rpt.lblHoten.Text = cmbHoTen.Text;
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}