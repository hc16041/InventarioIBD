<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits DevExpress.XtraEditors.XtraForm

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
        btnIniciar = New DevExpress.XtraEditors.SimpleButton()
        txtUsuario = New DevExpress.XtraEditors.TextEdit()
        txtContraseña = New DevExpress.XtraEditors.TextEdit()
        LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(txtUsuario.Properties, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtContraseña.Properties, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnIniciar
        ' 
        btnIniciar.Location = New Point(76, 115)
        btnIniciar.Margin = New Padding(3, 2, 3, 2)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(101, 29)
        btnIniciar.TabIndex = 0
        btnIniciar.Text = "Iniciar Sesión"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(66, 38)
        txtUsuario.Margin = New Padding(3, 2, 3, 2)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(134, 20)
        txtUsuario.TabIndex = 1
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(66, 76)
        txtContraseña.Margin = New Padding(3, 2, 3, 2)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Properties.PasswordChar = "*"c
        txtContraseña.Size = New Size(134, 20)
        txtContraseña.TabIndex = 2
        ' 
        ' LabelControl1
        ' 
        LabelControl1.Location = New Point(102, 20)
        LabelControl1.Margin = New Padding(3, 2, 3, 2)
        LabelControl1.Name = "LabelControl1"
        LabelControl1.Size = New Size(36, 13)
        LabelControl1.TabIndex = 3
        LabelControl1.Text = "Usuario"
        ' 
        ' LabelControl2
        ' 
        LabelControl2.Location = New Point(102, 58)
        LabelControl2.Margin = New Padding(3, 2, 3, 2)
        LabelControl2.Name = "LabelControl2"
        LabelControl2.Size = New Size(56, 13)
        LabelControl2.TabIndex = 4
        LabelControl2.Text = "Contraseña"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(255, 211)
        Controls.Add(LabelControl2)
        Controls.Add(LabelControl1)
        Controls.Add(txtContraseña)
        Controls.Add(txtUsuario)
        Controls.Add(btnIniciar)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Login"
        Text = "Login"
        CType(txtUsuario.Properties, ComponentModel.ISupportInitialize).EndInit()
        CType(txtContraseña.Properties, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnIniciar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtContraseña As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
