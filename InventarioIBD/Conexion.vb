Imports System.Data.SqlClient


Public Class Conexion
    Implements IDisposable

    Public Conexion As New SqlConnection("Data Source=DESKTOP-B1JIUS0\SQLEXPRESS02;Initial Catalog=base_ibd;Integrated Security=True")

    Public Sub AbrirConexion()
        If Conexion.State = ConnectionState.Closed Then
            Conexion.Open()
        End If
    End Sub

    Public Sub CerrarConexion()
        If Conexion.State = ConnectionState.Open Then
            Conexion.Close()
        End If
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        CerrarConexion()
    End Sub
End Class
