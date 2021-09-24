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
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnChuyenCN.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled =  btnChuyenCN.Enabled = btnRefresh.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled =  false;
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
                macn = ((DataRowView)bdsKho[0])["MACN"].ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            panelCtrl_Kho.Enabled = true;
            bdsKho.AddNew();
            
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcKho.Enabled = true;
            panelCtrl_Kho.Enabled = true;
            txtMaCN.Text = macn;
            txtMaKho.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            tenkho = txtTenKho.Text;
            txtMaCN.Enabled = txtMaKho.Enabled = false;
            panelCtrl_Kho.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcKho.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được thiếu", "", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return;
            }
            if (txtTenKho.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được thiếu", "", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }    
            string strLenhMK = "EXEC sp_TraCuu @code='" + txtMaKho.Text + "'" + ", @type='MAKHO'";
            string strLenhTK = "EXEC sp_TraCuu @code='" + txtTenKho.Text + "'" + ", @type='TENKHO'";
            int kiemTraMK = 0;
            if (txtMaKho.Enabled == true)
            {
                kiemTraMK = Program.ExecSqlNonQuery(strLenhMK);
            }
            int kiemtraTK = 0;
            if (!(txtTenKho.Text == tenkho))//edit
            {
                kiemtraTK = Program.ExecSqlNonQuery(strLenhTK);
            }    
               
            if (kiemTraMK != 1 && kiemtraTK!=1)
            {
                try
                {
                    bdsKho.EndEdit();
                    bdsKho.ResetCurrentItem();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.DS.Kho);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi kho.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
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
    }
    }
