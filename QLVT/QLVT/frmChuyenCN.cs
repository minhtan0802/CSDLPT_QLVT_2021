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
    public partial class frmChuyenCN : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenCN()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmChuyenCN_Load(object sender, EventArgs e)
        {

            cmb_ChiNhanh.DataSource = Program.bds_dspm_ChuyenCN;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmb_ChiNhanh.DisplayMember = "TENCN";
            cmb_ChiNhanh.ValueMember = "TENSERVER";
            cmb_ChiNhanh.SelectedIndex = Program.mChiNhanh;
        }

        public delegate void getChiNhanh(String index);
        public getChiNhanh getCN;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
           
            if (cmb_ChiNhanh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh cần chuyển", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_ChiNhanh.Focus();
                return;
            }
            else
            {
               
                
                getCN(cmb_ChiNhanh.SelectedValue.ToString());
                this.Close();
                BindingSource bdsCCN = new BindingSource();
                cmb_ChiNhanh.DataSource = bdsCCN;
            }
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiNhanhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
    }
}