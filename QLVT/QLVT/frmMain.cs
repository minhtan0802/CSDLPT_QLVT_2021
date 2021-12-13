using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

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
        public void ReFresh()
        {
            Form frm;
            frm = this.CheckExist(typeof(frmNhanVien));
            if (frm != null)
            {
                Program.frmNV.load();
            }
            frm = this.CheckExist(typeof(frmVatTu));
            if(frm!=null)
            {
                Program.frmVT.load();
            }

            frm = this.CheckExist(typeof(frmKho));
            if (frm != null)
            {
            
                Program.frmKHO.load();
            }

            frm = this.CheckExist(typeof(frmDonDatHang));
            if (frm != null)
            {
                Program.frmDDH.load();
            }
            frm = this.CheckExist(typeof(frmPhieuNhap));
            if (frm != null)
            {
                Program.frmPN.load();
            }
            frm = this.CheckExist(typeof(frmPhieuXuat));
            if (frm != null)
            {
                Program.frmPX.load();
            }
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
                Program.frmNV = new frmNhanVien();
                Program.frmNV.MdiParent = this;
                Program.frmNV.Show();
            }
        }

     

    
        private void closeForm(Type ftype)
        {
            Form frm = this.CheckExist(ftype);
            if (frm != null) frm.Close();
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
                for(int i = 0; i < Application.OpenForms.Count; i++)
                    {
                       if(Application.OpenForms[i].Name.Equals("frmThemCTDDH")
                        || Application.OpenForms[i].Name.Equals("frmThemCTPX")|| Application.OpenForms[i].Name.Equals("frmThemCTPN"))
                       {
                            Application.OpenForms[i].Close();
                        }

                    }
                if (Program.CheckOpened("frmTaoTaiKhoan"))
                {
                    Program.frmTaoAcc.Close();
                }
               
            }
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

        private void btn_VatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(frmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmVT = new frmVatTu();
                Program.frmVT.MdiParent = this;
                Program.frmVT.Show();
            }
        }

        private void btn_Kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmKHO = new frmKho();
                Program.frmKHO.MdiParent = this;
                Program.frmKHO.Show();
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
            if (!Program.CheckOpened("frmTaoTaiKhoan"))
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

        private void btn_InBangKeNX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!Program.CheckOpened("frm_ReportHangHoa"))
            {
                frm_ReportHangHoa f = new frm_ReportHangHoa();
                f.Show();
            }    
        }

        private void btn_InDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Program.CheckOpened("frmRptDSNV"))
            {
                frmRptDSNV f = new frmRptDSNV();
                f.Show();
            }
            else return;

        }

        private void btn_InVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xrpt_DSVatTu rpt = new Xrpt_DSVatTu();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(Frpt_HoatDongCuaNhanVienTheoThang));
            if(frm != null)
            {
                frm.Activate();
            }
            else
            {
                Frpt_HoatDongCuaNhanVienTheoThang f = new Frpt_HoatDongCuaNhanVienTheoThang();
                f.MdiParent = this;
                f.Show();
            } 
                
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Xrpt_DonHangChuaCoPhieuNhap rpt = new Xrpt_DonHangChuaCoPhieuNhap();
                
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExist(typeof(Frpt_TongHopNhapXuat));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Frpt_TongHopNhapXuat f = new Frpt_TongHopNhapXuat();
                f.MdiParent = this;
                f.Show();
            }
        }
    }

}
