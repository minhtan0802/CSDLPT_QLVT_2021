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
    public partial class frmVatTu : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.VatTu' table. You can move, or remove it, as needed.
            this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VatTuTableAdapter.Fill(this.DS.Vattu);
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
            // TODO: This line of code loads data into the 'DS.CTPN' table. You can move, or remove it, as needed.
            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);
            // TODO: This line of code loads data into the 'DS.CTPX' table. You can move, or remove it, as needed.
            this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPXTableAdapter.Fill(this.DS.CTPX);
            panelCtrl_VatTu.Enabled = false;
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled = false;
            }
         

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVatTu.Position;
            panelCtrl_VatTu.Enabled = true;
            bdsVatTu.AddNew();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcVatTu.Enabled = false;
            panelCtrl_VatTu.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVatTu.CancelEdit();
            if (btnThem.Enabled == false) bdsVatTu.Position = vitri;
            gcVatTu.Enabled = true;
            panelCtrl_VatTu.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVatTu.Position;
            panelCtrl_VatTu.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcVatTu.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.VatTuTableAdapter.Fill(this.DS.Vattu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mavt = "";
            if (bdsCTDDH.Count>0)
            {
                MessageBox.Show("Không thể xóa vật tư vì đã lập đơn đặt hàng", "", MessageBoxButtons.OK);
                return;
            }    
            if (bdsCTPN.Count>0)
            {
                MessageBox.Show("Không thể xóa vật tư vì đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            } 
            if (bdsCTPX.Count>0)
            {
                {
                    MessageBox.Show("Không thể xóa vật tư vì đã lập phiếu xuất", "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này?", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mavt = ((DataRowView)bdsVatTu[bdsVatTu.Position])["MAVT"].ToString();
                    bdsVatTu.RemoveCurrent();//Xóa trên máy hiện tại trước
                    this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.VatTuTableAdapter.Update(this.DS.Vattu);//Xóa trên CSDL
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư. Bạn hãy xóa lại\n"+ex.Message,"",MessageBoxButtons.OK);
                    this.VatTuTableAdapter.Fill(this.DS.Vattu);
                    bdsVatTu.Position = bdsVatTu.Find("MAVT", mavt);
                    return;
                }
            }
            if (bdsVatTu.Count == 0) btnXoa.Enabled = false;
                
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}