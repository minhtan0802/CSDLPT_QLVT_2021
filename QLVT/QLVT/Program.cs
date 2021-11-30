using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLVT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
    //   public static String connstr_publisher = "Data Source=LAPTOP-0GIVQL73;Initial Catalog=QLVT;Integrated Security=True";
     //   public static String connstr_publisher = "Data Source=LAPTOP-LJSAF82J;Initial Catalog=QLVT;Integrated Security=True";
       public static String connstr_publisher = "Data Source=LAPTOP-V0HI7R3V\\SERVER;Initial Catalog=QLVT;Integrated Security=True";
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLVT";
        public static String remoteLogin= "HTKN";
        public static String remotePassword = "123456";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoTen = "";
        public static int mChiNhanh = 0;
        public static String MDDH = "";
     

        public static BindingSource bds_dspm = new BindingSource();//giữ bdsPM khi đăng nhập
        public static BindingSource bds_dspm_TaoTK = new BindingSource();
        public static BindingSource bds_dspm_ChuyenCN = new BindingSource();
        public static BindingSource bds_DSNVChuaCoAcc = new BindingSource();//giữ ds nhân viên chưa có acc
        public static frmMain frmChinh; //khai báo con trỏ, về sau là đối tượng frm Main
        public static frmDangNhap frmDN;
    
        public static frmDonDatHang frmDDH;
        public static frmPhieuNhap frmPN;
        public static int soLuongVatTu = 0;
        public static frmThemCTPN frmCTPN;
        public static frmTaoTaiKhoan frmTaoAcc;
        public static frmPhieuXuat frmPX;
        public static frmVatTu frmVT;
        public static frmNhanVien frmNV;
        public static frmKho frmKHO;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source="+Program.servername+";Initial Catalog="+
                    Program.database+";User ID="+
                    Program.mlogin+";password="+
                    Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối CSDL.\nBạn xem lại tài khoản và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (Exception e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            Program.conn.Close();
            return dt;
        }
    
        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;//10 phut
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                return 0;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Error converting datatype varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở file Excel");
                else MessageBox.Show(e.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Program.conn.Close();
                return 1;

            }
        }
        public static void savePhieu(string loaiPhieu, string maDon,BindingSource bds, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            if (loaiPhieu.Equals("dh"))
            {
                Program.ExecSqlNonQuery("EXEC sp_deleteAllCTDDH '" + maDon + "'");
            }

            String MaPhieu = maDon;

            DataTable dt = new DataTable();
            dt.Columns.Add("MaSoPhieu", typeof(string));
            dt.Columns.Add("MAVT", typeof(string));
            dt.Columns.Add("SOLUONG", typeof(int));
            dt.Columns.Add("DONGIA", typeof(float));

            string[] valueTemp = new string[4];
            int index = 0;
            int soLuong = 0;
            float donGia = 0;
            int rowCount = bds.Count;
       
            for (int rows = 0; rows <rowCount; rows++)
            {

            
                valueTemp[0] = ((DataRowView)bds[rows])["MAVT"].ToString();
              

                soLuong = Int32.Parse(((DataRowView)bds[rows])["SOLUONG"].ToString());
                donGia = float.Parse(((DataRowView)bds[rows])["DONGIA"].ToString());

                dt.Rows.Add(MaPhieu, valueTemp[0], soLuong, donGia);

            }

            SqlParameter para = new SqlParameter();
            SqlParameter para2 = new SqlParameter();
        
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_CTPhieu";

         
            SqlCommand sqlcmd = new SqlCommand();
            para.ParameterName = "@CTPhieu";
            para.Value = dt;

           
            Program.KetNoi();
           sqlcmd = new SqlCommand("sp_updateCTPhieu", Program.conn);
            
           
            sqlcmd.Parameters.Clear();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.Add(para);

            
            sqlcmd.Parameters.Add("type", SqlDbType.NChar).Value = loaiPhieu;
            sqlcmd.ExecuteNonQuery();


        }
        public static bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static string StandardString(string strInput, string type)
        {
            string strResult = "";
             strInput = strInput.Trim().ToLower();
                while (strInput.Contains("  "))
                    strInput = strInput.Replace("  ", " ");
           
                string[] arrResult = strInput.Split(' ');
          
                foreach (string item in arrResult)
            {
                if (type.Equals("name") && item.Length>0)
                {
                    if(item.Length==1)
                    {
                        strResult += item.Substring(0, 1).ToUpper() + " ";
                    }    
                    else
                    {
                        strResult += item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";
                    }    
                    
                } 
                else if(type.Equals(""))
                {
                    strResult += item+" ";
                }
                else if(type.Equals("add"))
                {
                    string temp = "";
                    if (item.Equals(".") || item.Equals(",") || item.Equals(";") || item.Equals("-"))
                    {
                        strResult = strResult.TrimEnd() + item + " ";
                        temp = item;
                    }
                    else if ((temp.Equals(".") && (!item.Equals(".") || !item.Equals(",") || !item.Equals(";") || !item.Equals("-")))&& item.Length>0 )
                    {
                        if(item.Length ==1)
                        {
                            strResult += item.Substring(0, 1).ToUpper() + " ";
                            temp = item;
                        }   
                        else
                        {
                            strResult += item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";
                            temp = item;
                        }    
                        
                    }
                    else if(item.Length > 0)
                    { 
                        if(item.Length == 1)
                        {
                            strResult = strResult + item.Substring(0, 1).ToUpper()  + " ";
                            temp = item;
                        } 
                        else
                        {
                            strResult = strResult + item.Substring(0, 1).ToUpper() + item.Substring(1) + " ";
                            temp = item;
                        }    
                        
                    }

                }    
            }    
            return strResult.TrimEnd();
        }
        
        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDN = new frmDangNhap();
           
        //    frmDN.Show();
          
      
        Application.Run(frmDN);
            
        }
    }
}
