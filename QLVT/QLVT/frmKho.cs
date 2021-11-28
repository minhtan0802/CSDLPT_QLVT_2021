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
    public partial class frmKho : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string macn = "";
        string tenkho = "";
        string maKhoTemp = "";
        string tenKhoTemp = "";
        string diaChiTemp = "";
        string tenKhoMoi = "";
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
            txtMaKho.Enabled = true;
            btnThem.Enabled = false;
            btnGhi.Enabled = true;
            panelCtrl_Kho.Enabled = true;
            bdsKho.AddNew();
        
            vitri = bdsKho.Position;
            gridView_Kho.Columns[0].OptionsColumn.AllowEdit = true;
            gridView_Kho.SetRowCellValue(bdsKho.Position, "MACN", macn);
            gridView_Kho.FocusedRowHandle = bdsKho.Position;
            //   gcKho.Enabled = false;
            panelCtrl_Kho.Enabled = true;
       //     ((DataRowView)bdsKho[vitri])["MACN"] = macn;
            txtMaCN.Text = macn;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView_Kho.FocusInvalidRow();
            if (((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString() == "")
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
            }
            string strLenhMK = "EXEC sp_TraCuu @code='" + ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString() + "'" + ", @type='MAKHO'";
            string strLenhTK = "EXEC sp_TraCuu @code='" + ((DataRowView)bdsKho[bdsKho.Position])["TENKHO"].ToString() + "'" + ", @type='TENKHO'";
            int kiemTraMK = 0;
            int kiemtraTK = 0;
        
            if(gridView_Kho.Columns["MAKHO"].OptionsColumn.AllowEdit==true)
            {
                kiemTraMK = Program.ExecSqlNonQuery(strLenhMK);
                kiemtraTK = Program.ExecSqlNonQuery(strLenhTK);

            }
           
          
            tenKhoMoi = Program.StandardString(tenKhoMoi, "name");
       
            if (gridView_Kho.Columns["TENKHO"].OptionsColumn.AllowEdit == false && !tenkho.Equals(tenKhoMoi))
            {
                kiemtraTK = Program.ExecSqlNonQuery(strLenhTK);
            }    
             
            if (kiemTraMK != 1 && kiemtraTK != 1)
            {
                try
                {
                    ((DataRowView)bdsKho[bdsKho.Position])["DIACHI"] = Program.StandardString(((DataRowView)bdsKho[bdsKho.Position])["DIACHI"].ToString(), "add");
                    ((DataRowView)bdsKho[bdsKho.Position])["TENKHO"] =tenKhoMoi;
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
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            if (gridView_Kho.FocusedColumn.FieldName.Equals("MAKHO"))
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
        }

        private void gridView_Kho_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView_Kho.FocusedColumn.FieldName == "MAKHO")
            {
                string maKhoTemp = e.Value as string;
                if (maKhoTemp.Length > 4)
                {
                    e.Valid = false;
                    e.ErrorText = "Mã kho chỉ được tối đa 4 ký tự";
                }
            }
            else if (gridView_Kho.FocusedColumn.FieldName == "TENKHO")
            {
                string tenKhoTemp = e.Value as string;
                if (tenKhoTemp.Trim().Length > 30)
                {
                    e.Valid = false;
                    e.ErrorText = "Tên kho chỉ được tối đa 30 ký tự";
                }
            }
            else if (gridView_Kho.FocusedColumn.FieldName == "DIACHI")
            {
                string diaChiTemp = e.Value as string;
                if (diaChiTemp.Trim().Length > 100)
                {
                    e.Valid = false;
                    e.ErrorText = "Địa chỉ kho chỉ được tối đa 100 ký tự";
                }
            }




        }

        private void gridView_Kho_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        { 
        }

        private void gridView_Kho_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridView_Kho.FocusedColumn.FieldName.Equals("TENKHO"))
            {
                tenKhoMoi = e.Value as string;
            }    
            
        }

        private void gridView_Kho_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            tenkho = ((DataRowView)bdsKho[bdsKho.Position])["TENKHO"].ToString();
        }
    }
}
