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
        string mddh = Program.frmPN.getMDDH();
        int soLuong = 0;
        public frmThemCTPN()
        {
            InitializeComponent();
        }

        private void frmThemCTPN_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.sp_getVTConThieuCTPNTableAdapter.Connection.ConnectionString=Program.connstr;
            this.sp_getVTConThieuCTPNTableAdapter.Fill(this.DS.sp_getVTConThieuCTPN,Program.frmPN.getDTCTPN(),mddh);
            if (bds_sp_getVTConThieuCTPN.Count>0)
            {
                gridView_getVTConThieuCTPN.FocusedRowHandle = 0;
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

         
            Program.frmPN.bds_spgetCTPN.AddNew();
            int pos = gridView_getVTConThieuCTPN.FocusedRowHandle;
    
            ((DataRowView)Program.frmPN.bds_spgetCTPN[Program.frmPN.bds_spgetCTPN.Position])["MAVT"] = ((DataRowView)bds_sp_getVTConThieuCTPN[pos])["MAVT"];
            ((DataRowView)Program.frmPN.bds_spgetCTPN[Program.frmPN.bds_spgetCTPN.Position])["TENVT"] = ((DataRowView)bds_sp_getVTConThieuCTPN[pos])["TENVT"];
            ((DataRowView)Program.frmPN.bds_spgetCTPN[Program.frmPN.bds_spgetCTPN.Position])["DONGIA"] = ((DataRowView)bds_sp_getVTConThieuCTPN[pos])["DONGIA"];
            ((DataRowView)Program.frmPN.bds_spgetCTPN[Program.frmPN.bds_spgetCTPN.Position])["SOLUONG"] = ((DataRowView)bds_sp_getVTConThieuCTPN[pos])["SOLUONG"];
            Program.frmPN.getDTCTPN().Rows.Add(gridView_getVTConThieuCTPN.GetRowCellValue(pos, "MAVT"));
            Program.frmPN.gridView_CTPN.FocusedRowHandle = 0;
            Program.frmPN.btn_xoaCTPN.Enabled = true;
            Program.frmPN.btnThoat.Enabled = false;
      
            if (Program.frmPN.bds_spgetCTPN.Count==Program.frmPN.getSumCTDDH())
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
            try
            {
                this.sp_getCTPNTableAdapter.Fill(this.DS.sp_getCTPN, mAPNToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gc_sp_getCTDDH_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void gridView_getCTDDH_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
          /* if (gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG" || gridView_getCTDDH.FocusedColumn.FieldName == "DONGIA")
            {
                int rows = gridView_getCTDDH.FocusedRowHandle;
                int number = 0;
                String soLuongString = e.Value as string;
                if (soLuongString.Equals(""))
                {
                    e.Valid = false;
                    e.ErrorText = "Không được để trống";
                }
                else if (!Int32.TryParse(soLuongString, out number))
                {
                    e.Valid = false;
                    e.ErrorText = "Vui lòng nhập số";
                }
                else if (Int32.Parse(soLuongString) == 0 && gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG")
                {
                    e.Valid = false;
                    e.ErrorText = "Số lượng phải phải lớn hơn 0";
                }
                else if (Int32.Parse(soLuongString) >soLuong && gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG")
                {
                    e.Valid = false;
                    e.ErrorText = "Số lượng nhập không được lớn hơn số lượng đã đặt là "+soLuong;
                }


            }*/
        }

        private void gc_sp_getCTDDH_MouseCaptureChanged(object sender, EventArgs e)
        {
            soLuong = Int32.Parse(((DataRowView)bds_sp_CTDDH[0])["SOLUONG"].ToString());
        }

        private void dTCTDDHTempBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                object VTDaCo = new object();
                this.sp_getVTConThieuCTPNTableAdapter.Fill(this.DS.sp_getVTConThieuCTPN, VTDaCo, maPNToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gc_sp_getVTConThieuCTPN_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void fillToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                object VTDaCo = new object();
                this.sp_getVTConThieuCTPNTableAdapter.Fill(this.DS.sp_getVTConThieuCTPN, VTDaCo, maDDHToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                object VTDaCo = new object();
                this.sp_getVTConThieuCTPNTableAdapter.Fill(this.DS.sp_getVTConThieuCTPN, VTDaCo, maDDHToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gc_sp_getVTConThieuCTPN_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                object VTDaCo = new object();
                this.sp_getVTConThieuCTPNTableAdapter.Fill(this.DS.sp_getVTConThieuCTPN, VTDaCo, maDDHToolStripTextBox2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}