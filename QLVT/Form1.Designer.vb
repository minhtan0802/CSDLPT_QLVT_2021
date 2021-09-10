<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.skinRibbonGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.barSubItemNavigation = New DevExpress.XtraBars.BarSubItem()
        Me.employeesBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.customersBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroupNavigation = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.officeNavigationBar = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
        Me.navBarControl = New DevExpress.XtraNavBar.NavBarControl()
        Me.employeesNavBarGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.customersNavBarGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.navigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.employeesNavigationPage = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.employeesLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.customersNavigationPage = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.customersLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.SkinDropDownButtonItem = New DevExpress.XtraBars.SkinDropDownButtonItem()
        Me.SkinPaletteRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.officeNavigationBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navigationFrame.SuspendLayout()
        Me.employeesNavigationPage.SuspendLayout()
        Me.customersNavigationPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.skinRibbonGalleryBarItem, Me.barSubItemNavigation, Me.employeesBarButtonItem, Me.customersBarButtonItem, Me.ribbonControl.SearchEditItem, Me.SkinDropDownButtonItem, Me.SkinPaletteRibbonGalleryBarItem1})
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 46
        Me.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl.Size = New System.Drawing.Size(790, 143)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'skinRibbonGalleryBarItem
        '
        Me.skinRibbonGalleryBarItem.Id = 14
        Me.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem"
        '
        'barSubItemNavigation
        '
        Me.barSubItemNavigation.Caption = "Navigation"
        Me.barSubItemNavigation.Id = 15
        Me.barSubItemNavigation.ImageUri.Uri = "NavigationBar"
        Me.barSubItemNavigation.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.employeesBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.customersBarButtonItem)})
        Me.barSubItemNavigation.Name = "barSubItemNavigation"
        '
        'employeesBarButtonItem
        '
        Me.employeesBarButtonItem.Caption = "Employees"
        Me.employeesBarButtonItem.Id = 44
        Me.employeesBarButtonItem.Name = "employeesBarButtonItem"
        '
        'customersBarButtonItem
        '
        Me.customersBarButtonItem.Caption = "Customers"
        Me.customersBarButtonItem.Id = 45
        Me.customersBarButtonItem.Name = "customersBarButtonItem"
        '
        'ribbonPage
        '
        Me.ribbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroupNavigation, Me.ribbonPageGroup})
        Me.ribbonPage.Name = "ribbonPage"
        Me.ribbonPage.Text = "View"
        '
        'ribbonPageGroupNavigation
        '
        Me.ribbonPageGroupNavigation.ItemLinks.Add(Me.barSubItemNavigation)
        Me.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation"
        Me.ribbonPageGroupNavigation.Text = "Module"
        '
        'ribbonPageGroup
        '
        Me.ribbonPageGroup.AllowTextClipping = False
        Me.ribbonPageGroup.ItemLinks.Add(Me.SkinDropDownButtonItem)
        Me.ribbonPageGroup.ItemLinks.Add(Me.SkinPaletteRibbonGalleryBarItem1)
        Me.ribbonPageGroup.Name = "ribbonPageGroup"
        Me.ribbonPageGroup.ShowCaptionButton = False
        Me.ribbonPageGroup.Text = "Appearance"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 568)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(790, 31)
        '
        'officeNavigationBar
        '
        Me.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.officeNavigationBar.Location = New System.Drawing.Point(0, 523)
        Me.officeNavigationBar.Name = "officeNavigationBar"
        Me.officeNavigationBar.NavigationClient = Me.navBarControl
        Me.officeNavigationBar.Size = New System.Drawing.Size(790, 45)
        Me.officeNavigationBar.TabIndex = 1
        Me.officeNavigationBar.Text = "officeNavigationBar"
        '
        'navBarControl
        '
        Me.navBarControl.ActiveGroup = Me.employeesNavBarGroup
        Me.navBarControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.navBarControl.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.employeesNavBarGroup, Me.customersNavBarGroup})
        Me.navBarControl.Location = New System.Drawing.Point(0, 143)
        Me.navBarControl.Name = "navBarControl"
        Me.navBarControl.OptionsNavPane.ExpandedWidth = 165
        Me.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.navBarControl.Size = New System.Drawing.Size(165, 380)
        Me.navBarControl.TabIndex = 0
        Me.navBarControl.Text = "navBarControl"
        '
        'employeesNavBarGroup
        '
        Me.employeesNavBarGroup.Caption = "Employees"
        Me.employeesNavBarGroup.Expanded = True
        Me.employeesNavBarGroup.Name = "employeesNavBarGroup"
        '
        'customersNavBarGroup
        '
        Me.customersNavBarGroup.Caption = "Customers"
        Me.customersNavBarGroup.Name = "customersNavBarGroup"
        '
        'navigationFrame
        '
        Me.navigationFrame.Appearance.BackColor = System.Drawing.Color.White
        Me.navigationFrame.Appearance.Options.UseBackColor = True
        Me.navigationFrame.Controls.Add(Me.employeesNavigationPage)
        Me.navigationFrame.Controls.Add(Me.customersNavigationPage)
        Me.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navigationFrame.Location = New System.Drawing.Point(165, 143)
        Me.navigationFrame.Name = "navigationFrame"
        Me.navigationFrame.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.employeesNavigationPage, Me.customersNavigationPage})
        Me.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always
        Me.navigationFrame.SelectedPage = Me.employeesNavigationPage
        Me.navigationFrame.Size = New System.Drawing.Size(625, 380)
        Me.navigationFrame.TabIndex = 0
        Me.navigationFrame.Text = "navigationFrame"
        '
        'employeesNavigationPage
        '
        Me.employeesNavigationPage.Controls.Add(Me.employeesLabelControl)
        Me.employeesNavigationPage.Name = "employeesNavigationPage"
        Me.employeesNavigationPage.Size = New System.Drawing.Size(625, 380)
        '
        'employeesLabelControl
        '
        Me.employeesLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 25.25!)
        Me.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.employeesLabelControl.Appearance.Options.UseFont = True
        Me.employeesLabelControl.Appearance.Options.UseForeColor = True
        Me.employeesLabelControl.Appearance.Options.UseTextOptions = True
        Me.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.employeesLabelControl.Location = New System.Drawing.Point(0, 0)
        Me.employeesLabelControl.Name = "employeesLabelControl"
        Me.employeesLabelControl.Size = New System.Drawing.Size(625, 380)
        Me.employeesLabelControl.TabIndex = 0
        Me.employeesLabelControl.Text = "Employees"
        '
        'customersNavigationPage
        '
        Me.customersNavigationPage.Controls.Add(Me.customersLabelControl)
        Me.customersNavigationPage.Name = "customersNavigationPage"
        Me.customersNavigationPage.Size = New System.Drawing.Size(625, 380)
        '
        'customersLabelControl
        '
        Me.customersLabelControl.Appearance.Font = New System.Drawing.Font("Tahoma", 25.25!)
        Me.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.customersLabelControl.Appearance.Options.UseFont = True
        Me.customersLabelControl.Appearance.Options.UseForeColor = True
        Me.customersLabelControl.Appearance.Options.UseTextOptions = True
        Me.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customersLabelControl.Location = New System.Drawing.Point(0, 0)
        Me.customersLabelControl.Name = "customersLabelControl"
        Me.customersLabelControl.Size = New System.Drawing.Size(625, 380)
        Me.customersLabelControl.TabIndex = 1
        Me.customersLabelControl.Text = "Customers"
        '
        '$newskindrop$
        '
        Me.SkinDropDownButtonItem.Id = 46
        Me.SkinDropDownButtonItem.Name = "$newskindrop$"
        '
        '$newskinpaletteribbon$
        '
        Me.SkinPaletteRibbonGalleryBarItem1.Caption = "$newskinpaletteribbon$"
        Me.SkinPaletteRibbonGalleryBarItem1.Id = 47
        Me.SkinPaletteRibbonGalleryBarItem1.Name = "$newskinpaletteribbon$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 599)
        Me.Controls.Add(Me.navigationFrame)
        Me.Controls.Add(Me.navBarControl)
        Me.Controls.Add(Me.officeNavigationBar)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.officeNavigationBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navigationFrame.ResumeLayout(False)
        Me.employeesNavigationPage.ResumeLayout(False)
        Me.customersNavigationPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonPageGroupNavigation As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents barSubItemNavigation As DevExpress.XtraBars.BarSubItem
    Private WithEvents skinRibbonGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Private WithEvents officeNavigationBar As DevExpress.XtraBars.Navigation.OfficeNavigationBar
    Private WithEvents navigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame
    Private WithEvents navBarControl As DevExpress.XtraNavBar.NavBarControl
    Private WithEvents employeesNavBarGroup As DevExpress.XtraNavBar.NavBarGroup
    Private WithEvents customersNavBarGroup As DevExpress.XtraNavBar.NavBarGroup
    Private WithEvents employeesNavigationPage As DevExpress.XtraBars.Navigation.NavigationPage
    Private WithEvents employeesLabelControl As DevExpress.XtraEditors.LabelControl
    Private WithEvents customersNavigationPage As DevExpress.XtraBars.Navigation.NavigationPage
    Private WithEvents customersLabelControl As DevExpress.XtraEditors.LabelControl
    Private WithEvents employeesBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Private WithEvents customersBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinDropDownButtonItem As DevExpress.XtraBars.SkinDropDownButtonItem
    Friend WithEvents SkinPaletteRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem
End Class
