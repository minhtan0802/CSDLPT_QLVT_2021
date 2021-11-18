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
    public partial class frmThemCTDDH : DevExpress.XtraEditors.XtraForm
    {
        public class CTDDH {
            string MDDH;
            string MAVT;
            int soLuong;
            float donGia;
            public CTDDH(string MDDH, string MAVT, int soLuong, float donGia)
            {
                this.MDDH = MDDH;
                this.MAVT = MAVT;
                this.soLuong = soLuong;
                this.donGia = donGia;
            }
        }
        DataTable dt = new DataTable();
        public frmThemCTDDH()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void fromThemChiTietDDH_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            /*   this.sp_getVatTuChuaCoTableAdapter.Connection.ConnectionString = Program.connstr;
               dt = Program.ExecSqlDataTable("EXEC sp_getVatTuChuaCo '" + Program.MDDH + "'");
               this.sp_getVatTuChuaCoTableAdapter.Fill(this.DS.sp_getVatTuChuaCo, Program.MDDH);*/
            this.sp_getVTChuaCoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_getVTChuaCoTableAdapter.Fill(this.DS.sp_getVTChuaCo,Program.frmDDH.getDTVTDaCo());
            if(bds_spgetVTChuaCo.Count!=0)
            {
                txt_TenVT.Text = (((DataRowView)bds_spgetVTChuaCo[0])["TENVT"].ToString());
            }    
          
            /* 
              int max = Int32.Parse(((DataRowView)bds_sp_getVatTuChuaCo[0])["SOLUONGTON"].ToString());
              spin_SoLuong.Properties.MaxValue = max;
              if (max == 0)
              {
                  spin_SoLuong.Enabled = false;
                  spin_DonGia.Enabled = false;
                  btn_Them.Enabled = false;

              }
              else
              {
                  spin_SoLuong.Enabled = true;
                  spin_DonGia.Enabled = true;
                  btn_Them.Enabled = true;
              }*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gc_sp_getVatTuChuaCo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (spin_SoLuong.Value==0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "", MessageBoxButtons.OK);
                spin_SoLuong.Focus();
                return;
            }   
            if (spin_DonGia.Value==0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "", MessageBoxButtons.OK);
                spin_SoLuong.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm vật tư này vào chi tiết ĐĐH?", "Xác nhận",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.frmDDH.gc_DatHang.Enabled = false;
                    Program.frmDDH.btnXoa.Enabled = Program.frmDDH.btnThem.Enabled = false;
                    Program.frmDDH.btnGhi.Enabled = true;
                    MessageBox.Show("Thêm vật tư thành công", "", MessageBoxButtons.OK);
                    Program.frmDDH.bds_spgetCTDDH.AddNew();
                    int pos = Program.frmDDH.bds_spgetCTDDH.Position;
                    ((DataRowView)Program.frmDDH.bds_spgetCTDDH[pos])["MAVT"] = txt_MaVT.Text;
                    ((DataRowView)Program.frmDDH.bds_spgetCTDDH[pos])["TENVT"] = txt_TenVT.Text;
                    ((DataRowView)Program.frmDDH.bds_spgetCTDDH[pos])["DONGIA"] = spin_DonGia.Value.ToString();
                    ((DataRowView)Program.frmDDH.bds_spgetCTDDH[pos])["SOLUONG"] = spin_SoLuong.Value.ToString();
                    
                    
                    Program.frmDDH.getDTVTDaCo().Rows.Add(txt_MaVT.Text);
                    
                




                if (Program.frmDDH.bds_spgetCTDDH.Count==Program.soLuongVatTu)
                    {
                        Program.frmDDH.btn_ThemCTDDH.Enabled = false;
                    }
                    else
                    {
                        Program.frmDDH.btn_ThemCTDDH.Enabled = true;
                    }
                    if (Program.frmDDH.bds_spgetCTDDH.Count == 0)
                    {
                        Program.frmDDH.btn_XoaCTDDH.Enabled = false;
                    }
                    else
                    {
                        Program.frmDDH.btn_XoaCTDDH.Enabled = true;
                    }
                 
                }
            this.Close();
            }
        
        private void gc_sp_getVatTuChuaCo_MouseCaptureChanged(object sender, EventArgs e)
        {
            txt_TenVT.Text = (((DataRowView)bds_spgetVTChuaCo[0])["TENVT"].ToString());
            /*  int max = Int32.Parse(gridView_VatTuChuaCo.GetFocusedRowCellValue("SOLUONGTON").ToString());
               spin_SoLuong.Value = 0;
               spin_DonGia.Value = 0;
               spin_SoLuong.Properties.MaxValue = max;
               if (max == 0)
               {
                   spin_SoLuong.Enabled = false;
                   spin_DonGia.Enabled = false;
                   btn_Them.Enabled = false;

               }
               else
               {
                   spin_SoLuong.Enabled = true;
                   spin_DonGia.Enabled = true;
                   btn_Them.Enabled = true;
               }*/
        }
    }
}