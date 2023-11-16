Imports System.Data.SqlClient

Public Module Consultas
    Public Function GetDataTable(query As String) As DataTable
        Dim dataTable As New DataTable()

        Using conexion As New Conexion()
            Try
                conexion.AbrirConexion()

                Using command As New SqlCommand(query, conexion.Conexion)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using
            Catch ex As Exception
                ' Manejo de errores
                MessageBox.Show("Error al obtener datos: " & ex.Message)
            Finally
                conexion.CerrarConexion()
            End Try
        End Using

        Return dataTable
    End Function
End Module
