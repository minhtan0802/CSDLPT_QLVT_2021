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
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        string mapn = "";
        string mddh = "";
        int soLuongDDH = 0;
        int sumCTDDH = 0;
        public int getSumCTDDH()
        {
            return sumCTDDH;
        }
        public void setSumCTDDH(int sum)
        {
            this.sumCTDDH = sum;
        }
        DataTable dtCTPN = new DataTable();
       
        public DataTable getDTCTPN()
        {
            return dtCTPN;  
        }    

        public string getMDDH()
        {
            return mddh;
        }
        public frmPhieuNhap()
        {
            InitializeComponent();
           
        }
        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        private void load()
        {
            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);
        

            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.PhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PhieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);

            // TODO: This line of code loads data into the 'DS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

          
            if (bdsDH.Count != 0)
            {
       
              mddh = ((DataRowView)bdsDH[0])["MasoDDH"].ToString();
              //cmb_Kho.Text = ((DataRowView)bdsPN[0])["MAKHO"].ToString();


            }
            else
            {
                mddh = "";
            }
            
            if (bdsPN.Count != 0)
            {
                mapn = ((DataRowView)bdsPN[0])["MAPN"].ToString();
                this.sp_getCTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPNTableAdapter.Fill(DS.sp_getCTPN, mapn);
                btn_ThemCTPN.Enabled = false;
                btnThem.Enabled = false;
               gridView_CTPN.OptionsBehavior.Editable = false;

            }
            else
            {
                btn_ThemCTPN.Enabled = false;
                btnThem.Enabled = true;
                mapn = "";
                this.sp_getCTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPNTableAdapter.Fill(DS.sp_getCTPN, mapn);
                gridView_CTPN.OptionsBehavior.Editable = false;
            }

            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
            }
          
            
        }
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
          

            DS.EnforceConstraints = false;

            load();
            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
         
        }

        private void phieuNhapGridControl_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void datHangGridControl_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (bdsPN.Count != 0)
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                mapn = gridView_PN.GetRowCellValue(0, "MAPN").ToString();
                cmb_Kho.Text = ((DataRowView)bdsPN[0])["MAKHO"].ToString();
                this.sp_getCTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPNTableAdapter.Fill(DS.sp_getCTPN, mapn);
                gridView_CTPN.OptionsBehavior.Editable = false;
                

            }
            else
            {
                btnThem.Enabled = true;
                mapn = "";
                this.sp_getCTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPNTableAdapter.Fill(DS.sp_getCTPN, mapn);
                gridView_CTPN.OptionsBehavior.Editable = true;
            }
        
            mddh= ((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString(); ;
            MessageBox.Show("MDDH: " + mddh);

        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCtrl_PN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sumCTDDH = 0;
            Program.frmCTPN = new frmThemCTPN();
            label_Kho.Text = "Kho:";
            gc_DDH.Enabled = false;
            panelCtrl_ThemPN.Enabled = true;
            btn_xoaCTPN.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            bdsPN.AddNew();
            ((DataRowView)bdsPN[0])["MANV"] =txt_MaNV.Text= Program.username;
            ((DataRowView)bdsPN[0])["Ngay"] = txt_date.Text= DateTime.Now.ToString("dd/MM/yyyy");
            ((DataRowView)bdsPN[0])["MaSoDDH"] = gridView_DDH.GetRowCellValue(gridView_DDH.FocusedRowHandle, "MasoDDH");
            ((DataRowView)bdsPN[0])["MAKHO"]=  gridView_DDH.GetRowCellValue(gridView_DDH.FocusedRowHandle, "MAKHO");
            string makho = gridView_DDH.GetRowCellValue(gridView_DDH.FocusedRowHandle, "MAKHO").ToString();
            txt_MaSoDDH.Text = gridView_DDH.GetRowCellValue(gridView_DDH.FocusedRowHandle, "MasoDDH").ToString();
            int vitriKho=bdsKho.Find("MAKHO", makho);
            cmb_Kho.SelectedIndex = vitriKho;
            cmb_Kho.Update();
            dtCTPN = new DataTable();
            dtCTPN.Columns.Add("MAVT");
            this.sp_getCTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_getCTDDHTableAdapter.Fill(this.DS.sp_getCTDDH, Program.frmPN.getMDDH());
            
            for (int i = 0; i < bds_spCTDDH.Count; i++)
            {
                Program.frmPN.bds_spgetCTPN.AddNew();
                ((DataRowView)Program.frmPN.bds_spgetCTPN[i])["MAVT"] = ((DataRowView) bds_spCTDDH[i])["MAVT"];
                ((DataRowView)Program.frmPN.bds_spgetCTPN[i])["TENVT"] = ((DataRowView)bds_spCTDDH[i])["TENVT"];
                ((DataRowView)Program.frmPN.bds_spgetCTPN[i])["DONGIA"] = ((DataRowView)bds_spCTDDH[i])["DONGIA"];
                ((DataRowView)Program.frmPN.bds_spgetCTPN[i])["SOLUONG"] = ((DataRowView)bds_spCTDDH[i])["SOLUONG"];
                dtCTPN.Rows.Add(((DataRowView)bds_spCTDDH[i])["MAVT"]);
                sumCTDDH++;
            }
            
            soLuongDDH = Int32.Parse(((DataRowView)bds_spCTDDH[0])["SOLUONG"].ToString());
        }
        private int savePN()
        {
            try
            {
                cmb_Kho.Text = cmb_Kho.SelectedValue.ToString();

                bdsPN.EndEdit();
                bdsPN.ResetCurrentItem();
                this.PhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PhieuNhapTableAdapter.Update(this.DS.PhieuNhap);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi phiếu nhập.\n" + ex.Message, "", MessageBoxButtons.OK);
                return -1;
            }
        }
        private int saveCTPN()
        {
            try
            {
                Program.savePhieu("n", txt_MaPN.Text, bds_spgetCTPN, gridView_CTPN);
                this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPNTableAdapter.Fill(this.DS.CTPN);
                MessageBox.Show("Ghi thành công", "", MessageBoxButtons.OK);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi CTPN.\n" + ex.Message, "", MessageBoxButtons.OK);
                return -1;
            } 
            
           
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_MaPN.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được thiếu", "", MessageBoxButtons.OK);
                txt_MaPN.Focus();
                return;
            }
            if (cmb_Kho.SelectedIndex == -1 && cmb_Kho.Text=="")
            {
                MessageBox.Show("Kho không được thiếu", "", MessageBoxButtons.OK);
                cmb_Kho.Focus();
                return;
            }
            if (cmb_Kho.SelectedIndex==-1 && cmb_Kho.Text!="")
            {
                MessageBox.Show("Kho không có ở chi nhánh này", "", MessageBoxButtons.OK);
                cmb_Kho.Focus();
                return;
            }    
            if (Program.ExecSqlNonQuery("EXEC sp_TraCuu '" + txt_MaPN.Text + "'" + ", 'MAPN'") == 1)
            {
                txt_MaPN.Focus();
                return;
            }
            if (bds_spgetCTPN.Count == 0)
            {
                MessageBox.Show("Chi tiết đơn phiếu nhập không được thiếu", "", MessageBoxButtons.OK);
                gridView_CTPN.Focus();
                return;
            }
            if (savePN()==0)
            {
                saveCTPN();
            }    
      
            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            btn_xoaCTPN.Enabled = btn_ThemCTPN.Enabled= false;
            label_Kho.Text = "Mã kho:";
            panelCtrl_ThemPN.Enabled = false;
            gc_DDH.Enabled = true;
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
                load();
            }
        }

        private void sp_getCTPNGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_ThemCTPN_Click(object sender, EventArgs e)
        {
            if (! Program.CheckOpened("Thêm chi tiết PN"))
            {
                frmThemCTPN f = new frmThemCTPN();
                f.Show();
            }
            else return;
        }

        private void btn_TestCTPN_Click(object sender, EventArgs e)
        {
            bds_spgetCTPN.AddNew();
            ((DataRowView)bds_spgetCTPN[0])["MAVT"] = "Hello";
            ((DataRowView)bds_spgetCTPN[0])["TENVT"] = "Hi";
        }

        private void btn_GhiCTPN_Click(object sender, EventArgs e)
        {
           
        }

        private void gc_sp_getCTPN_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            if (gridView_CTPN.FocusedColumn.FieldName == "SOLUONG" || gridView_CTPN.FocusedColumn.FieldName == "DONGIA")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void gridView_PN_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView_CTPN.FocusedColumn.FieldName == "SOLUONG")
            {
                int rows = gridView_CTPN.FocusedRowHandle;
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
                else if (Int32.Parse(soLuongString) == 0 && gridView_CTPN.FocusedColumn.FieldName == "SOLUONG")
                {
                    e.Valid = false;
                    e.ErrorText = "Số lượng phải phải lớn hơn 0";
                }


            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_getCTDDHTableAdapter.Fill(this.DS.sp_getCTDDH, mddh);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gc_sp_getCTPN_MouseCaptureChanged(object sender, EventArgs e)
        {
            soLuongDDH = Int32.Parse(((DataRowView)bds_spgetCTPN[bds_spgetCTPN.Position])["SOLUONG"].ToString());
        }

        private void gridView_CTPN_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView_CTPN.FocusedColumn.FieldName == "SOLUONG" || gridView_CTPN.FocusedColumn.FieldName == "DONGIA")
            {
                int rows = gridView_CTPN.FocusedRowHandle;
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
                else if (Int32.Parse(soLuongString) == 0 && gridView_CTPN.FocusedColumn.FieldName == "SOLUONG")
                {
                    e.Valid = false;
                    e.ErrorText = "Số lượng phải phải lớn hơn 0";
                }
                else if (Int32.Parse(soLuongString) > soLuongDDH && gridView_CTPN.FocusedColumn.FieldName == "SOLUONG")
                {
                    e.Valid = false;
                    e.ErrorText = "Số lượng nhập không được lớn hơn số lượng đã đặt là " + soLuongDDH;
                }


            }
        }

        private void btn_xoaCTPN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa kho này?", "Xác nhận",
              MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dtCTPN.Rows.RemoveAt(bds_spgetCTPN.Position);

                //gridView_getCTDDH.DeleteSelectedRows();
                bds_spgetCTPN.RemoveAt(bds_spgetCTPN.Position);
                btn_ThemCTPN.Enabled = true;
                btnThoat.Enabled = false;
                if (bds_spgetCTPN.Count == 0)
                {
                    btn_xoaCTPN.Enabled = false;
                }
                else
                {
                    btn_xoaCTPN.Enabled = true;
                }
            }
           
        }
    }
}