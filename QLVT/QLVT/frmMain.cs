using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExist(Type ftype)
        {
            foreach(Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btn_DangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmDN = new frmDangNhap();
                Program.frmDN.MdiParent = this;
                Program.frmDN.Show();
            }    
        }

        public void HienThiMenu()
        {
            Program.frmChinh.MANV.Text = "Mã NV = " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ tên= " + Program.mHoTen;
            Program.frmChinh.NHOM.Text = "Nhóm " + Program.mGroup;
            btn_DangXuat.Enabled = true;
            btn_DangNhap.Enabled = false;
            //Phân quyền
            rib_BaoCao.Visible = rib_DanhMuc.Visible = rib_NghiepVu.Visible = true;
            //tiếp tục if trên Program.mGroup để bật/ tắt các nút lệnh trên Menu chính
            if (Program.mGroup=="USER")
            {
                btn_TaoTaiKhoan.Enabled = false;
            }    
        }

        private void btn_NhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

     

    

        private void btn_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(frmKho));
            if (frm != null) frm.Close();
            frm = this.CheckExist(typeof(frmNhanVien));
            if (frm != null) frm.Close();
            frm = this.CheckExist(typeof(frmVatTu));
            if (frm != null) frm.Close();
            btn_DangXuat.Enabled = btn_TaoTaiKhoan.Enabled=rib_DanhMuc.Visible = rib_BaoCao.Visible = rib_NghiepVu.Visible = false;
            MANV.Text = "MANV";
            HOTEN.Text = "HOTEN";
            NHOM.Text = "NHOM";
            Program.frmDN.tb_TaiKhoan.Text = Program.frmDN.tb_MatKhau.Text = "";
            btn_DangNhap.Enabled = true;
            Program.frmDN.tb_TaiKhoan.Enabled = Program.frmDN.tb_MatKhau.Enabled = Program.frmDN.cmb_ChiNhanh.Enabled = true;
            
            

        }

        private void btn_VatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(frmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                frmVatTu f = new frmVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_Kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                frmKho f = new frmKho();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
