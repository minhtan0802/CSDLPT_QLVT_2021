using DevExpress.XtraEditors;
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
    public partial class frmPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtVTDaCo = new DataTable();
    
        String maPX = "";
        int vitri;
        public string getMaPX()
        {
            return maPX;
        }
        public DataTable getVatTuDaCo()
        {
            return dtVTDaCo;
        }
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPX.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        private void load()
        {
            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
        
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.DS.CTPX);
            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            dtVTDaCo = new DataTable();
            dtVTDaCo.Columns.Add("MAVT", typeof(string));
        
            if (bdsPX.Count > 0)
            {
                vitri = 0;
                maPX = txt_MAPX.Text;
                btn_ThemCTPX.Enabled = btn_XoaCTPX.Enabled = false;
                gridView_CTPX.OptionsBehavior.Editable = false;
               

            }
            else
            {
                btn_ThemCTPX.Enabled = btn_XoaCTPX.Enabled = true;
                gridView_CTPX.OptionsBehavior.Editable = true;
                maPX = "";
            }

            this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_getCTPhieuTableAdapter.Fill(this.DS.sp_getCTPhieu, maPX, "x");
        }
        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            load();
            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            panelCtrl_PX.Enabled = false;
           // cmb_MaKho.Text = cmb_MaKho.SelectedValue.ToString();
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled = false;
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void phieuXuatGridControl_MouseCaptureChanged(object sender, EventArgs e)
        {
          
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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsPX.Position;
            gridView_CTPX.OptionsBehavior.Editable = true;
       //     cmb_MaKho.DropDownStyle = ComboBoxStyle.DropDownList;
            bdsPX.AddNew();
            gc_PhieuXuat.Enabled = false;
            label_Kho.Text = "Kho:";
            txt_MAPX.Enabled = true;
            

            cmb_MaKho.SelectedText = "";
            cmb_MaKho.Text = "";
        //    cmb_MaKho.SelectedIndex = -1;
    
            cmb_MaKho.Enabled = true;
            txt_KH.Enabled = true;
            dateEdit_NgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_MaNV.Text = Program.username;
            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
          
            dtVTDaCo.Clear();
            panelCtrl_PX.Enabled = true;
            btn_ThemCTPX.Enabled = true;
            btn_XoaCTPX.Enabled = false;
            this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_getCTPhieuTableAdapter.Fill(DS.sp_getCTPhieu, "", "x");
            txt_MAPX.Focus();
            gridView_CTPX.Columns[2].OptionsColumn.AllowEdit = true;
            gridView_CTPX.Columns[3].OptionsColumn.AllowEdit = true;
        }
        private int savePX()
        {
            try
            {
         //       cmb_MaKho.DropDownStyle = ComboBoxStyle.DropDown;
          //      cmb_MaKho.Text = cmb_MaKho.SelectedValue.ToString();
                ((DataRowView)bdsPX[bdsPX.Position])["MAKHO"] = cmb_MaKho.Text;
                bdsPX.EndEdit();
                bdsPX.ResetCurrentItem();
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi phiếu nhập.\n" + ex.Message, "", MessageBoxButtons.OK);
                return -1;
            }
        }
        private int saveCTPX()
        {
            try
            {
                Program.savePhieu("x", txt_MAPX.Text, bds_sp_getCTPhieu, gridView_CTPX);
                this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPhieuTableAdapter.Fill(this.DS.sp_getCTPhieu, txt_MAPX.Text,"x");
                gridView_CTPX.Columns[2].OptionsColumn.AllowEdit = false;
                gridView_CTPX.Columns[3].OptionsColumn.AllowEdit = false; ;
                gridView_CTPX.OptionsBehavior.Editable = false;
                Program.frmVT.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                Program.frmVT.VatTuTableAdapter.Fill(Program.frmVT.DS.Vattu);
                MessageBox.Show("Ghi thành công!", "", MessageBoxButtons.OK);
                panelCtrl_PX.Enabled = false;
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi CTPX.\n" + ex.Message, "", MessageBoxButtons.OK);
                return -1;
            }

        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!gridView_CTPX.PostEditor())
            { 
                return;
            }
            bool checkError = true;
            if(!ValidateCombKho(cmb_MaKho))
            {
                cmb_MaKho.Focus();
                checkError = false;
            }    
            if(!Validate(txt_KH))
            {
                txt_KH.Focus();
                checkError = false;
            }    
            if(!Validate(txt_MAPX))
            {
                txt_MAPX.Focus();
                checkError = false;
            }
        
            if (!checkError)
            {
                return;
            }
            if (bds_sp_getCTPhieu.Count == 0)
            {
                MessageBox.Show("Chi tiết phiếu xuất không được thiếu", "", MessageBoxButtons.OK);
                gridView_CTPX.Focus();
                return;
            }
            /* if (txt_MAPX.Text.Trim() == "")
             {
                 MessageBox.Show("Mã phiếu xuất không được thiếu", "", MessageBoxButtons.OK);
                 txt_MAPX.Focus();
                 return;
             }
             if (txt_KH.Text.Trim() == "")
             {
                 MessageBox.Show("Tên khách hàng không được thiếu", "", MessageBoxButtons.OK);
                 txt_KH.Focus();
                 return;
             }

             if (cmb_MaKho.SelectedIndex == -1 && cmb_MaKho.Text == "")
             {
                 MessageBox.Show("Kho không được thiếu", "", MessageBoxButtons.OK);
                 cmb_MaKho.Focus();
                 return;
             }
             if (cmb_MaKho.SelectedIndex == -1 && cmb_MaKho.Text != "")
             {
                 MessageBox.Show("Kho không có ở chi nhánh này", "", MessageBoxButtons.OK);
                 cmb_MaKho.Focus();
                 return;
             }*/

            string strLenh = "EXEC sp_TraCuu '" + txt_MAPX.Text + "'" + ", 'MAPX'";
                int ret = Program.ExecSqlNonQuery(strLenh);
                if (ret == 1)
                {
                    txt_MAPX.Focus();
                    dxErrorProvider1.SetError(txt_MAPX, "Mã phiếu xuất đã tồn tại");
                    return;
                }
                else
                {
                    dxErrorProvider1.SetError(txt_MAPX, null);
                }    
              
            
            
            if (savePX() == 0)
            {
                saveCTPX();
            }
            label_Kho.Text = "Mã kho:";
            gc_PhieuXuat.Enabled = true;
            cmb_MaKho.Enabled = txt_MaNV.Enabled = txt_MAPX.Enabled = dateEdit_NgayLap.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btn_ThemCTPX.Enabled = btn_XoaCTPX.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = false;
            groupBox_CTPX.Enabled = true;
        }

        private void btn_ThemCTPX_Click(object sender, EventArgs e)
        {
            if (!Program.CheckOpened("frmThemCTPX"))
            {
                frmThemCTPX f = new frmThemCTPX();
                f.Show();
            }
            else return;
        }

        private void btn_XoaCTPX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa kho này?", "Xác nhận",
             MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dtVTDaCo.Rows.RemoveAt(bds_sp_getCTPhieu.Position);

                //gridView_getCTDDH.DeleteSelectedRows();
                bds_sp_getCTPhieu.RemoveAt(bds_sp_getCTPhieu.Position);
                btn_ThemCTPX.Enabled = true;
                btnThoat.Enabled = false;
                if (bds_getCTPX.Count == 0)
                {
                    btn_XoaCTPX.Enabled = false;
                }
                else
                {
                    btn_XoaCTPX.Enabled = true;
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gridView_CTPX_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            string maVT = gridView_CTPX.GetRowCellValue(gridView_CTPX.FocusedRowHandle, "MAVT").ToString();
           
            Program.KetNoi();
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select SOLUONGTON from Vattu as VT where VT.MAVT ='" + maVT + "'", Program.conn);
            da.Fill(dt);
            int soLuongTon = Int32.Parse(dt.Rows[0][0].ToString());
            if (gridView_CTPX.FocusedColumn.FieldName == "SOLUONG" || gridView_CTPX.FocusedColumn.FieldName == "DONGIA")
            {
                int rows = gridView_CTPX.FocusedRowHandle;
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
                else if (Int32.Parse(soLuongString) == 0 && gridView_CTPX.FocusedColumn.FieldName == "SOLUONG")
                {
                    e.Valid = false;
                    e.ErrorText = "Số lượng phải phải lớn hơn 0";
                }
                else if (Int32.Parse(soLuongString) > soLuongTon && gridView_CTPX.FocusedColumn.FieldName == "SOLUONG")
                {
                    e.Valid = false;
                    e.ErrorText = "Số lượng nhập không được lớn hơn số lượng tồn là: "+soLuongTon;
                }


            }
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
          

        }

        private void sp_getCTPhieuGridControl_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            if (gridView_CTPX.FocusedColumn.FieldName == "SOLUONG" || gridView_CTPX.FocusedColumn.FieldName == "DONGIA")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void gridView_CTPX_ValidatingEditor_1(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            string maVT = gridView_CTPX.GetRowCellValue(gridView_CTPX.FocusedRowHandle, "MAVT").ToString();
            int pos = bdsVatTu.Find("MAVT", maVT);
            int soLuongTon = int.Parse(((DataRowView)bdsVatTu[pos])["SOLUONGTON"].ToString());
            if (gridView_CTPX.FocusedColumn.FieldName == "SOLUONG" || gridView_CTPX.FocusedColumn.FieldName == "DONGIA")
            {
                int rows = gridView_CTPX.FocusedRowHandle;
                int number = 0;
                string soLuongString = e.Value as string;
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
                else if (Int32.Parse(soLuongString) == 0 && gridView_CTPX.FocusedColumn.FieldName == "SOLUONG")
                {
                    e.Valid = false;
                    e.ErrorText = "Số lượng phải phải lớn hơn 0";
                }
                else if (Int32.Parse(soLuongString) > soLuongTon && gridView_CTPX.FocusedColumn.FieldName == "SOLUONG")
                {
                    e.Valid = false;
                    e.ErrorText = "Số lượng xuất không được lớn hơn số lượng tồn là " + soLuongTon;
                }


            }
        }

        private void gridView_PX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
      
            
            maPX = txt_MAPX.Text;
            if(btnThem.Enabled==true)
            {
                this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPhieuTableAdapter.Fill(this.DS.sp_getCTPhieu, maPX, "x");
                dtVTDaCo.Clear();
                for (int i = 0; i < bds_sp_getCTPhieu.Count; i++)
                {
                    dtVTDaCo.Rows.Add(((DataRowView)bds_sp_getCTPhieu[i])["MAVT"]);
                }
               
            }    
           
          
        }

        private void txt_MAPX_Validating(object sender, CancelEventArgs e)
        {
            Validate(txt_MAPX);
             
        }
        private bool Validate(DevExpress.XtraEditors.TextEdit txt)
        {
            bool bStatus = true;
            if (txt.Name == "txt_MAPX")
            {
                if (txt.Text.Trim() == "")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập mã phiếu xuất");
                    bStatus = false;
                }
                else if (txt.Text.Length > 8)
                {
                    dxErrorProvider1.SetError(txt, "Mã phiếu xuất chỉ chứa tối đa 8 ký tự");
                    bStatus = false;
                }
                else
                    dxErrorProvider1.SetError(txt, null);
            }
            else if (txt.Name == "txt_KH")
            {
                if (txt.Text.Trim() == "")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập tên khách hàng");
                    bStatus = false;

                }
                else if (Program.StandardString(txt.Text, "name").Length > 100)
                {
                    dxErrorProvider1.SetError(txt, "Tên khách hàng chỉ chứa tối đa 100 ký tự");
                    bStatus = false;
                }
                else
                {
                    dxErrorProvider1.SetError(txt, null);
                }
            }
            return bStatus;
        }

        private void cmb_MaKho_Validating(object sender, CancelEventArgs e)
        {
            if(!ValidateCombKho(cmb_MaKho))
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }    
        }
        private bool ValidateCombKho(DevExpress.XtraEditors.GridLookUpEdit txt)
        {
            bool bStatus = true;

            if (txt.SelectedText == "")
            {
                dxErrorProvider1.SetError(txt, "Vui lòng chọn kho");
                bStatus = false;
            }
            else
            {
                dxErrorProvider1.SetError(txt, "");
            }

            return bStatus;
        }

        private void txt_MAPX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space) || (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            }
        }

        private void txt_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (e.KeyChar == item)
                {
                    e.Handled = true;

                }
            }
        }

        private void txt_KH_Validating(object sender, CancelEventArgs e)
        {
            Validate(txt_KH);
           
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPX.CancelEdit();
            if (btnThem.Enabled == false) bdsPX.Position = vitri;
          
            dxErrorProvider1.SetError(txt_KH, null);
            dxErrorProvider1.SetError(txt_MAPX, null);
            dxErrorProvider1.SetError(cmb_MaKho, null);
            maPX = ((DataRowView)bdsPX[vitri])["MAPX"].ToString();
          //  cmb_MaKho.DropDownStyle = ComboBoxStyle.DropDown;
            this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_getCTPhieuTableAdapter.Fill(this.DS.sp_getCTPhieu, maPX, "x");
            gc_PhieuXuat.Enabled = true;
            gc_PhieuXuat.Focus();
            panelCtrl_PX.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;

        }

        private void gc_PhieuXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }

        private void cmb_MaKho_Validating_1(object sender, CancelEventArgs e)
        {
            ValidateCombKho(cmb_MaKho);
        }
    }
}