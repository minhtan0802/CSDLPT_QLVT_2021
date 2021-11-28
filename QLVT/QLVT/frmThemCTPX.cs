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
    public partial class frmThemCTPX : DevExpress.XtraEditors.XtraForm
    {
        int pos;
        int soLuongTon;
        public frmThemCTPX()
        {
            InitializeComponent();
        }

        private void frmThemCTPX_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.sp_getVatTuConThieuCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_getVatTuConThieuCTPhieuTableAdapter.Fill(this.DS.sp_getVatTuConThieuCTPhieu,Program.frmPX.getVatTuDaCo(),"","x");
         
            if (bds_sp_getVatTuConThieuCTPhieu.Count != 0)
            {
                pos = 0;
                txt_TENVT.Text = ((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["TENVT"].ToString();
                txt_DonViTinh.Text= ((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["DVT"].ToString();
                soLuongTon = Int32.Parse(((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["SOLUONGTON"].ToString());
                spin_SoLuong.Focus();
                groupBox_InfoVT.Enabled = true;
                groupBox_VT.Enabled = true;
                if (soLuongTon == 0)
                {
                    spin_SoLuong.Enabled = false;
                    spin_DonGia.Enabled = false;
                    btn_Them.Enabled = false;

                }
                else
                {
                    spin_SoLuong.Enabled = true;
                    spin_DonGia.Enabled = true;
                    btn_Them.Enabled = true;
                }
            }
            else
            {
                groupBox_InfoVT.Enabled = false;
                groupBox_VT.Enabled = false;
            }    
        
           
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Program.frmPX.bds_sp_getCTPhieu.AddNew();
         

            ((DataRowView)Program.frmPX.bds_sp_getCTPhieu[Program.frmPX.bds_sp_getCTPhieu.Position])["MAVT"] =txt_MAVT.Text;
            ((DataRowView)Program.frmPX.bds_sp_getCTPhieu[Program.frmPX.bds_sp_getCTPhieu.Position])["TENVT"] = txt_TENVT.Text;
            ((DataRowView)Program.frmPX.bds_sp_getCTPhieu[Program.frmPX.bds_sp_getCTPhieu.Position])["DONGIA"] =spin_DonGia.Text;
            ((DataRowView)Program.frmPX.bds_sp_getCTPhieu[Program.frmPX.bds_sp_getCTPhieu.Position])["SOLUONG"] = spin_SoLuong.Text;
            Program.frmPX.getVatTuDaCo().Rows.Add(txt_MAVT.Text);
            Program.frmPX.gridView_CTPX.FocusedRowHandle = 0;
            Program.frmPX.btn_XoaCTPX.Enabled = true;
            Program.frmPX.btnThoat.Enabled = false;

            if (Program.frmPX.bds_sp_getCTPhieu.Count == Program.frmPX.bdsVatTu.Count)
            {
                Program.frmPX.btn_ThemCTPX.Enabled = false;
            }
            else
            {
                Program.frmPX.btn_ThemCTPX.Enabled = true;
            }
         
            this.Close();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void gc_sp_getVatTuChuaCo_MouseCaptureChanged(object sender, EventArgs e)
        {
          
        }

        private void spin_SoLuong_Validating(object sender, CancelEventArgs e)
        {
            pos = gridView_VatTuChuaCo.FocusedRowHandle;
            if ((sender as SpinEdit).Value > soLuongTon)
            {
                e.Cancel = true;
            }
            else if ((sender as SpinEdit).Value == 0 && spin_SoLuong.Enabled == true)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }

        }

        private void spin_SoLuong_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
           
        }

        private void spin_SoLuong_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void spin_SoLuong_KeyDown(object sender, KeyEventArgs e)
        {
          

           
        }

        private void spin_SoLuong_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            if ((sender as SpinEdit).Value == 0 && spin_SoLuong.Enabled==true)
            {
                e.ErrorText = "Số lượng phải lớn hơn 0";
            } 
            else 
            {
                e.ErrorText = "Số lượng không được lớn hơn số lượng tồn là " + soLuongTon;
            }    
            
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
           
        }

        private void sp_getVatTuConThieuCTPhieuGridControl_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void gridView_VatTuChuaCo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            pos = bds_sp_getVatTuConThieuCTPhieu.Position;
            txt_TENVT.Text = ((DataRowView)bds_sp_getVatTuConThieuCTPhieu[gridView_VatTuChuaCo.FocusedRowHandle])["TENVT"].ToString();    
            soLuongTon = Int32.Parse(((DataRowView)bds_sp_getVatTuConThieuCTPhieu[gridView_VatTuChuaCo.FocusedRowHandle])["SOLUONGTON"].ToString());  
            spin_SoLuong.Focus();
            //    spin_SoLuong.Properties.MaxValue = max;
            if (soLuongTon == 0)
            {
                spin_SoLuong.Properties.MinValue = 0;
                spin_SoLuong.Value = 0;
                spin_SoLuong.Enabled = false;
                spin_DonGia.Enabled = false;
                btn_Them.Enabled = false;

            }
            else
            {
                spin_SoLuong.Properties.MinValue = 1;
                spin_SoLuong.Value = 1;
                spin_SoLuong.Enabled = true;
                spin_DonGia.Enabled = true;
                btn_Them.Enabled = true;
            }
        }

        private void sp_getVatTuConThieuCTPhieuGridControl_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }
    }
}