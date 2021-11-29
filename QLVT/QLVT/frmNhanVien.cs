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
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string macn = "";
        ErrorProvider errorProviderMANV = new ErrorProvider();
        ErrorProvider errorProviderHO = new ErrorProvider();
        ErrorProvider errorProviderTEN = new ErrorProvider();
        ErrorProvider errorProviderDIACHI = new ErrorProvider();
        ErrorProvider errorProviderLUONG = new ErrorProvider();
        ErrorProvider errorProviderNGAYSINH = new ErrorProvider();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENTableAdapter.Fill(this.DS.NhanVien);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            macn = ((DataRowView)bdsNV[0])["MACN"].ToString(); // Lúc đúng lúc sai, tìm cách khác.
            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            panelCtrl_NhanVien.Enabled = false;
         //   txtMaNV.Enabled = false;

            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = btnChuyenCN.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnChuyenCN.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled = false;

            }
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void mACNLabel_Click(object sender, EventArgs e)
        {

        }

        private void mACNTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nhanVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            panelCtrl_NhanVien.Enabled = true;
            bdsNV.AddNew();
            txtMaNV.Enabled = true;
            txtMACN.Text = macn;
            dtpNgaySinh.EditValue = "";
            ((DataRowView)bdsNV[bdsNV.Position])["TrangThaiXoa"] = 0;
            txtMaNV.Focus();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcNhanVien.Enabled = false;
            panelCtrl_NhanVien.Enabled = true;
          
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (btnThem.Enabled == false) bdsNV.Position = vitri;
            dxErrorProvider1.SetError(txtDiaChi, null);
            dxErrorProvider1.SetError(txtHo, null);
            dxErrorProvider1.SetError(txtTen, null);
            dxErrorProvider1.SetError(txtMaNV, null);
            dxErrorProvider1.SetError(txtLuong, null);
            dxErrorProvider1.SetError(dtpNgaySinh, null);
            gcNhanVien.Enabled = true;
            panelCtrl_NhanVien.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            txtMACN.Enabled = txtMaNV.Enabled = false;
            panelCtrl_NhanVien.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.NHANVIENTableAdapter.Fill(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 manv = 0;
            if (bdsDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên vì đã lập đơn đặt hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên vì đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPX.Count > 0)
            {
                {
                    MessageBox.Show("Không thể xóa nhân viên vì đã lập phiếu xuất", "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                    bdsNV.RemoveCurrent();//Xóa trên máy hiện tại trước
                    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHANVIENTableAdapter.Update(this.DS.NhanVien);//Xóa trên CSDL
                    MessageBox.Show("Xóa nhân viên thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.NHANVIENTableAdapter.Fill(this.DS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    
                    return;
                }
            }
            if (bdsNV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.DS.NhanVien);
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
             
            }
        }
        
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMaNV.DoValidate();
            bool checkError = true;
            if (!Validate(txtDiaChi))
            {
                txtDiaChi.Focus();
                checkError = false;
            }

            if (!ValidateLuong())
            {
                txtLuong.Focus();
                checkError = false;
            }
            if (!ValidateNgaySinh())
            {
                dtpNgaySinh.Focus();
                checkError = false;
            }
            if (!Validate(txtTen))
            {
                txtTen.Focus();
                checkError = false;
            }
            if (!Validate(txtHo))
            {
                txtHo.Focus();
                checkError = false;
            }
            if (!Validate(txtMaNV))
            {
                txtMaNV.Focus();
                checkError = false;
            }


            if (!checkError)
            {
                return;
            }





            /*     if (txtMaNV.Text.Trim() == "")
                 {
                     MessageBox.Show("Mã nhân viên không được thiếu", "", MessageBoxButtons.OK);
                     txtMaNV.Focus();
                     return;
                 }
                 if (txtHo.Text.Trim() == "")
                 {
                     MessageBox.Show("Họ nhân viên không được thiếu", "", MessageBoxButtons.OK);
                     txtHo.Focus();
                     return;
                 }
                 if (txtTen.Text.Trim() == "")
                 {
                     MessageBox.Show("Tên nhân viên không được thiếu", "", MessageBoxButtons.OK);
                     txtTen.Focus();
                     return;
                 }
                 if (dtpNgaySinh.Text.ToString().Trim() == "")
                 {
                     MessageBox.Show("Ngày sinh nhân viên không được thiếu", "", MessageBoxButtons.OK);
                     dtpNgaySinh.Focus();
                     return;
                 }*/

            /*    if(txtLuong.Text.Equals(""))
                {
                 //   MessageBox.Show("Lương nhân viên không được thiếu", "", MessageBoxButtons.OK);

                    txtLuong.Focus();
                    checkError = false;
                   return;
                }*/


            /*   if (txtDiaChi.Text.Trim() == "")
               {
                //   MessageBox.Show("Địa chỉ không được thiếu", "", MessageBoxButtons.OK);
                   txtDiaChi.Focus();
                   return;
               }*/

            string strLenh = "EXEC sp_TraCuu @code='" + txtMaNV.Text + "'" + ", @type='MANV'";
            int kiemTraMaNV = 0;
        
            if (txtMaNV.Enabled == true)
            {
                kiemTraMaNV = Program.ExecSqlNonQuery(strLenh);
                if(kiemTraMaNV==1)
                {
                    txtMaNV.Focus();
                    dxErrorProvider1.SetError(txtMaNV, "Mã nhân viên đã tồn tại");
                    return;
                }
                else
                {
                    dxErrorProvider1.SetError(txtMaNV, "");
                }    
            }

            if (kiemTraMaNV != 1)
            {
                try
                {
                    ((DataRowView)bdsNV[bdsNV.Position])["HO"] = Program.StandardString(txtHo.Text, "name");
                   ((DataRowView)bdsNV[bdsNV.Position])["TEN"] = Program.StandardString(txtTen.Text, "name");
                   ((DataRowView)bdsNV[bdsNV.Position])["DIACHI"] = Program.StandardString(txtDiaChi.Text, "add");
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHANVIENTableAdapter.Update(this.DS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                gcNhanVien.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled = false;

                panelCtrl_NhanVien.Enabled = false;
                this.NHANVIENTableAdapter.Fill(this.DS.NhanVien);
                //     frmTaoAcc.LayDSNVChuaCoAcc("EXEC sp_getTaiKhoanChuaCoAcc");
                //  frm
              
            }    
           
            
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtHo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xrpt_DSNhanVien rpt = new Xrpt_DSNhanVien();
            string tenCN = "";
            if (Program.servername.Contains("1"))
            {
                tenCN = "1";
            }
            else
            {
                tenCN = "2";
            }
            rpt.label_TieuDe.Text = "DANH SÁCH NHÂN VIÊN CHI NHÁNH " + tenCN;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        String CNchuyen;
        public void chuyenChiNhanh(String index)
        {
                CNchuyen = index;
                String maCN = "";
                if (CNchuyen.Contains("2")) maCN = "CN2";
                else if (CNchuyen.Contains("1")) maCN = "CN1";

                String maNV = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
                string strLenh = "EXEC sp_ChuyenChiNhanhNV @MANV='" + maNV + "'" + ", @MACN='" + maCN + "'";
                try
                {
                    Program.ExecSqlNonQuery(strLenh);
                    MessageBox.Show("Chuyển nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.NHANVIENTableAdapter.Fill(this.DS.NhanVien);
                    btnUndo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
          //  else
            //    MessageBox.Show("Vui lòng chọn CN khác chi nhánh hiện tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private SqlConnection conn_publisher = new SqlConnection();

     
        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                frmChuyenCN pickCN = new frmChuyenCN();
                pickCN.getCN = new frmChuyenCN.getChiNhanh(chuyenChiNhanh);
                pickCN.ShowDialog();
         
        }

  
       


        private bool Validate(DevExpress.XtraEditors.TextEdit txt)
        {
            bool bStatus = true;
            if(txt.Name=="txtMaNV")
            {
                if (txt.Text.Trim() == "")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập mã nhân viên");
                    bStatus = false;
                }
                else
                    dxErrorProvider1.SetError(txt, "");
            }
            else if (txt.Name=="txtHo")
            {
                if(txt.Text.Trim()=="")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập họ nhân viên");
                    bStatus = false;

                }  
                else if(txt.Text.Trim().Length>40)
                {
                    dxErrorProvider1.SetError(txt, "Họ nhân viên chỉ chứa tối đa 40 ký tự");
                    bStatus = false;
                }
                else
                {
                    dxErrorProvider1.SetError(txt, "");
                }
            }
            else if (txt.Name == "txtTen")
            {
                if (txt.Text.Trim() == "")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập tên nhân viên");
                    bStatus = false;

                }
                else if (txt.Text.Trim().Length > 10)
                {
                    dxErrorProvider1.SetError(txt, "Họ nhân viên chỉ chứa tối đa 40 ký tự");
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
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập địa chỉ của nhân viên");
                    bStatus = false;

                }
                else if (txt.Text.Trim().Length > 100)
                {
                    dxErrorProvider1.SetError(txt, "Địa chỉ của nhân viên chỉ chứa tối đa 40 ký tự");
                    bStatus = false;
                }
                else
                {
                    dxErrorProvider1.SetError(txt, "");
                }
            }  
            return bStatus;
        }

      
        private void txtLuong_Validating(object sender, CancelEventArgs e)
        {
            ValidateLuong();
              
        }

       

        private void dtpNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            ValidateNgaySinh();
            
        }
        private bool ValidateNgaySinh()
        {
            bool bStatus = true;
            if (dtpNgaySinh.Text.Trim() == "")
            {
                dxErrorProvider1.SetError(dtpNgaySinh, "Vui lòng nhập ngày sinh của nhân viên");
                return false;
            }

            else if (dtpNgaySinh.DateTime >= DateTime.Now)
            {
                //  MessageBox.Show("Ngày sinh nhân viên không được lớn hơn hoặc bằng ngày hiện tại ", "", MessageBoxButtons.OK);
                dxErrorProvider1.SetError(dtpNgaySinh, "Ngày sinh nhân viên không được lớn hơn hoặc bằng ngày hiện tại");
                bStatus = false;

                //   return;
            }
            else if (!((DateTime.Now.Year - dtpNgaySinh.DateTime.Year) > 15 || ((DateTime.Now.Year - dtpNgaySinh.DateTime.Year) == 15 && ((DateTime.Now.Month - dtpNgaySinh.DateTime.Month) == 0)
                && ((DateTime.Now.Day - dtpNgaySinh.DateTime.Day) == 0))))
            {
                //  MessageBox.Show("Nhân viên phải đủ 15t trở lên mới được nhận việc", "", MessageBoxButtons.OK);
                dxErrorProvider1.SetError(dtpNgaySinh, "Nhân viên phải đủ 15t trở lên mới được nhận việc");

                bStatus = false;
                //return;
            }
            else
            {
                dxErrorProvider1.SetError(dtpNgaySinh, "");
            }


            return bStatus;
        }
        private bool ValidateLuong()
        {
         
            bool bStatus = true;

            if (txtLuong.Text.Trim() == "")
            {
                dxErrorProvider1.SetError(txtLuong, "Vui lòng nhập lương của nhân viên");
                bStatus = false;

            }
            else if(txtLuong.Text!="")
            {
                try
                {
                    string luong = txtLuong.Text;
                    while (luong.IndexOf('.') != -1)
                        luong = luong.Remove(luong.IndexOf('.'), 1);
                  
                    if (int.Parse(luong) < 4000000)
                    {
                        dxErrorProvider1.SetError(txtLuong, "Lương của nhân viên không được nhỏ 4.000.000đ");
                        bStatus = false;
                    }
                    else
                    {
                        dxErrorProvider1.SetError(txtLuong, "");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message, "", MessageBoxButtons.OK);
                    
                }
            }
            else dxErrorProvider1.SetError(txtLuong, "");
            return bStatus;

        }

        private void txtMaNV_Validating_1(object sender, CancelEventArgs e)
        {
            Validate(txtMaNV);
           
        }

        private void txtHo_Validating_1(object sender, CancelEventArgs e)
        {
            Validate(txtHo);
           
        }

        private void txtTen_Validating_1(object sender, CancelEventArgs e)
        {
            Validate(txtTen);
           
        }

        private void txtDiaChi_Validating_1(object sender, CancelEventArgs e)
        {
            Validate(txtDiaChi);
           
        }

        private void txtMaNV_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHo_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtTen_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
 }