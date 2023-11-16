
Public Class Login
    Dim conexion As New Conexion
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        'FrmTransacciones.Show()
        FrmBodegas.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnIniciar.Enabled = False
    End Sub

    Private Sub txtContraseña_EditValueChanged(sender As Object, e As EventArgs) Handles txtContraseña.EditValueChanged
        If txtUsuario.Text.Length > 0 And txtContraseña.Text.Length > 0 Then
            btnIniciar.Enabled = True
        Else
            btnIniciar.Enabled = False
        End If
    End Sub

End Class