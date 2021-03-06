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
    public partial class frmThemCTDDH : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        int pos;
        public frmThemCTDDH()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void fromThemChiTietDDH_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.sp_getVatTuConThieuCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_getVatTuConThieuCTPhieuTableAdapter.Fill(this.DS.sp_getVatTuConThieuCTPhieu,Program.frmDDH.getDTVTDaCo(),"","dh");

            if (bds_sp_getVatTuConThieuCTPhieu.Count > 0)
            {
                pos = 0;
            }
            else
            {
                groupBox_InfoVT.Enabled = false;
                groupBox_VT.Enabled = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gc_sp_getVatTuChuaCo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Program.frmDDH.gc_DatHang.Enabled = false;
                Program.frmDDH.btnThem.Enabled = false;
                    Program.frmDDH.btnGhi.Enabled = true;
                    Program.frmDDH.bds_sp_getCTPhieu.AddNew();
            int posCTP = Program.frmDDH.bds_sp_getCTPhieu.Position;
                    ((DataRowView)Program.frmDDH.bds_sp_getCTPhieu[posCTP])["MAVT"] = txt_MaVT.Text;
                    ((DataRowView)Program.frmDDH.bds_sp_getCTPhieu[posCTP])["TENVT"] = txt_TenVT.Text;
                    ((DataRowView)Program.frmDDH.bds_sp_getCTPhieu[posCTP])["DONGIA"] = spin_DonGia.Value.ToString();
                    ((DataRowView)Program.frmDDH.bds_sp_getCTPhieu[posCTP])["SOLUONG"] = spin_SoLuong.Value.ToString();
                    
                    
                    Program.frmDDH.getDTVTDaCo().Rows.Add(txt_MaVT.Text);




                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(this.DS.Vattu);

                if (Program.frmDDH.bds_sp_getCTPhieu.Count==bdsVatTu.Count)
                    {
                        Program.frmDDH.btn_ThemCTDDH.Enabled = false;
                    }
                    else
                    {
                        Program.frmDDH.btn_ThemCTDDH.Enabled = true;
                    }
                    if (Program.frmDDH.bds_sp_getCTPhieu.Count == 0)
                    {
                        Program.frmDDH.btn_XoaCTDDH.Enabled = false;
                    }
                    else
                    {
                        Program.frmDDH.btn_XoaCTDDH.Enabled = true;
                    }
                 
                
            this.Close();
            }
        
        private void gc_sp_getVatTuChuaCo_MouseCaptureChanged(object sender, EventArgs e)
        {
           
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void spin_SoLuong_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as SpinEdit).Value == 0 && spin_SoLuong.Enabled==true)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void spin_SoLuong_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            if ((sender as SpinEdit).Value == 0)
            {
                e.ErrorText = "Số lượng phải lớn hơn 0";
            }
        }

        private void sp_getVatTuConThieuCTPhieuGridControl_MouseCaptureChanged(object sender, EventArgs e)
        {
           
        }

        private void gridView_VatTuChuaCo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            pos = bds_sp_getVatTuConThieuCTPhieu.Position;
            spin_SoLuong.Value = 1;
            spin_DonGia.Value = 1;
        }

        private void sp_getVatTuConThieuCTPhieuGridControl_Click(object sender, EventArgs e)
        {

        }

        private void gridView_VatTuChuaCo_ColumnFilterChanged(object sender, EventArgs e)
        {
            pos = bds_sp_getVatTuConThieuCTPhieu.Position;
            spin_SoLuong.Value = 1;
            spin_DonGia.Value = 1;
        }

        private void spin_DonGia_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            if ((sender as SpinEdit).Value == 0)
            {
                e.ErrorText = "Đơn giá phải lớn hơn 0";
            }
        }
       
    }
}