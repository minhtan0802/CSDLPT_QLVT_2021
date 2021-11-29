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
    public partial class frmKho : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string macn = "";
        string tenKhoCu = "";
        string maKhoTemp = "";
        string tenKhoTemp = "";
        string diaChiTemp = "";
        string tenKhoMoi = "";
        ErrorProvider errorProviderMAKHO = new ErrorProvider();
        ErrorProvider errorProviderDIACHI = new ErrorProvider();
        ErrorProvider errorProviderTENKHO = new ErrorProvider();
        public frmKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);
            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.ư
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            // TODO: This line of code loads data into the 'DS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            // TODO: This line of code loads data into the 'DS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            macn = ((DataRowView)bdsKho[0])["MACN"].ToString(); // Lúc đúng lúc sai, tìm cách khác.
            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            panelCtrl_Kho.Enabled = false;
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled = false;
            }




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
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.DS.Kho);
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                if (Program.servername.Contains("1"))
                {
                    macn = "CN1";
                }
                else
                {
                    macn = "CN2";
                }

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            txtMaKho.Enabled = true;
            btnThem.Enabled = false;
            btnGhi.Enabled = true;
            btnUndo.Enabled = true;
            panelCtrl_Kho.Enabled = true;
            bdsKho.AddNew();
        
          
            gridView_Kho.Columns[0].OptionsColumn.AllowEdit = true;
      
       //     gridView_Kho.FocusedRowHandle = bdsKho.Position;
             gcKho.Enabled = false;
            panelCtrl_Kho.Enabled = true;
       //     ((DataRowView)bdsKho[vitri])["MACN"] = macn;
            txtMaCN.Text = macn;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            txtMaKho.Enabled = false;
            panelCtrl_Kho.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcKho.Enabled = false;
            tenKhoCu = txtTenKho.Text;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool checkError = true;
            if(!Validate(txtDiaChi))
            {
                txtDiaChi.Focus();
                checkError = false;
            }    
            if(!Validate(txtTenKho))
            {
                txtTenKho.Focus();
                checkError = false;
            }    
            if(!Validate(txtMaKho))
            {
                txtMaKho.Focus();
                checkError = false;
            }   
            if(!checkError)
            {
                return;
            }    
        /*    if (((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString() == "")
            {
                MessageBox.Show("Mã kho không được thiếu", "", MessageBoxButtons.OK);
                gridView_Kho.FocusedRowHandle = bdsKho.Position;
                return;
            }
            if (((DataRowView)bdsKho[bdsKho.Position])["TENKHO"].ToString().Trim()=="")
            {
                MessageBox.Show("Tên kho không được thiếu", "", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return;
            }
            if (((DataRowView)bdsKho[bdsKho.Position])["DIACHI"].ToString().Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }*/
            string strLenhMK = "EXEC sp_TraCuu @code='" +txtMaKho.Text + "',@type='MAKHO'";
            string strLenhTK = "EXEC sp_TraCuu @code=N'" + Program.StandardString(txtTenKho.Text,"name") + "'" + ", @type='TENKHO'";
            int kiemTraMK = 0;
            int kiemTraTK = 0;
           
            if (txtMaKho.Enabled==true)
            {
                kiemTraMK = Program.ExecSqlNonQuery(strLenhMK);
               if(kiemTraMK==1)
                {
                    txtMaKho.Focus();
                    dxErrorProvider1.SetError(txtMaKho, "Mã kho đã tồn tại");
                    return;
                }
                else
                {
                    dxErrorProvider1.SetError(txtMaKho, "");
                }    
                kiemTraTK = Program.ExecSqlNonQuery(strLenhTK);
                if (kiemTraTK == 1)
                {
                    txtTenKho.Focus();
                    dxErrorProvider1.SetError(txtTenKho, "Tên kho đã tồn tại ");
                    return;
                }
                else
                {
                    dxErrorProvider1.SetError(txtTenKho, "");
                }    

            }

            







            if (txtMaKho.Enabled==false && !tenKhoCu.ToLower().Equals(Program.StandardString(txtTenKho.Text, "name").ToLower()))
            {
           
                kiemTraTK = Program.ExecSqlNonQuery(strLenhTK);
                if(kiemTraTK==1)
                {
                    txtTenKho.Focus();
                    errorProviderMAKHO.SetError(txtTenKho, "Tên kho đã tồn tại");
                    return;
                } 
                else
                {
                    errorProviderMAKHO.SetError(txtTenKho, "");
                }    
            }    
             
            if (kiemTraMK != 1 && kiemTraTK != 1)
            {
                try
                {
                    txtDiaChi.Text = Program.StandardString(txtDiaChi.Text, "add");
                    txtTenKho.Text = Program.StandardString(txtTenKho.Text, "name");
                    bdsKho.EndEdit();
                    bdsKho.ResetCurrentItem();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.DS.Kho);
                    MessageBox.Show("Ghi thành công", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi kho.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                gridView_Kho.Columns[0].OptionsColumn.AllowEdit = false;
                gcKho.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled = false;

                panelCtrl_Kho.Enabled = false;
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKho.CancelEdit();
            if (btnThem.Enabled == false) bdsKho.Position = vitri;
            dxErrorProvider1.SetError(txtDiaChi, null);
            dxErrorProvider1.SetError(txtMaKho, null);
            dxErrorProvider1.SetError(txtTenKho, null);
         

            gcKho.Enabled = true;
            panelCtrl_Kho.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.DS.Kho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void txtTenKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (e.KeyChar == item)
                {
                    e.Handled = true;

                }
            }
        }

        private void txtMaKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (e.KeyChar == item)
                {
                    e.Handled = true;

                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String makho = "";
            if (bdsDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho vì đã có đơn đặt hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho vì đã có phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPX.Count > 0)
            {
                {
                    MessageBox.Show("Không thể xóa kho vì đã có phiếu xuất", "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa kho này?", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    makho = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();
                    bdsKho.RemoveCurrent();//Xóa trên máy hiện tại trước
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.DS.Kho);//Xóa trên CSDL
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.DS.Kho);
                    bdsKho.Position = bdsKho.Find("MAKHO", makho);
                    return;
                }
            }
            if (bdsKho.Count == 0) btnXoa.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcKho_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void gridView_Kho_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
           




        }

        private void gridView_Kho_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        { 
        }

        private void gridView_Kho_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
             
            
        }

        private void gridView_Kho_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }

        private void txtMaKho_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtMaKho);
            
                   }
        private bool Validate(DevExpress.XtraEditors.TextEdit txt)
        {
            bool bStatus = true;
            if (txt.Name == "txtMaKho")
            {
               
             
                if (txt.Text.Trim() == "")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập mã kho");
                    bStatus = false;
                }
                else if(txt.Text.Trim().Length>4)
                {
                    dxErrorProvider1.SetError(txt, "Mã kho chỉ chứa tối đa 4 ký tự");
                    bStatus = false;
                }
                else
                    dxErrorProvider1.SetError(txt, "");
            }
            else if (txt.Name == "txtTenKho")
            {
                if (txt.Text.Trim() == "")
                {
                   dxErrorProvider1.SetError(txt, "Vui lòng nhập tên kho");
                    bStatus = false;

                }
                else if (Program.StandardString(txt.Text,"name").Length > 40)
                {
                    dxErrorProvider1.SetError(txt, "Tên kho chỉ chứa tối đa 30 ký tự");
                    bStatus = false;
                }
                else
                {
                    dxErrorProvider1.SetError(txt, "");
                }
            }
            else if (txt.Name == "txtDiaChi")
            {
                if (txt.Text.Trim() == "")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập địa chỉ kho");
                    bStatus = false;

                }
                else if (Program.StandardString(txt.Text, "add").Length > 100)
                {
                    dxErrorProvider1.SetError(txt, "Địa chỉ kho chỉ chứa tối đa 100 ký tự");
                    bStatus = false;
                }
                else
                {
                    dxErrorProvider1.SetError(txt, "");
                }
            }





            return bStatus;
        }

        private void txtMaKho_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtDiaChi);
        }

        private void txtTenKho_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtTenKho);
           
          
        }

        private void gcKho_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
