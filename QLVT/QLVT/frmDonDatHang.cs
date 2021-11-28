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
 
    public partial class frmDonDatHang : DevExpress.XtraEditors.XtraForm
    {
      
        DataTable dtVTDaCo = new DataTable();
        ErrorProvider errorProviderMDDH = new ErrorProvider();
        ErrorProvider errorProviderNCC = new ErrorProvider();
        ErrorProvider errorProviderMAKHO = new ErrorProvider();
      

        public DataTable getDTVTDaCo()
        {
            return dtVTDaCo;
        }
        string mddh = "";
    
        public frmDonDatHang()
        {
            InitializeComponent();
        }
       
       
        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void load()
        { // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            // TODO: This line of code loads data into the 'DS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);
            
            // TODO: This line of code loads data into the 'DS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);


            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
            dtVTDaCo = new DataTable();
            dtVTDaCo.Columns.Add("MAVT", typeof(string));
      
            if (bdsDatHang.Count>0)
            {
                mddh = txt_MDDH.Text;
                if (bdsPN.Count>0)
                {
                    btn_ThemCTDDH.Enabled = btn_XoaCTDDH.Enabled = false;
                    gridView_getCTDDH.OptionsBehavior.Editable = false;
                }   
                else
                {
                    btn_ThemCTDDH.Enabled = btn_XoaCTDDH.Enabled = true;
                    gridView_getCTDDH.OptionsBehavior.Editable = true;
                }    

            }
            else
            {
               mddh ="";
            }
        
            this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_getCTPhieuTableAdapter.Fill(this.DS.sp_getCTPhieu,mddh,"dh");
           
            if (!txt_MaNV.Text.Equals(Program.username) || bdsPN.Count>0)
            {
                btnXoa.Enabled = false;
                btn_XoaCTDDH.Enabled = btn_ThemCTDDH.Enabled = false;
                txt_NCC.Enabled = false;
                panelCtrl_DatHang.Enabled = false;
                gridView_getCTDDH.OptionsBehavior.Editable = false;
            }
            else
            {
                btnXoa.Enabled = true;
                txt_NCC.Enabled = true;
                gridView_getCTDDH.OptionsBehavior.Editable = true;
               
                for (int i = 0; i < bds_sp_getCTPhieu.Count; i++)
                {
                    dtVTDaCo.Rows.Add(((DataRowView)bds_sp_getCTPhieu[i])["MAVT"]);
                }    
                   
                
                if (bds_sp_getCTPhieu.Count == 0)
                {
                    btn_XoaCTDDH.Enabled = false;
                }
                else
                {
                    btn_XoaCTDDH.Enabled = true;
                }
                if (bds_sp_getCTPhieu.Count == bdsVatTu.Count)
                {
                    btn_ThemCTDDH.Enabled = false;
                }
                else
                {
                    btn_ThemCTDDH.Enabled = true;
                }
                btn_XoaCTDDH.Enabled = txt_NCC.Enabled = true;
                panelCtrl_DatHang.Enabled = true;
            }
          
           

           
        }    
        private void frmDonDatHang_Load(object sender, EventArgs e)
        {




            DS.EnforceConstraints = false;
            load();
           
       //     macn = ((DataRowView)bdsDatHang[0])["MACN"].ToString(); // Lúc đúng lúc sai, tìm cách khác.
            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            panelCtrl_DatHang.Enabled = false;
            cmb_MaKho.Text = cmb_MaKho.SelectedValue.ToString();
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled =  btnRefresh.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled = false;
            }

        }

        private void datHangGridControl_MouseCaptureChanged(object sender, EventArgs e)
        {
          

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!Program.CheckOpened("Thêm chi tiết ĐĐH"))
            {
               frmThemCTDDH f = new frmThemCTDDH();
               f.Show();
            }
            else return;
            //  bds_spgetCTDDH.AddNew();


        }

        private void btn_XoaCTDDH_Click(object sender, EventArgs e)
        {
            Int32 mavt = 0;
           
              
            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này khỏi CTĐĐH?", "Xác nhận",
                   MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                gc_sp_getCTPhieu.Focus();
                gc_DatHang.Enabled = false;
                Program.frmDDH.btnGhi.Enabled = true;
                Program.frmDDH.btnThoat.Enabled = Program.frmDDH.btnXoa.Enabled = Program.frmDDH.btnThem.Enabled = false;
            
                dtVTDaCo.Rows.RemoveAt(bds_sp_getCTPhieu.Position);

               //gridView_getCTDDH.DeleteSelectedRows();
                bds_sp_getCTPhieu.RemoveAt(bds_sp_getCTPhieu.Position);
                
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(DS.Vattu);
                if (bds_sp_getCTPhieu.Count == bdsVatTu.Count)
                {
                    btn_ThemCTDDH.Enabled = false;
                }
                else
                {
                  btn_ThemCTDDH.Enabled = true;
                }
                if (bds_sp_getCTPhieu.Count == 0)
                {
                   btn_XoaCTDDH.Enabled = false;
                }
                else
                {
                    btn_XoaCTDDH.Enabled = true;
                }

                   

                }
             
              
              
            }

        
    
        private void gc_sp_getCTDDH_EditorKeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btn_GhiCTDDH_Click(object sender, EventArgs e)
        {
            
        }

        private void datHangGridControl_Click(object sender, EventArgs e)
        {

        }

        void dataGridView_sp_getCTDDH_KeyDown(object sender, KeyEventArgs e)
        {
           

        }



    
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mAKHOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmb_MaKho.DropDownStyle=ComboBoxStyle.DropDownList;
            bdsDatHang.AddNew();
            gc_DatHang.Enabled = false;
            label_Kho.Text = "Kho:";
            txt_MDDH.Enabled = true;
           
            gridView_getCTDDH.OptionsBehavior.Editable = true;
            cmb_MaKho.SelectedText="";
            cmb_MaKho.SelectedIndex = -1;
            //     cmb_MaKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_MaKho.Enabled = true;
            txt_NCC.Enabled = true;
            dateEdit_NgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_MaNV.Text = Program.username;
            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            mddh = "";
            this.sp_getCTPhieuTableAdapter.Fill(this.DS.sp_getCTPhieu,mddh,"dh");
            dtVTDaCo.Clear();
           
            panelCtrl_DatHang.Enabled = true;
            btn_ThemCTDDH.Enabled = true;
            btn_XoaCTDDH.Enabled = false;
            txt_MDDH.Focus();
        }
        private int saveDDH()
        {
            try
            {
                cmb_MaKho.DropDownStyle = ComboBoxStyle.DropDown;
                cmb_MaKho.Text = cmb_MaKho.SelectedValue.ToString();
                bdsDatHang.EndEdit();
                bdsDatHang.ResetCurrentItem();
    
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Update(this.DS.DatHang);
                mddh = txt_MDDH.Text;
          
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đơn đặt hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                return -1;
            }
        }
        private int saveCTDDH()
        {
            try
            {
             
                Program.savePhieu("dh", mddh, bds_sp_getCTPhieu, gridView_getCTDDH); ;
                this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPhieuTableAdapter.Fill(this.DS.sp_getCTPhieu, mddh,"dh");
                MessageBox.Show("Ghi thành công!", "", MessageBoxButtons.OK);
                panelCtrl_DatHang.Enabled = true;
                return 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi CTĐĐH.\n" + ex.Message, "", MessageBoxButtons.OK);
                return -1;
            }
            
        }    
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!gridView_getCTDDH.PostEditor())
            {
                return;
            }    
      
            bool checkError = true;
            if(!ValidateCombKho(cmb_MaKho))
            {
                cmb_MaKho.Focus();
                checkError = false;
            }
           
            if (!Validate(txt_NCC))
            {
                txt_NCC.Focus();
                checkError = false;
            }
            if (!Validate(txt_MDDH))
            {
                txt_MDDH.Focus();
                checkError = false;
            }
            if(!checkError)
            {
                return;
            }    
           /* if (txt_MDDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đơn đặt hàng không được thiếu", "", MessageBoxButtons.OK);
                txt_MDDH.Focus();
                return;
            }
            if (txt_NCC.Text.Trim() == "")
            {
                MessageBox.Show("Nhà cung cấp không được thiếu", "", MessageBoxButtons.OK);
                txt_NCC.Focus();
                return;
            }
            /*     if (txt_MaKho.Text.Trim().Equals(""))
                 {
                     MessageBox.Show("Mã kho không được thiếu", "", MessageBoxButtons.OK);
                     txt_MaKho.Focus();
                     return;
                 }
            if(cmb_MaKho.Text=="")
            {
                MessageBox.Show("Kho không được thiếu", "", MessageBoxButtons.OK);
                cmb_MaKho.Focus();
                return;
            }
            if(cmb_MaKho.SelectedIndex == -1 && cmb_MaKho.Text !="")
            {
                MessageBox.Show("Kho không có ở chi nhánh này", "", MessageBoxButtons.OK);
                cmb_MaKho.Focus();
                return;
            }*/
            if (txt_MDDH.Enabled==true)
            {
                string strLenh = "EXEC sp_TraCuu '" + txt_MDDH.Text + "'" + ", 'MDDH'";
                int ret = Program.ExecSqlNonQuery(strLenh);
                if (ret == 1)
                {
                    txt_MDDH.Focus();
                    dxErrorProvider1.SetError(txt_MDDH, "Mã đơn đặt hàng đã tồn tại");
                    return;
                }
                else
                {
                    dxErrorProvider1.SetError(txt_MDDH, null);
                }    
             /*   else if (Program.ExecSqlNonQuery("EXEC sp_TraCuu '" + cmb_MaKho.SelectedValue + "'" + ", 'MAKHODDH'") == 1)
                {
                    cmb_MaKho.Focus();
                    return;
                }*/
            }
            if (bds_sp_getCTPhieu.Count==0)
            {
                MessageBox.Show("Chi tiết đơn đặt hàng không được thiếu", "", MessageBoxButtons.OK);
                gridView_getCTDDH.Focus();
                return;
            }
            
          
           
         
            if (saveDDH()==0)
            {
                saveCTDDH();
            }
            label_Kho.Text = "Mã kho:";
                gc_DatHang.Enabled = true;
            cmb_MaKho.Enabled= txt_MaNV.Enabled = txt_MDDH.Enabled = dateEdit_NgayLap.Enabled = txt_MDDH.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            
                btnGhi.Enabled = btnUndo.Enabled = false;
                groupBox_CTDDH.Enabled = true;
             
         

           
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


       

        private void dataGridView_sp_getCTDDH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
        }

        private void dataGridView_sp_getCTDDH_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
          /*  e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (gc_sp_getVatTuChuaCo..ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                    
                }
            }*/
        }

        private void dataGridView_sp_getCTDDH_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
          
        }

        private void dataGridView_sp_getCTDDH_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
         /*   if (e.ColumnIndex == 3)
            {
                string MAVT = dataGridView_sp_getCTDDH.Rows[row].Cells["MAVT"].Value.ToString();
                //   int soLuong = Int32.Parse(dataGridView_sp_getCTDDH.Rows[row].Cells[column].Value.ToString());
                int soLuong = 10;

                int ret = Program.ExecSqlNonQuery("Exec sp_kiemTraSLT '" + MAVT + "', " + soLuong);
                DataGridView dgv = (DataGridView)sender;
                DataGridViewTextBoxCell textboxCell = dgv.CurrentCell as DataGridViewTextBoxCell;
                if (ret == -1)
                {
                   // dataGridView_sp_getCTDDH.Focus();
                    //dataGridView_sp_getCTDDH.CurrentCell = dataGridView_sp_getCTDDH.Rows[row].Cells["SOLUONG"];
                    //dataGridView_sp_getCTDDH.CurrentCell.Selected = true;
                    //dataGridView_sp_getCTDDH.BeginEdit(true);
                    if (textboxCell != null)
                    {
                        dgv.BeginEdit(true);
                        dgv.Focus();
                     //   int col = e.ColumnIndex;
                        dgv.CurrentCell = dgv[row,column];
                    }
                }

            }*/
        }

        private void dataGridView_sp_getCTDDH_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_sp_getCTDDH_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        private void dataGridView_sp_getCTDDH_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
             
        }

        private void dataGridView_sp_getCTDDH_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
              
        }

        private void dataGridView_sp_getCTDDH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
                
           
        }

        private void dataGridView_sp_getCTDDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           /* try
            {
                this.sp_getVatTuChuaCoTableAdapter.Fill(this.DS.sp_getVatTuChuaCo, mDDHToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void gridView_sp_getVTChuaCo_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            string maVT = gridView_getCTDDH.GetRowCellValue(gridView_getCTDDH.FocusedRowHandle, "colMAVT").ToString();
            int soLuong = Int32.Parse(gridView_getCTDDH.GetRowCellValue(gridView_getCTDDH.FocusedRowHandle,"colSOLUONG").ToString());
            int ret = Program.ExecSqlNonQuery("Exec sp_kiemTraSLT '" + maVT + "', " + soLuong);
            if (Int32.Parse(e.Value as String)>soLuong)
            {
                e.Valid = false;
                e.ErrorText = "Lỗi nè";
            }
        }

        private void gridView_getCTDDH_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG" || gridView_getCTDDH.FocusedColumn.FieldName == "DONGIA")
            {
                int rows = gridView_getCTDDH.FocusedRowHandle;
                int number = 0;
                String soLuongString = e.Value as string;
                if (soLuongString.Equals(""))
                {
                    e.Valid = false;
                    e.ErrorText = "Không được để trống";
                }
                else if (!Int32.TryParse(soLuongString, out number))
                {
                    e.Valid = false;
                    e.ErrorText = "Vui lòng nhập số";
                }
                else if (Int32.Parse(soLuongString)==0 && gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG")
                {
                    e.Valid = false;
                    e.ErrorText = "Số lượng phải phải lớn hơn 0";
                }    
                
                 //   int soLuong = Int32.Parse(soLuongString);
               //     int soLuongCoTrongDT = Int32.Parse(dtCTDDH.Rows[rows].Field<int>(3).ToString());
                 //   maVT = gridView_getCTDDH.GetRowCellValue(gridView_getCTDDH.FocusedRowHandle, "MAVT").ToString();
                    // maVT = ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MAVT"].ToString();

           /*         Program.KetNoi();
                    DataTable dt = new DataTable();
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select SOLUONGTON from Vattu as VT where VT.MAVT ='" + maVT + "'", Program.conn);
                    da.Fill(dt);
                    MessageBox.Show("So luong: " + soLuong + " Số lượng DT: " + soLuongCoTrongDT + " Ma VT: " + maVT);
                    soLuongTon = Int32.Parse(dt.Rows[0][0].ToString());
                    if (soLuong > soLuongTon + soLuongCoTrongDT)
                    {
                        // DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e2= new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs(sender);
                        //gridView_getCTDDH_ValidatingEditor(sender, e2);
                        e.Valid = false;
                        e.ErrorText = "Số lượng không hợp lệ";

                        //    MessageBox.Show("Số lượng không hợp lệ");

                        //   gridView_getCTDDH.SetColumnError(gridView_getCTDDH.Columns["SOLUONGTON"], "Số lượng nhập lớn hơn số lượng tồn", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);


                        //e2.Valid = false;

                    }
                    else
                    {
                        int soLuongDu = soLuongCoTrongDT - soLuong;
                        int viTri = this.vattuBindingSource.Find("MAVT", maVT);
                     //   MessageBox.Show("Ma VT: " + maVT + " Vi tri: " + viTri);
                     //   int slt = this.DS.Vattu.Rows[viTri].Field<int>(3) + soLuongDu;
                        this.DS.Vattu.Rows[viTri].SetField("SOLUONGTON", slt);
                        DS.EnforceConstraints = false;
                        // TODO: This line of code loads data into the 'DS.VatTu' table. You can move, or remove it, as needed.
                        this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.vattuTableAdapter.Update(this.DS.Vattu);

                    }
                    Program.conn.Close();
                    // ret = Program.ExecSqlNonQuery("Exec sp_kiemTraSLT '" + maVT + "'," + soLuong);*/
                

            }


        }


        private void gridView_getCTDDH_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
          /*  maVT = gridView_getCTDDH.GetRowCellValue(gridView_getCTDDH.FocusedRowHandle, "MAVT").ToString();
            int soLuong = Int32.Parse(gridView_getCTDDH.GetRowCellValue(gridView_getCTDDH.FocusedRowHandle, "SOLUONG").ToString());
            Program.KetNoi();
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select SOLUONGTON from Vattu as VT where VT.MAVT ='" + maVT + "'", Program.conn);
            da.Fill(dt);
            MessageBox.Show("So luong: " + soLuong);
            soLuongTon = Int32.Parse(dt.Rows[0][0].ToString());
            if (soLuong > soLuongTon)
            {
                // DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e2= new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs(sender);
                //gridView_getCTDDH_ValidatingEditor(sender, e2);
              
                //    MessageBox.Show("Số lượng không hợp lệ");

                gridView_getCTDDH.SetColumnError(gridView_getCTDDH.Columns["SOLUONGTON"], "Số lượng nhập lớn hơn số lượng tồn", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User1);

          //      gridView_getCTDDH.SetColumnError(gridView_getCTDDH.Columns["SOLUONGTON"], "Số lượng nhập lớn hơn số lượng tồn", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                //e2.Valid = false;

            }
            Program.conn.Close();
            // ret = Program.ExecSqlNonQuery("Exec sp_kiemTraSLT '" + maVT + "'," + soLuong);
            */
        }
        private void gridView_getCTDDH_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG" || gridView_getCTDDH.FocusedColumn.FieldName == "DONGIA")
            {

                gc_DatHang.Enabled = false;
                panelCtrl_DatHang.Enabled = false;
                Program.frmDDH.btnGhi.Enabled = Program.frmDDH.btnThoat.Enabled = Program.frmDDH.btnXoa.Enabled = Program.frmDDH.btnThem.Enabled = false;


            }
        }

        private void gridView_getCTDDH_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
             
        }

        private void gridView_getCTDDH_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {

           /* maVT = gridView_getCTDDH.GetRowCellValue(gridView_getCTDDH.FocusedRowHandle, "MAVT").ToString();
           
            Program.KetNoi();
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select SOLUONGTON from Vattu as VT where VT.MAVT ='" + maVT + "'", Program.conn);
            da.Fill(dt);
            MessageBox.Show("So luong: " + soLuong);
            soLuongTon = Int32.Parse(dt.Rows[0][0].ToString());
            if (soLuong > soLuongTon)
            {
                // DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e2= new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs(sender);
                //gridView_getCTDDH_ValidatingEditor(sender, e2);
              
                e.ErrorText = "Số lượng không hợp lệ";
                //    MessageBox.Show("Số lượng không hợp lệ");

             //   gridView_getCTDDH.SetColumnError(gridView_getCTDDH.Columns["SOLUONGTON"], "Số lượng nhập lớn hơn số lượng tồn", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);


                //e2.Valid = false;

            }
            Program.conn.Close();
            // ret = Program.ExecSqlNonQuery("Exec sp_kiemTraSLT '" + maVT + "'," + soLuong);
            */
        }

        private void gridView_getCTDDH_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void gridView_getCTDDH_EditFormShowing(object sender, DevExpress.XtraGrid.Views.Grid.EditFormShowingEventArgs e)
        {
          
        }

        private void gridView_getCTDDH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }    
            
        }

        private void gc_sp_getCTDDH_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            if (gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG" || gridView_getCTDDH.FocusedColumn.FieldName =="DONGIA")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void txt_NCC_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            btnGhi.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maddh = "";
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa đơn đặt hàng vì đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa đơn đặt hàng vì có chi tiết đơn đặt hàng", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này?", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        maddh = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MaSoDDH"].ToString();
                        bdsDatHang.RemoveCurrent();//Xóa trên máy hiện tại trước
                        this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.datHangTableAdapter.Update(this.DS.DatHang);//Xóa trên CSDL
                        mddh = txt_MDDH.Text;
                        this.sp_getCTPhieuTableAdapter.Fill(this.DS.sp_getCTPhieu, mddh,"dh");
                        MessageBox.Show("Xoá đơn đặt hàng thành công", "", MessageBoxButtons.OK);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa vật tư. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                        this.datHangTableAdapter.Fill(this.DS.DatHang);
                        bdsDatHang.Position = bdsDatHang.Find("MaSoDDH", maddh);
                        this.sp_getCTPhieuTableAdapter.Fill(this.DS.sp_getCTPhieu, maddh, "dh");

                        return;
                    }
                }
            } 
                
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                load();
              /*  this.datHangTableAdapter.Fill(this.DS.DatHang);
                Program.MDDH = txt_MDDH.Text;
                this.sp_getCTDDHTableAdapter.Fill(this.DS.sp_getCTDDH, Program.MDDH);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
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
                load();
            }
        }

        private void panelCtrl_DatHang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
         

        }

        private void dataGridView_sp_getCTDDH_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void gridView_getCTDDH_ValidatingEditor_1(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG" || gridView_getCTDDH.FocusedColumn.FieldName == "DONGIA")
            {
                int rows = gridView_getCTDDH.FocusedRowHandle;
                int number = 0;
                String soLuongString = e.Value as string;
                if (soLuongString.Equals(""))
                {
                    e.Valid = false;
                    e.ErrorText = "Không được để trống";
                }
                else if (!Int32.TryParse(soLuongString, out number))
                {
                    e.Valid = false;
                    e.ErrorText = "Vui lòng nhập số";
                }
                else if (Int32.Parse(soLuongString) == 0 && gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG")
                {
                    e.Valid = false;
                    e.ErrorText = "Số lượng phải phải lớn hơn 0";
                }
                else if (Int32.Parse(soLuongString) == 0 && gridView_getCTDDH.FocusedColumn.FieldName == "DONGIA")
                {
                    e.Valid = false;
                    e.ErrorText = "Đơn giá phải phải lớn hơn 0";
                }

            }
        }

        private void gridView_getCTDDH_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG" || gridView_getCTDDH.FocusedColumn.FieldName == "DONGIA")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void gridView_DatHang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gc_sp_getCTPhieu_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            if (gridView_getCTDDH.FocusedColumn.FieldName == "SOLUONG" || gridView_getCTDDH.FocusedColumn.FieldName == "DONGIA")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void gc_DatHang_Move(object sender, EventArgs e)
        {
        
        }

        private void gc_DatHang_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void gridView_DatHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        
                mddh = txt_MDDH.Text;
                if(btnThem.Enabled==true)
            {
                this.sp_getCTPhieuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_getCTPhieuTableAdapter.Fill(this.DS.sp_getCTPhieu, mddh, "dh");
                dtVTDaCo.Clear();
                if (!txt_MaNV.Text.Equals(Program.username) || bdsPN.Count > 0)
                {
                    btnXoa.Enabled = false;
                    btn_XoaCTDDH.Enabled = btn_ThemCTDDH.Enabled = false;
                    txt_NCC.Enabled = false;
                    panelCtrl_DatHang.Enabled = false;
                    gridView_getCTDDH.OptionsBehavior.Editable = false;
                }
                else
                {
                    gridView_getCTDDH.OptionsBehavior.Editable = true;
                    btnXoa.Enabled = true;
                    txt_NCC.Enabled = true;

                    for (int i = 0; i < bds_sp_getCTPhieu.Count; i++)
                    {
                        dtVTDaCo.Rows.Add(((DataRowView)bds_sp_getCTPhieu[i])["MAVT"]);
                    }
                    if (bds_sp_getCTPhieu.Count == 0)
                    {
                        btn_XoaCTDDH.Enabled = false;
                    }
                    else
                    {
                        btn_XoaCTDDH.Enabled = true;
                    }

                    if (bds_sp_getCTPhieu.Count == bdsVatTu.Count)
                    {
                        btn_ThemCTDDH.Enabled = false;
                    }
                    else
                    {
                        btn_ThemCTDDH.Enabled = true;
                    }

                    panelCtrl_DatHang.Enabled = true;
                }

            }    
               
             
            
        }

        private void txt_MDDH_Validating(object sender, CancelEventArgs e)
        {
            if(!Validate(txt_MDDH))
            {
                e.Cancel = true;
            }    
            else
            {
                e.Cancel = false;
            }    
        }
        private bool Validate(DevExpress.XtraEditors.TextEdit txt)
        {
            bool bStatus = true;       
            if (txt.Name == "txt_MDDH")
            {
                if (txt.Text.Trim() == "")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập mã đơn đặt hàng");
                    bStatus = false;
                }
                else if (txt.Text.Length > 8)
                {
                    dxErrorProvider1.SetError(txt, "Mã đơn đặt hàng chỉ chứa tối đa 8 ký tự");
                    bStatus = false;
                }
                else
                    dxErrorProvider1.SetError(txt, null);
            }
            else if (txt.Name == "txt_NCC")
            {
                if (txt.Text.Trim() == "")
                {
                    dxErrorProvider1.SetError(txt, "Vui lòng nhập nhà cung cấp");
                    bStatus = false;

                }
                else if (Program.StandardString(txt.Text, "name").Length > 40)
                {
                    dxErrorProvider1.SetError(txt, "Tên nhà cung cấp chỉ chứa tối đa 100 ký tự");
                    bStatus = false;
                }
                else
                {
                    dxErrorProvider1.SetError(txt, null);
                }
            } 
            return bStatus;
        }

        private void txt_NCC_Validating(object sender, CancelEventArgs e)
        {
             if(!Validate(txt_NCC))
              {
                  e.Cancel = true;
              }    
              else
              {
                  e.Cancel = false;
              }   
           
        }

        private bool ValidateCombKho(System.Windows.Forms.ComboBox txt)
        {
            bool bStatus = true;
            
                if (txt.SelectedIndex ==-1)
                {
                    errorProviderMAKHO.SetError(txt, "Vui lòng chọn kho");
                    bStatus = false;
                }
                else
                {
                    errorProviderMAKHO.SetError(txt, "");
                }
         
            return bStatus;
        }

        private void cmb_MaKho_Validating(object sender, CancelEventArgs e)
        {
            if(!ValidateCombKho(cmb_MaKho))
            {
                e.Cancel = true;
            }    
            else
            {
                e.Cancel = false;
            }    
        }

        private void mAKHOComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_MDDH_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_NCC_KeyPress(object sender, KeyPressEventArgs e)
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
    }

        
    }