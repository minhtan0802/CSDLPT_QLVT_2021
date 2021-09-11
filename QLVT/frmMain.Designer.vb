<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage_HeThong = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup_HeThong = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.BarButton_DangNhap = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButton_TaoTaiKhoan = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButton_DangXuat = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage_DanhMuc = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup_DanhMuc = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButton_NhanVien = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage_NghiepVu = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButton_LapPhieuNX = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup_BaoCao = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButton_InCacPhieuNV = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageGroup_BaocCao2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButton_PhieuNVLapTrongNam = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.BarButton_DangNhap, Me.BarButton_TaoTaiKhoan, Me.BarButton_DangXuat, Me.BarButton_NhanVien, Me.BarButton_LapPhieuNX, Me.BarButton_InCacPhieuNV, Me.BarButton_PhieuNVLapTrongNam})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 9
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage_HeThong, Me.RibbonPage_DanhMuc, Me.RibbonPage_NghiepVu, Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(1145, 193)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonPage_HeThong
        '
        Me.RibbonPage_HeThong.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup_HeThong})
        Me.RibbonPage_HeThong.Name = "RibbonPage_HeThong"
        Me.RibbonPage_HeThong.Text = "Hệ thống"
        '
        'RibbonPageGroup_HeThong
        '
        Me.RibbonPageGroup_HeThong.ItemLinks.Add(Me.BarButton_DangNhap)
        Me.RibbonPageGroup_HeThong.ItemLinks.Add(Me.BarButton_TaoTaiKhoan)
        Me.RibbonPageGroup_HeThong.ItemLinks.Add(Me.BarButton_DangXuat)
        Me.RibbonPageGroup_HeThong.Name = "RibbonPageGroup_HeThong"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 635)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1145, 30)
        '
        'BarButton_DangNhap
        '
        Me.BarButton_DangNhap.Caption = "Đăng nhập"
        Me.BarButton_DangNhap.Id = 2
        Me.BarButton_DangNhap.Name = "BarButton_DangNhap"
        '
        'BarButton_TaoTaiKhoan
        '
        Me.BarButton_TaoTaiKhoan.Caption = "Tạo tài khoản"
        Me.BarButton_TaoTaiKhoan.Id = 3
        Me.BarButton_TaoTaiKhoan.Name = "BarButton_TaoTaiKhoan"
        '
        'BarButton_DangXuat
        '
        Me.BarButton_DangXuat.Caption = "Đăng xuất"
        Me.BarButton_DangXuat.Id = 4
        Me.BarButton_DangXuat.Name = "BarButton_DangXuat"
        '
        'RibbonPage_DanhMuc
        '
        Me.RibbonPage_DanhMuc.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup_DanhMuc})
        Me.RibbonPage_DanhMuc.Name = "RibbonPage_DanhMuc"
        Me.RibbonPage_DanhMuc.Text = "Danh mục"
        '
        'RibbonPageGroup_DanhMuc
        '
        Me.RibbonPageGroup_DanhMuc.ItemLinks.Add(Me.BarButton_NhanVien)
        Me.RibbonPageGroup_DanhMuc.Name = "RibbonPageGroup_DanhMuc"
        '
        'BarButton_NhanVien
        '
        Me.BarButton_NhanVien.Caption = "Nhân viên"
        Me.BarButton_NhanVien.Id = 5
        Me.BarButton_NhanVien.Name = "BarButton_NhanVien"
        '
        'RibbonPage_NghiepVu
        '
        Me.RibbonPage_NghiepVu.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage_NghiepVu.Name = "RibbonPage_NghiepVu"
        Me.RibbonPage_NghiepVu.Text = "Nghiệp vụ"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButton_LapPhieuNX)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        '
        'BarButton_LapPhieuNX
        '
        Me.BarButton_LapPhieuNX.Caption = "Lập phiếu nhập/ xuất"
        Me.BarButton_LapPhieuNX.Id = 6
        Me.BarButton_LapPhieuNX.Name = "BarButton_LapPhieuNX"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup_BaoCao, Me.RibbonPageGroup_BaocCao2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Báo cáo"
        '
        'RibbonPageGroup_BaoCao
        '
        Me.RibbonPageGroup_BaoCao.ItemLinks.Add(Me.BarButton_InCacPhieuNV)
        Me.RibbonPageGroup_BaoCao.Name = "RibbonPageGroup_BaoCao"
        '
        'BarButton_InCacPhieuNV
        '
        Me.BarButton_InCacPhieuNV.Caption = "In các phiếu của nhân viên"
        Me.BarButton_InCacPhieuNV.Id = 7
        Me.BarButton_InCacPhieuNV.Name = "BarButton_InCacPhieuNV"
        '
        'RibbonPageGroup_BaocCao2
        '
        Me.RibbonPageGroup_BaocCao2.ItemLinks.Add(Me.BarButton_PhieuNVLapTrongNam)
        Me.RibbonPageGroup_BaocCao2.Name = "RibbonPageGroup_BaocCao2"
        '
        'BarButton_PhieuNVLapTrongNam
        '
        Me.BarButton_PhieuNVLapTrongNam.Caption = "Phiếu các NV lâp trong năm"
        Me.BarButton_PhieuNVLapTrongNam.Id = 8
        Me.BarButton_PhieuNVLapTrongNam.Name = "BarButton_PhieuNVLapTrongNam"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 665)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmMain"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Quản lý vật tư"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage_HeThong As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup_HeThong As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarButton_DangNhap As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButton_TaoTaiKhoan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButton_DangXuat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButton_NhanVien As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage_DanhMuc As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup_DanhMuc As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage_NghiepVu As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButton_LapPhieuNX As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButton_InCacPhieuNV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButton_PhieuNVLapTrongNam As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup_BaoCao As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup_BaocCao2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
