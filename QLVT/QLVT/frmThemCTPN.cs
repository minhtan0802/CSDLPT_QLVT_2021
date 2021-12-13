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
        int pos = 0;
        int max = 0;
        string mddh = Program.frmPN.getMDDH();
        int soLuong = 0;
        long soLuongDat = 0;
        public frmThemCTPN()
        {
            InitializeComponent();
        }

        private void frmThemCTPN_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.sp_getVatTuConThieuCTPhieuTableAdapter.Connection.ConnectionString=Program.connstr;
            this.sp_getVatTuConThieuCTPhieuTableAdapter.Fill(this.DS.sp_getVatTuConThieuCTPhieu,Program.frmPN.getDTCTPN(),mddh,"n");
            spin_SoLuong.Focus();
            if(bds_sp_getVatTuConThieuCTPhieu.Count>0)
            {
                pos = 0;
                txt_TENVT.Text = ((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["TENVT"].ToString();
                soLuongDat = Int64.Parse((((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["SOLUONG"].ToString()));
             
                spin_SoLuong.Value = soLuongDat;
            
                spin_DonGia.Value = Int64.Parse((((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["DONGIA"].ToString()));
                
            }
            else
            {
                groupBox_InfoVT.Enabled = false;
                groupBox_VT.Enabled = false;
            }
            
           

        }
        class BorderlessButton : Button
        {
            protected override void OnPaint(PaintEventArgs pevent)
            {
                base.OnPaint(pevent);
                pevent.Graphics.DrawRectangle(new Pen(this.BackColor, 5), this.ClientRectangle);
            }
        }
        private void btn_ThemVaoCTPN_Click(object sender, EventArgs e)

        {

         
            Program.frmPN.bds_sp_getCTPhieu.AddNew();
            int pos = gridView_getVTConThieuCTPN.FocusedRowHandle;
    
            ((DataRowView)Program.frmPN.bds_sp_getCTPhieu[Program.frmPN.bds_sp_getCTPhieu.Position])["MAVT"] = ((DataRowView)bds_sp_getVTConThieuCTPN[pos])["MAVT"];
            ((DataRowView)Program.frmPN.bds_sp_getCTPhieu[Program.frmPN.bds_sp_getCTPhieu.Position])["TENVT"] = ((DataRowView)bds_sp_getVTConThieuCTPN[pos])["TENVT"];
            ((DataRowView)Program.frmPN.bds_sp_getCTPhieu[Program.frmPN.bds_sp_getCTPhieu.Position])["DONGIA"] = ((DataRowView)bds_sp_getVTConThieuCTPN[pos])["DONGIA"];
            ((DataRowView)Program.frmPN.bds_sp_getCTPhieu[Program.frmPN.bds_sp_getCTPhieu.Position])["SOLUONG"] = ((DataRowView)bds_sp_getVTConThieuCTPN[pos])["SOLUONG"];
            Program.frmPN.getDTCTPN().Rows.Add(gridView_getVTConThieuCTPN.GetRowCellValue(pos, "MAVT"));
            Program.frmPN.gridView_CTPN.FocusedRowHandle = 0;
            Program.frmPN.btn_xoaCTPN.Enabled = true;
            Program.frmPN.btnThoat.Enabled = false;
      
            if (Program.frmPN.bds_sp_getCTPhieu.Count==Program.frmPN.getSumCTDDH())
            {
                Program.frmPN.btn_ThemCTPN.Enabled = false;
            }    
            else
            {
                Program.frmPN.btn_ThemCTPN.Enabled = true; 
            }    
            MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
            this.Close();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void gc_sp_getCTDDH_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void gridView_getCTDDH_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
          
        }

        private void gc_sp_getCTDDH_MouseCaptureChanged(object sender, EventArgs e)
        {
          
        }

        private void dTCTDDHTempBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
          

        }

        private void gc_sp_getVTConThieuCTPN_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void fillToolStripButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void fillToolStripButton3_Click(object sender, EventArgs e)
        {
          

        }

        private void gc_sp_getVTConThieuCTPN_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton4_Click(object sender, EventArgs e)
        {
          

        }

        private void fillToolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            Program.frmPN.bds_sp_getCTPhieu.AddNew();

         
            ((DataRowView)Program.frmPN.bds_sp_getCTPhieu[Program.frmPN.bds_sp_getCTPhieu.Position])["MAVT"] = ((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["MAVT"];
         
            ((DataRowView)Program.frmPN.bds_sp_getCTPhieu[Program.frmPN.bds_sp_getCTPhieu.Position])["TENVT"] = ((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["TENVT"];
         
            ((DataRowView)Program.frmPN.bds_sp_getCTPhieu[Program.frmPN.bds_sp_getCTPhieu.Position])["DONGIA"] = ((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["DONGIA"];
            ((DataRowView)Program.frmPN.bds_sp_getCTPhieu[Program.frmPN.bds_sp_getCTPhieu.Position])["SOLUONG"] = ((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["SOLUONG"];
           
            Program.frmPN.getDTCTPN().Rows.Add(((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["MAVT"]);
            Program.frmPN.gridView_CTPN.FocusedRowHandle = 0;
            Program.frmPN.btn_xoaCTPN.Enabled = true;
            Program.frmPN.btnThoat.Enabled = false;

            if (Program.frmPN.bds_sp_getCTPhieu.Count == Program.frmPN.getSumCTDDH())
            {
                Program.frmPN.btn_ThemCTPN.Enabled = false;
            }
            else
            {
                Program.frmPN.btn_ThemCTPN.Enabled = true;
            }
            MessageBox.Show("Thêm thành công", "", MessageBoxButtons.OK);
            this.Close();
        }

        private void groupBox_InfoVT_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void sp_getVatTuConThieuCTPhieuGridControl_MouseCaptureChanged(object sender, EventArgs e)
        {
           
        }

        private void spin_SoLuong_Validating(object sender, CancelEventArgs e)
        {
            if ((sender as SpinEdit).Value > soLuongDat)
            {
                e.Cancel = true;
            }
            else if ((sender as SpinEdit).Value == 0 && spin_SoLuong.Enabled==true)
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
            else
            {
             
                e.ErrorText = "Số lượng không được lớn hơn số lượng đã đặt là " + soLuongDat;
            }
        }

        private void gridView_getVTConThieuCTPN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            pos = bds_sp_getVatTuConThieuCTPhieu.Position;
         
            soLuongDat = Int64.Parse((((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["SOLUONG"].ToString()));

            spin_SoLuong.Value = soLuongDat;
            spin_DonGia.Value = Int64.Parse((((DataRowView)bds_sp_getVatTuConThieuCTPhieu[pos])["DONGIA"].ToString()));
        }
    }
}