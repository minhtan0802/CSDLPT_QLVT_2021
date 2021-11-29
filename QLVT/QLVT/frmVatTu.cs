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
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class frmVatTu : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string tenVTCu = "";
        string tenVTMoi = "";
        ErrorProvider errorProviderTENVT = new ErrorProvider();
        ErrorProvider errorProviderDVT = new ErrorProvider();
        ErrorProvider errorProviderMAVT = new ErrorProvider();
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in this.DS.Vattu)
            {
                Program.soLuongVatTu++;
            }
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.VatTu' table. You can move, or remove it, as needed.
            this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VatTuTableAdapter.Fill(this.DS.Vattu);
         
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
            // TODO: This line of code loads data into the 'DS.CTPN' table. You can move, or remove it, as needed.
            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);
            // TODO: This line of code loads data into the 'DS.CTPX' table. You can move, or remove it, as needed.
            this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPXTableAdapter.Fill(this.DS.CTPX);
            panelCtrl_VatTu.Enabled = false;
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled = false;
            }
         

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_MaVatTu.Enabled = true;
            vitri = bdsVatTu.Position;
            panelCtrl_VatTu.Enabled = true;
            bdsVatTu.AddNew();
            ((DataRowView)bdsVatTu[bdsVatTu.Position])["SOLUONGTON"] = 0;
       
            gridView_VatTu.Columns[0].OptionsColumn.AllowEdit=true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcVatTu.Enabled = false;
         

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVatTu.CancelEdit();
            if (btnThem.Enabled == false) bdsVatTu.Position = vitri;
            dxErrorProvider1.SetError(txt_DonViTinh, null);
            dxErrorProvider1.SetError(txt_MaVatTu, null);
            dxErrorProvider1.SetError(txt_TenVatTu, null);
            gcVatTu.Enabled = true;
            panelCtrl_VatTu.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVatTu.Position;
            panelCtrl_VatTu.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcVatTu.Enabled = false;
            tenVTCu = txt_TenVatTu.Text;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.VatTuTableAdapter.Fill(this.DS.Vattu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mavt = "";
            if (bdsCTDDH.Count>0)
            {
                MessageBox.Show("Không thể xóa vật tư vì đã lập đơn đặt hàng", "", MessageBoxButtons.OK);
                return;
            }    
            if (bdsCTPN.Count>0)
            {
                MessageBox.Show("Không thể xóa vật tư vì đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            } 
            if (bdsCTPX.Count>0)
            {
                {
                    MessageBox.Show("Không thể xóa vật tư vì đã lập phiếu xuất", "", MessageBoxButtons.OK);
                    return;
                }
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này?", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mavt = ((DataRowView)bdsVatTu[bdsVatTu.Position])["MAVT"].ToString();
                    bdsVatTu.RemoveCurrent();//Xóa trên máy hiện tại trước
                    this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.VatTuTableAdapter.Update(this.DS.Vattu);//Xóa trên CSDL
                    foreach (DataRow row in this.DS.Vattu)
                    {
                        Program.soLuongVatTu++;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư. Bạn hãy xóa lại\n"+ex.Message,"",MessageBoxButtons.OK);
                    this.VatTuTableAdapter.Fill(this.DS.Vattu);
                    bdsVatTu.Position = bdsVatTu.Find("MAVT", mavt);
                    return;
                }
            }
            if (bdsVatTu.Count == 0) btnXoa.Enabled = false;
                
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            bool checkError = true;
            if(!Validate(txt_DonViTinh))
            {
                txt_DonViTinh.Focus();
                checkError = false;
            }
            if (!Validate(txt_TenVatTu))
            {
                txt_TenVatTu.Focus();
                checkError = false;
            }
            if (!Validate(txt_MaVatTu))
            {
                txt_MaVatTu.Focus();
                checkError = false;
            }
            if(!checkError)
            {
                return;
            }  
            /*
            if (txt_MaVatTu.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được thiếu", "", MessageBoxButtons.OK);
                txt_MaVatTu.Focus();
                return;
            }
            if (txt_TenVatTu.Text.Trim() == "")
            {
                MessageBox.Show("Tên vật tư không được thiếu", "", MessageBoxButtons.OK);
                txt_TenVatTu.Focus();
                return;
            }
            if (txt_DonViTinh.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được thiếu", "", MessageBoxButtons.OK);
                txt_DonViTinh.Focus();

                return;
            }*/
            string strLenhMAVT = "EXEC sp_TraCuu @code='"+ txt_MaVatTu.Text+ "'" + ", @type='MAVT'";
            string strLenhTENVT = "EXEC sp_TraCuu @code=N'" + Program.StandardString(txt_TenVatTu.Text,"name") + "'" + ", @type='TENVT'";

            int kiemTraMaVT = 0;
            int kiemTraTenVT = 0;
            if (txt_MaVatTu.Enabled == true)
            {
               kiemTraMaVT = Program.ExecSqlNonQuery(strLenhMAVT);
                if(kiemTraMaVT==1)
                {
                    txt_MaVatTu.Focus();
                    dxErrorProvider1.SetError(txt_MaVatTu, "Mã vật tư đã tồn tại");
                    return;
                }
                else
                {
                    dxErrorProvider1.SetError(txt_MaVatTu, "");
                } 
                    
            }

            if(txt_MaVatTu.Enabled==true)
            {
                kiemTraTenVT = Program.ExecSqlNonQuery(strLenhTENVT);
                if (kiemTraTenVT==1)
                {
                    txt_TenVatTu.Focus();
                    dxErrorProvider1.SetError(txt_TenVatTu, "Tên vật tư đã tồn tại");
                    return;
                }
                else
                {
                    dxErrorProvider1.SetError(txt_TenVatTu, "");
                } 
                    
            }
        
            if (txt_MaVatTu.Enabled == false && !tenVTCu.ToLower().Equals(Program.StandardString(txt_TenVatTu.Text, "name").ToLower()))
            {
                kiemTraTenVT = Program.ExecSqlNonQuery(strLenhTENVT);
                if (kiemTraTenVT == 1)
                {
                    txt_TenVatTu.Focus();
                    dxErrorProvider1.SetError(txt_TenVatTu, "Tên vật tư đã tồn tại");
                    return;
                }
            }    
          
                try
                {
                    txt_TenVatTu.Text = Program.StandardString(txt_TenVatTu.Text, "name");
                    txt_DonViTinh.Text= Program.StandardString(txt_DonViTinh.Text, "name");
                    bdsVatTu.EndEdit();
                    bdsVatTu.ResetCurrentItem();
                    this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.VatTuTableAdapter.Update(this.DS.Vattu);
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi vật tư.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                txt_MaVatTu.Enabled = false;
                gcVatTu.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled = false;
                gridView_VatTu.Columns[0].OptionsColumn.AllowEdit =false;
                panelCtrl_VatTu.Enabled = false;
           
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xrpt_DSVatTu rpt = new Xrpt_DSVatTu();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void gridView_VatTu_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView_VatTu.FocusedColumn.FieldName == "MAVT")
            {
                string maVTTemp = e.Value as string;
                if (maVTTemp.Trim().Length > 4)
                {
                    e.Valid = false;
                    e.ErrorText = "Mã vật tư chỉ được tối đa 4 ký tự";
                }
            }
            else if (gridView_VatTu.FocusedColumn.FieldName == "TENVT")
            {
                string tenVTTemp = e.Value as string;
                if (tenVTTemp.Trim().Length > 30)
                {
                    e.Valid = false;
                    e.ErrorText = "Tên vật tư chỉ được tối đa 30 ký tự";
                }
            }
            else if (gridView_VatTu.FocusedColumn.FieldName == "DVT")
            {
                string DVTTemp = e.Value as string;
                if (DVTTemp.Trim().Length > 15)
                {
                    e.Valid = false;
                    e.ErrorText = "Đơn vị tính chỉ được tối đa 15 ký tự";
                }
            }
        }

        private void gcVatTu_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            if (gridView_VatTu.FocusedColumn.FieldName.Equals("MAVT"))
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

        private void gridView_VatTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        
        }

        private void gridView_VatTu_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void tb_MaVatTu_Validating(object sender, CancelEventArgs e)
        {
        }
        private bool Validate(DevExpress.XtraEditors.TextEdit txt)
        {
            bool bStatus = true;
            if (txt.Name == "txt_MaVatTu")
            {
                if (txt.Text.Trim() == "")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập mã vật tư");
                    
                    bStatus = false;
                }
                else if (txt.Text.Trim().Length > 4)
                {
                    dxErrorProvider1.SetError(txt, "Mã vật tư chỉ chứa tối đa 4 ký tự");
                    bStatus = false;
                }
                else
                    dxErrorProvider1.SetError(txt, "");
            }
            else if (txt.Name == "txt_TenVatTu")
            {
                if (txt.Text.Trim() == "")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập tên vật tư");
                    bStatus = false;

                }
                else if (Program.StandardString(txt.Text, "name").Length > 30)
                {
                    dxErrorProvider1.SetError(txt, "Tên vật tư chỉ chứa tối đa 30 ký tự");
                    bStatus = false;
                }
                else
                {
                    dxErrorProvider1.SetError(txt, "");
                }
            }
            else if (txt.Name == "txt_DonViTinh")
            {
                if (txt.Text.Trim() == "")
                {
                   dxErrorProvider1.SetError(txt, "Vui lòng nhập đơn vị tính");
                    bStatus = false;

                }
                else if (Program.StandardString(txt.Text, "add").Length > 15)
                {
                    dxErrorProvider1.SetError(txt, "Đơn vị tính chỉ chứa tối đa 15 ký tự");
                    bStatus = false;
                }
                else
                {
                    dxErrorProvider1.SetError(txt, "");
                }
            }





            return bStatus;
        }

        private void txt_TenVatTu_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txt_DonViTinh_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txt_MaVatTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_MaVatTu_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void tENVTTextEdit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_DonViTinh_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_MaVatTu_Validating(object sender, CancelEventArgs e)
        {

            Validate(txt_MaVatTu);
           
        }

        private void txt_DonViTinh_Validating_1(object sender, CancelEventArgs e)
        {
            Validate(txt_DonViTinh);
           
        }

        private void txt_TenVatTu_Validating_1(object sender, CancelEventArgs e)
        {
            Validate(txt_TenVatTu);
            
            
        }
    }
}