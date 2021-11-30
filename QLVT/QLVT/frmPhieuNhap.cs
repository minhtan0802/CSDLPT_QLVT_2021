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
        string tempMAPN = "";
        string soLuongString = "";
        int vitri;
        ErrorProvider errorProviderMAPN = new ErrorProvider();
       
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
        public void load()
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



            if (bdsDH.Count > 0)
            {
                gc_DDH.Focus();
                mddh = ((DataRowView)bdsDH[0])["MasoDDH"].ToString();
              
            }
            else
            {
                mddh = "";
            }
            if (bdsPN.Count > 0)
            {

                mapn = ((DataRowView)bdsPN[0])["MAPN"].ToString();
                this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPhieuTableAdapter.Fill(DS.sp_getCTPhieu, mapn, "n");
           

                btn_ThemCTPN.Enabled = false;
                btnThem.Enabled = false;
                gridView_CTPN.OptionsBehavior.Editable = false;

            }
            else
            {
                btn_ThemCTPN.Enabled = false;
                btnThem.Enabled = true;
                mapn = "";
                this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPhieuTableAdapter.Fill(DS.sp_getCTPhieu, mapn, "n");
             

                gridView_CTPN.OptionsBehavior.Editable = false;
            }

            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
            }
            btnUndo.Enabled=false;


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
            vitri = bdsDH.Position;
            gc_PhieuNhap.Enabled = false;
            tempMAPN = "";
          //  cmb_Kho.DropDownStyle = ComboBoxStyle.DropDownList;
            sumCTDDH = 0;
            label_Kho.Text = "Kho:";
            gc_DDH.Enabled = false;
            panelCtrl_ThemPN.Enabled = true;
            btn_xoaCTPN.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            bdsPN.AddNew();
         //   ((DataRowView)bdsPN[bdsPN.Position])["MANV"] = txt_MaNV.Text = Program.username;
           
           // ((DataRowView)bdsPN[bdsPN.Position])["MaSoDDH"] = ((DataRowView)bdsDH[bdsDH.Position])["MaSoDDH"];
          //  ((DataRowView)bdsPN[bdsPN.Position])["MAKHO"] = ((DataRowView)bdsDH[bdsDH.Position])["MAKHO"];
            string makho = ((DataRowView)bdsDH[bdsDH.Position])["MAKHO"].ToString();
          //  txt_MaSoDDH.Text = ((DataRowView)bdsDH[bdsDH.Position])["MaSoDDH"].ToString();
            //  int vitriKho = bdsKho.Find("MAKHO", makho);
            //   cmb_Kho2.= vitriKho;
          //  gc_PhieuNhap.Focus();
            cmb_Kho2.Text = makho;
            cmb_Kho2.SelectedText = makho;
        //    cmb_Kho2.Update();
            dtCTPN = new DataTable();
            dtCTPN.Columns.Add("MAVT");
            this.sp_getCTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_getCTDDHTableAdapter.Fill(this.DS.sp_getCTDDH, mddh);
        
            if(bds_sp_getCTDDH.Count==0)
            {
                MessageBox.Show("Đơn đặt hàng bị lỗi");
                gc_DDH.Enabled = true;
                panelCtrl_CTPN.Enabled = false;
                panelCtrl_ThemPN.Enabled = false;
                return;
            }
            else
            {
                panelCtrl_CTPN.Enabled = true;
                panelCtrl_ThemPN.Enabled = true;
            }    
        for (int i = 0; i < bds_sp_getCTDDH.Count; i++)
            {
                bds_sp_getCTPhieu.AddNew();
                ((DataRowView)bds_sp_getCTPhieu[i])["MAVT"] = ((DataRowView)bds_sp_getCTDDH[i])["MAVT"];
                ((DataRowView)bds_sp_getCTPhieu[i])["TENVT"] = ((DataRowView)bds_sp_getCTDDH[i])["TENVT"];
                ((DataRowView)bds_sp_getCTPhieu[i])["DONGIA"] = ((DataRowView)bds_sp_getCTDDH[i])["DONGIA"];
                ((DataRowView)bds_sp_getCTPhieu[i])["SOLUONG"] = ((DataRowView)bds_sp_getCTDDH[i])["SOLUONG"];
                dtCTPN.Rows.Add(((DataRowView)bds_sp_getCTPhieu[i])["MAVT"]);
                sumCTDDH++;
            }
            bds_sp_getCTPhieu.Position = 0;
            txt_MaNV.Text = Program.username;
            txt_date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_MaSoDDH.Text = mddh;
                soLuongString = ((DataRowView)bds_sp_getCTPhieu[bds_sp_getCTDDH.Position])["SOLUONG"].ToString();

            string mavt = ((DataRowView)bds_sp_getCTPhieu[bds_sp_getCTPhieu.Position])["MAVT"].ToString();

           string soLuongStringDDH = ((DataRowView)bds_sp_getCTPhieu[bds_sp_getCTDDH.Find("MAVT", mavt)])["SOLUONG"].ToString();
           soLuongDDH = Int32.Parse(soLuongStringDDH);
            txt_MaPN.Enabled = true;
            txt_MaPN.Focus();
        }
        private int savePN()
        {
            try
            {

            //    cmb_Kho.DropDownStyle = ComboBoxStyle.DropDown;
              //  cmb_Kho.Text = cmb_Kho.SelectedValue.ToString();
                bdsPN.EndEdit();
                bdsPN.ResetCurrentItem();
                this.PhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PhieuNhapTableAdapter.Update(this.DS.PhieuNhap);
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);
             
                bdsDH.Position = vitri;
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
                Program.savePhieu("n", txt_MaPN.Text, bds_sp_getCTPhieu, gridView_CTPN);
                MessageBox.Show("Ghi thành công", "", MessageBoxButtons.OK);
           
            //    Program.frmChinh.ReFresh();

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
            
            if(!gridView_CTPN.PostEditor())
            {
                return;
            }
            gc_sp_getCTPhieu.Focus();//bắt validate txtfield
            if (!ValidateMaPN())
            {
                txt_MaPN.Focus();
                return;
            }
            /*   if (txt_MaPN.Text.Trim() == "")
               {

                   MessageBox.Show("Mã phiếu nhập không được thiếu", "", MessageBoxButtons.OK);
                   txt_MaPN.Focus();

                   return;
               }
               if (cmb_Kho.SelectedIndex == -1 && cmb_Kho.Text == "")
               {
                   MessageBox.Show("Kho không được thiếu", "", MessageBoxButtons.OK);
                   cmb_Kho.Focus();
                   return;
               }
               if (cmb_Kho.SelectedIndex == -1 && cmb_Kho.Text != "")
               {
                   MessageBox.Show("Kho không có ở chi nhánh này", "", MessageBoxButtons.OK);
                   cmb_Kho.Focus();
                   return;
               }*/
            if (bds_sp_getCTPhieu.Count == 0)
            {
                MessageBox.Show("Chi tiết đơn phiếu nhập không được thiếu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gridView_CTPN.Focus();
                return;
            }
            if (Program.ExecSqlNonQuery("EXEC sp_TraCuu '" + txt_MaPN.Text + "'" + ", 'MAPN'") == 1)
            {
                txt_MaPN.Focus();
                dxErrorProvider1.SetError(txt_MaPN, "Mã phiếu nhập đã tồn tại");
                return;
            }
            else
            {
                dxErrorProvider1.SetError(txt_MaPN, null);
            }
            
       //     txt_MaPN.Focus();//để bắt validate của ctpn
            string mavt = ((DataRowView)bds_sp_getCTPhieu[bds_sp_getCTPhieu.Position])["MAVT"].ToString();
            string soLuongDDHString = ((DataRowView)bds_sp_getCTPhieu[bds_sp_getCTDDH.Find("MAVT", mavt)])["SOLUONG"].ToString();
            soLuongDDH = Int32.Parse(soLuongDDHString);
         /*   if (Int32.Parse(soLuongString) > soLuongDDH)
            {
                string tenVT = ((DataRowView)bds_sp_getCTPhieu[bds_sp_getCTPhieu.Position])["TENVT"].ToString();
                return;
            }*/

            if (savePN() == 0)
            {
                saveCTPN();
            }

            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            btn_xoaCTPN.Enabled = btn_ThemCTPN.Enabled = false;
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
            if (!Program.CheckOpened("frmThemCTPN"))
            {
                frmThemCTPN f = new frmThemCTPN();
                f.Show();
            }
            else return;
        }

        private void btn_TestCTPN_Click(object sender, EventArgs e)
        {

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
           
        }

        private void gridView_CTPN_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView_CTPN.FocusedColumn.FieldName == "SOLUONG" || gridView_CTPN.FocusedColumn.FieldName == "DONGIA")
            {
               

                int number = 0;
              
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
                dtCTPN.Rows.RemoveAt(bds_sp_getCTPhieu.Position);

                //gridView_getCTDDH.DeleteSelectedRows();
                bds_sp_getCTPhieu.RemoveAt(bds_sp_getCTPhieu.Position);
                btn_ThemCTPN.Enabled = true;
                btnThoat.Enabled = false;
                if (bds_sp_getCTPhieu.Count == 0)
                {
                    btn_xoaCTPN.Enabled = false;
                }
                else
                {
                    btn_xoaCTPN.Enabled = true;
                }
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void sp_getCTPhieuGridControl_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            if (gridView_CTPN.FocusedColumn.FieldName == "SOLUONG" || gridView_CTPN.FocusedColumn.FieldName == "DONGIA")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
              


            }
        }

        private void gridView_CTPN_ValidatingEditor_1(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView_CTPN.FocusedColumn.FieldName == "SOLUONG" || gridView_CTPN.FocusedColumn.FieldName == "DONGIA")
            {
              

                int number = 0;
                soLuongString = e.Value as string;
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

        private void gridView_DDH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            if (bdsDH.Count > 0)
            {
                gc_DDH.Focus();
                mddh = ((DataRowView)bdsDH[0])["MasoDDH"].ToString();
                
            }
            else
            {
                mddh = "";
                
            }
            if (bdsPN.Count > 0 && btnUndo.Enabled==false|| Program.mGroup.Equals("CONGTY")&& bdsPN.Count > 0)
            {

                mapn = ((DataRowView)bdsPN[0])["MAPN"].ToString();
                this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPhieuTableAdapter.Fill(DS.sp_getCTPhieu, mapn, "n");
                bds_sp_getCTPhieu.Position = 0;

                btn_ThemCTPN.Enabled = false;
                btnThem.Enabled = false;
                gridView_CTPN.OptionsBehavior.Editable = false;

            }
            else if (btnUndo.Enabled == false)
            {
                btn_ThemCTPN.Enabled = false;
                btnThem.Enabled = true;
                mapn = "";
                this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPhieuTableAdapter.Fill(DS.sp_getCTPhieu, mapn, "n");


                gridView_CTPN.OptionsBehavior.Editable = true;
            }
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
            }

            mddh = ((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString();
        }

        private void gridView_CTPN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
                string mavt = ((DataRowView)bds_sp_getCTPhieu[bds_sp_getCTPhieu.Position])["MAVT"].ToString();
                string soLuongString = ((DataRowView)bds_sp_getCTPhieu[bds_sp_getCTPhieu.Find("MAVT", mavt)])["SOLUONG"].ToString();
                soLuongDDH = Int32.Parse(soLuongString);

            
        }

        private void sp_getCTPhieuGridControl_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void gridView_CTPN_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
         
        }

        private void sp_getCTPhieuGridControl_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void gridView_CTPN_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            soLuongString = e.Value as string;
          //  gridView_CTPN.FocusedRowHandle = bds_sp_getCTPhieu.Position;
        }

        private void gridView_CTPN_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void txt_MaPN_Validating(object sender, CancelEventArgs e)
        {
            ValidateMaPN();
            
         
        }
        private bool ValidateMaPN()
        {
            bool bStatus = true;
           
                
                if (txt_MaPN.Text.Trim() == "")
                {

                    dxErrorProvider1.SetError(txt_MaPN, "Vui lòng nhập mã phiếu nhập");
                    bStatus = false;
                }
                else if (txt_MaPN.Text.Trim().Length > 8)
                {
                    dxErrorProvider1.SetError(txt_MaPN, "Mã phiếu nhập chỉ chứa tối đa 8 ký tự");
                    bStatus = false;

                }
                else
                    dxErrorProvider1.SetError(txt_MaPN, null);
        
            return bStatus;
        }
        
        private void txt_MaPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space) || (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            /*    if(e.KeyChar==Convert.ToChar (Keys.Back) && tempMAPN.Length>0)
                {
                    tempMAPN = tempMAPN.Substring(0, tempMAPN.Length - 1);
                }
                else 
                {
                    if(e.KeyChar != Convert.ToChar(Keys.Back))
                    tempMAPN = tempMAPN + e.KeyChar;
                }    
               
               gridView_PN.SetRowCellValue(bdsPN.Position, "MAPN", tempMAPN);
               
                gridView_PN.FocusedRowHandle = bdsPN.Position;*/
            }
        }

        private void txt_MaSoDDH_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_MaPN_Validated(object sender, EventArgs e)
        {
            
        }

        private void txt_MaPN_Properties_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            bdsPN.CancelEdit();

            if (btnThem.Enabled == false)
            {
                bdsDH.Position = vitri;

                gc_sp_getCTPhieu.Focus();// bắt validate PN
                cmb_Kho2.Enabled = false;
            }
            dxErrorProvider1.SetError(txt_MaPN, null);



            this.PhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PhieuNhapTableAdapter.Fill(DS.PhieuNhap);
            this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_getCTPhieuTableAdapter.Fill(DS.sp_getCTPhieu, "", "n");




           
            gc_DDH.Enabled = true;
            gc_DDH.Focus();
            txt_MaPN.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            btn_xoaCTPN.Enabled = btn_ThemCTPN.Enabled = false;
            gc_PhieuNhap.Enabled = true;
        }

        private void gc_DDH_Click(object sender, EventArgs e)
        {
         
        }

        private void gridView_DDH_ColumnFilterChanged(object sender, EventArgs e)
        {
           
         
            if (bdsDH.Count > 0)
            {
                gc_DDH.Focus();
                mddh = ((DataRowView)bdsDH[0])["MasoDDH"].ToString();
               
            }
            else
            {
                mddh = "";
            }
            if (bdsPN.Count > 0 && btnThem.Enabled==false || Program.mGroup.Equals("CONGTY")&& bdsPN.Count > 0)
            {

                mapn = ((DataRowView)bdsPN[0])["MAPN"].ToString();
                this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPhieuTableAdapter.Fill(DS.sp_getCTPhieu, mapn, "n");


                btn_ThemCTPN.Enabled = false;
                btnThem.Enabled = false;
                gridView_CTPN.OptionsBehavior.Editable = false;
                bds_sp_getCTPhieu.Position = 0;
            }
            else
            {
                btn_ThemCTPN.Enabled = false;
                btnThem.Enabled = true;
                mapn = "";
                this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPhieuTableAdapter.Fill(DS.sp_getCTPhieu, mapn, "n");


                gridView_CTPN.OptionsBehavior.Editable = true;
            }
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
            }

            mddh = ((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void cmb_Kho_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}