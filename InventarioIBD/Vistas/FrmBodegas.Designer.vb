<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBodegas
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
        RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        btnNuevo = New DevExpress.XtraBars.BarButtonItem()
        btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        btnModificar = New DevExpress.XtraBars.BarButtonItem()
        btnConsultar = New DevExpress.XtraBars.BarButtonItem()
        RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Consulta = New DevExpress.XtraTab.XtraTabPage()
        GridControl1 = New DevExpress.XtraGrid.GridControl()
        gvListado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Mantenimiento = New DevExpress.XtraTab.XtraTabPage()
        VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        CType(RibbonControl, ComponentModel.ISupportInitialize).BeginInit()
        CType(XtraTabControl1, ComponentModel.ISupportInitialize).BeginInit()
        XtraTabControl1.SuspendLayout()
        Consulta.SuspendLayout()
        CType(GridControl1, ComponentModel.ISupportInitialize).BeginInit()
        CType(gvListado, ComponentModel.ISupportInitialize).BeginInit()
        Mantenimiento.SuspendLayout()
        CType(VGridControl1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RibbonControl
        ' 
        RibbonControl.ExpandCollapseItem.Id = 0
        RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {RibbonControl.ExpandCollapseItem, RibbonControl.SearchEditItem, btnNuevo, btnGuardar, btnModificar, btnConsultar})
        RibbonControl.Location = New Point(0, 0)
        RibbonControl.MaxItemId = 5
        RibbonControl.Name = "RibbonControl"
        RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {RibbonPage1})
        RibbonControl.Size = New Size(1044, 158)
        RibbonControl.StatusBar = RibbonStatusBar
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Caption = "Nuevo"
        btnNuevo.Id = 1
        btnNuevo.Name = "btnNuevo"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Caption = "Guardar"
        btnGuardar.Id = 2
        btnGuardar.Name = "btnGuardar"
        ' 
        ' btnModificar
        ' 
        btnModificar.Caption = "Modificar"
        btnModificar.Id = 3
        btnModificar.Name = "btnModificar"
        ' 
        ' btnConsultar
        ' 
        btnConsultar.Caption = "Consultar"
        btnConsultar.Id = 4
        btnConsultar.Name = "btnConsultar"
        ' 
        ' RibbonPage1
        ' 
        RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {RibbonPageGroup1})
        RibbonPage1.Name = "RibbonPage1"
        RibbonPage1.Text = "Transacciones"
        ' 
        ' RibbonPageGroup1
        ' 
        RibbonPageGroup1.ItemLinks.Add(btnNuevo)
        RibbonPageGroup1.ItemLinks.Add(btnGuardar)
        RibbonPageGroup1.ItemLinks.Add(btnModificar)
        RibbonPageGroup1.ItemLinks.Add(btnConsultar)
        RibbonPageGroup1.Name = "RibbonPageGroup1"
        RibbonPageGroup1.Text = "RibbonPageGroup1"
        ' 
        ' RibbonStatusBar
        ' 
        RibbonStatusBar.Location = New Point(0, 474)
        RibbonStatusBar.Name = "RibbonStatusBar"
        RibbonStatusBar.Ribbon = RibbonControl
        RibbonStatusBar.Size = New Size(1044, 24)
        ' 
        ' XtraTabControl1
        ' 
        XtraTabControl1.Location = New Point(0, 158)
        XtraTabControl1.Name = "XtraTabControl1"
        XtraTabControl1.SelectedTabPage = Consulta
        XtraTabControl1.Size = New Size(1044, 310)
        XtraTabControl1.TabIndex = 3
        XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Consulta, Mantenimiento})
        ' 
        ' Consulta
        ' 
        Consulta.Controls.Add(GridControl1)
        Consulta.Name = "Consulta"
        Consulta.Size = New Size(1042, 285)
        Consulta.Text = "Consulta"
        ' 
        ' GridControl1
        ' 
        GridControl1.Location = New Point(-1, 3)
        GridControl1.MainView = gvListado
        GridControl1.MenuManager = RibbonControl
        GridControl1.Name = "GridControl1"
        GridControl1.Size = New Size(1043, 280)
        GridControl1.TabIndex = 1
        GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {gvListado})
        ' 
        ' gvListado
        ' 
        gvListado.GridControl = GridControl1
        gvListado.Name = "gvListado"
        ' 
        ' Mantenimiento
        ' 
        Mantenimiento.Controls.Add(VGridControl1)
        Mantenimiento.Name = "Mantenimiento"
        Mantenimiento.Size = New Size(1042, 285)
        Mantenimiento.Text = "Mantenimiento"
        ' 
        ' VGridControl1
        ' 
        VGridControl1.Location = New Point(3, 0)
        VGridControl1.MenuManager = RibbonControl
        VGridControl1.Name = "VGridControl1"
        VGridControl1.Size = New Size(400, 282)
        VGridControl1.TabIndex = 0
        ' 
        ' FrmBodegas
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1044, 498)
        Controls.Add(XtraTabControl1)
        Controls.Add(RibbonStatusBar)
        Controls.Add(RibbonControl)
        Name = "FrmBodegas"
        Ribbon = RibbonControl
        StatusBar = RibbonStatusBar
        Text = "MenuPrincipal"
        CType(RibbonControl, ComponentModel.ISupportInitialize).EndInit()
        CType(XtraTabControl1, ComponentModel.ISupportInitialize).EndInit()
        XtraTabControl1.ResumeLayout(False)
        Consulta.ResumeLayout(False)
        CType(GridControl1, ComponentModel.ISupportInitialize).EndInit()
        CType(gvListado, ComponentModel.ISupportInitialize).EndInit()
        Mantenimiento.ResumeLayout(False)
        CType(VGridControl1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnModificar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Consulta As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvListado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Mantenimiento As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents btnConsultar As DevExpress.XtraBars.BarButtonItem
End Class
