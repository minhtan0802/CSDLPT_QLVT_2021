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

namespace QLVT
{
    public partial class frmThemCTPN : DevExpress.XtraEditors.XtraForm

    {
        string mddh = Program.frmPN_maDDH;
        public frmThemCTPN()
        {
            InitializeComponent();
        }

        private void frmThemCTPN_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            
            this.sp_getCTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_getCTDDHTableAdapter.Fill(this.DS.sp_getCTDDH,mddh);
        }

        private void btn_ThemVaoCTPN_Click(object sender, EventArgs e)

        { 
            for (int i = 0; i < bds_sp_CTDDH.Count; i++)
            {
                Program.frmPN.bds_spgetCTPN.AddNew();
                ((DataRowView)Program.frmPN.bds_spgetCTPN[i])["MAVT"] = gridView_getCTDDH.GetRowCellValue(i, "MAVT");
                ((DataRowView)Program.frmPN.bds_spgetCTPN[i])["TENVT"] = gridView_getCTDDH.GetRowCellValue(i, "TENVT");
                ((DataRowView)Program.frmPN.bds_spgetCTPN[i])["DONGIA"] = gridView_getCTDDH.GetRowCellValue(i, "DONGIA");
                ((DataRowView)Program.frmPN.bds_spgetCTPN[i])["SOLUONG"] = gridView_getCTDDH.GetRowCellValue(i, "SOLUONG");
            }
            Program.frmPN.gridView_CTPN.FocusedRowHandle = bds_sp_CTDDH.Count-1;
            Program.frmPN.btn_ThemCTPN.Enabled = false;

            MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
            this.Close();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_getCTPNTableAdapter.Fill(this.DS.sp_getCTPN, mAPNToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}