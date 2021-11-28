﻿using System;
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
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
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

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;

            }
            else
            {
                Form frm = this.CheckExist(typeof(frmKho));
                if (frm != null) frm.Close();
                frm = this.CheckExist(typeof(frmNhanVien));
                if (frm != null) frm.Close();
                frm = this.CheckExist(typeof(frmVatTu));
                if (frm != null) frm.Close();
                frm = this.CheckExist(typeof(frmTaoTaiKhoan));
                if (frm != null) frm.Close();
                frm = this.CheckExist(typeof(frmDonDatHang));
                if (frm != null) frm.Close();
                btn_DangXuat.Enabled = btn_TaoTaiKhoan.Enabled = rib_DanhMuc.Visible = rib_BaoCao.Visible = rib_NghiepVu.Visible = false;
                MANV.Text = "MANV";
                HOTEN.Text = "HOTEN";
                NHOM.Text = "NHOM";
                Program.frmDN.tb_TaiKhoan.Text = Program.frmDN.tb_MatKhau.Text = "";
                btn_DangNhap.Enabled = true;
                Program.frmDN.btn_DangNhap.Enabled = true;
                Program.frmDN.tb_TaiKhoan.Enabled = Program.frmDN.tb_MatKhau.Enabled = Program.frmDN.cmb_ChiNhanh.Enabled = true;
                Program.frmChinh.Hide();
                Program.frmDN.Show();

            }



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

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_TaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*  Form frm = this.CheckExist(typeof(frmTaoTaiKhoan));
              if (frm != null) frm.Activate();
              else
              {
                  Program.frmTaoAcc = new frmTaoTaiKhoan();
                  Program.frmTaoAcc.MdiParent = this;
                  Program.frmTaoAcc.Dock = DockStyle.Fill;



                  Program.frmTaoAcc.Show();
                  if (Program.frmTaoAcc.get_bds_ChiNhanhTTK().Rows.Count == 0)
                  {
                      MessageBox.Show("Tất cả nhân viên ở chi nhánh này đã có tài khoản", "", MessageBoxButtons.OK);
                  }
              }*/
            if (!Program.CheckOpened("Tạo tài khoản"))
            {
                Program.frmTaoAcc = new frmTaoTaiKhoan();
                Program.frmTaoAcc.Show();
                if (Program.frmTaoAcc.get_bds_ChiNhanhTTK().Rows.Count == 0)
                {
                    MessageBox.Show("Tất cả nhân viên ở chi nhánh này đã có tài khoản", "", MessageBoxButtons.OK);
                }
            }
            else return;


        }

        private void btn_LapDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(frmDonDatHang));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmDDH = new frmDonDatHang();
                Program.frmDDH.MdiParent = this;
                Program.frmDDH.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(Test));
            if (frm != null) frm.Activate();
            else
            {
                Test f = new Test();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_LapPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExist(typeof(frmPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmPN = new frmPhieuNhap();
                Program.frmPN.MdiParent = this;
                Program.frmPN.Show();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        
            Program.frmDN.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(frmPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmPX = new frmPhieuXuat();
                Program.frmPX.MdiParent = this;
                Program.frmPX.Show();
            }
        }
    }
}
