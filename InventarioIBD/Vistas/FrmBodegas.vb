'Imports Controladores
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Text.RegularExpressions
Imports DevExpress.XtraVerticalGrid
Imports System.Data.SqlClient
Imports InventarioIBD.Consultas
Imports DevExpress.CodeParser
Imports DevExpress.XtraRichEdit.Model

Public Class FrmBodegas
    Dim dlg As DevExpress.Utils.WaitDialogForm = Nothing
    Dim conexion As New Conexion
    Dim nEstado As Integer = 0
    Private id_bodega As String
    Private nombre As String
    Private estado As String
    Private usuario As String
    Private fecha As DateTime

    ' GETTER Y SETTER DE LA TABLA GEN_PROVEEDOR
    Public Property id_bodega_() As String
        Get
            Return id_bodega
        End Get
        Set(ByVal value As String)
            id_bodega = value
        End Set
    End Property
    Public Property nombre_() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property estado_() As String
        Get
            Return estado
        End Get
        Set(ByVal value As String)
            estado = value
        End Set
    End Property
    Public Property usuario_() As String
        Get
            Return usuario
        End Get
        Set(ByVal value As String)
            usuario = value
        End Set
    End Property
    Public Property fecha_() As DateTime
        Get
            Return fecha
        End Get
        Set(ByVal value As DateTime)
            fecha = value
        End Set
    End Property

    Private Sub gvListado_DoubleClick(sender As Object, e As EventArgs) Handles gvListado.DoubleClick
        Dim view As GridView = CType(sender, GridView)
        Dim rowHandle As Integer = gvListado.FocusedRowHandle

        If view.IsDataRow(rowHandle) Then

            DoClickRow(view, rowHandle)
            'EstadoOpciones(True)
            'EstadoObjetos()
            'nEstado = 0
            XtraTabControl1.SelectedTabPage = Mantenimiento
        End If
    End Sub
    Private Sub DoClickRow(ByVal view As GridView, ByVal rowHandle As Integer)

        dlg = New DevExpress.Utils.WaitDialogForm("Espere un Momento...", "Cargando Su Informacion ......", New System.Drawing.Size(500, 85))
        Try
            'bimprimir.Enabled = True
            'clProveedor.codproveedor_ = gvListado.GetFocusedRowCellValue("codproveedor")
            cargaDetalle(VGridControl1, True, view.GetRowCellValue(view.GetSelectedRows()(0), "id_bodega"))

            'PARA QUE EL GRIDCONTROL INICIE EN EL TOP
            If VGridControl1.Rows.Count > 0 Then
                VGridControl1.FocusedRow = VGridControl1.Rows(0)
                VGridControl1.MakeRowVisible(VGridControl1.FocusedRow)
            End If
            dlg.Close()
        Catch ex As Exception
            dlg.Close()
        End Try
    End Sub

    Function cargaDetalle(ByRef vgc As DevExpress.XtraVerticalGrid.VGridControl, Optional ByVal bSeleccion As Boolean = False, Optional ByVal sFiltro As String = "") As Boolean
        Dim query As String = "EXEC GestionarBodegas 'B'" & IIf(sFiltro.Length > 0, " , ", "") & sFiltro

        'ACTUALIZAR GRID'S ANTES DE GUARDAR
        vgc.PostEditor()
        vgc.UpdateFocusedRecord()

        'FUNCION PARA CARGA LA TABLA EN VERTICAL GRID GEN_PROVEEDOR
        'UTILIZADA PARA ACTULIZAR LA TABLA GEN_PROVEEDOR
        Try

            Dim dataTable As DataTable = GetDataTable(query)
            vgc.DataSource = Nothing
            vgc.Rows.Clear()
            vgc.DataSource = dataTable
            'Dim row As DevExpress.XtraVerticalGrid.Rows.EditorRow

            'DESACTIVA LAS LLAVES 
            vgc.GetRowByFieldName("id_bodega").Properties.ReadOnly = True
            vgc.GetRowByFieldName("fecha_creacion").Properties.ReadOnly = True
            vgc.GetRowByFieldName("id_usuario").Properties.ReadOnly = True

            'PONE OCULTO LAS FILAS  
            vgc.GetRowByFieldName("id_bodega").Visible = False
            vgc.GetRowByFieldName("fecha_creacion").Visible = False
            vgc.GetRowByFieldName("id_usuario").Visible = False

            ' PONE IN-ACTIVO LAS FILAS 
            For Each rwv As DevExpress.XtraVerticalGrid.Rows.EditorRow In vgc.Rows
                rwv.Properties.ReadOnly = True
            Next

            'PONE ROTULOS A LAS FILAS
            vgc.GetRowByFieldName("nombre_bodega").Properties.Caption = "NOMBRE"
            vgc.GetRowByFieldName("estado").Properties.Caption = "ESTADO"

            Dim chk As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            chk.ValueChecked = 1
            chk.ValueUnchecked = 0
            Dim chkbool As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            chkbool.ValueChecked = True
            chkbool.ValueUnchecked = False

            'ESTABLESE EL TIPO DE OBJETO SEGUN TIPO DE DATOS 
            vgc.GetRowByFieldName("nombre_bodega").Properties.RowEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
            vgc.GetRowByFieldName("estado").Properties.RowEdit = chk
            'PONE AGRUPAMOS A LAS FILAS

            Dim rowPrincipal As New DevExpress.XtraVerticalGrid.Rows.CategoryRow("Bodega")
            rowPrincipal.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
            rowPrincipal.Appearance.Options.UseFont = True
            vgc.Rows.Add(rowPrincipal)
            vgc.MoveRow(vgc.GetRowByFieldName("nombre_bodega"), rowPrincipal, False)
            vgc.MoveRow(vgc.GetRowByFieldName("estado"), rowPrincipal, False)
            vgc.MoveRow(vgc.GetRowByFieldName("id_usuario"), rowPrincipal, False)

            vgc.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
            vgc.RecordWidth = 250
            vgc.RowHeaderWidth = 100

            Return True

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, " Error de Carga de Registros de BODEGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function cargaLista(ByRef gc As DevExpress.XtraGrid.GridControl,
     ByRef gd As DevExpress.XtraGrid.Views.Grid.GridView, ByVal sqll As String) As Boolean
        Dim query As String = "EXEC GestionarBodegas 'S'"

        ''ACTUALIZAR GRID'S ANTES DE GUARDAR
        'gd.PostEditor()
        'gd.UpdateFocusedRecord()

        'FUNCION PARA CARGA LA TABLA EN VERTICAL GRID GEN_PROVEEDOR
        'UTILIZADA PARA ACTULIZAR LA TABLA GEN_PROVEEDOR
        Try

            Dim dataTable As DataTable = GetDataTable(query)
            gc.DataSource = Nothing
            gc.DataSource = dataTable
            'Dim row As DevExpress.XtraVerticalGrid.Rows.EditorRow

            'DESACTIVA LAS LLAVES 
            gd.Columns("id_bodega").Visible = False
            gd.Columns("fecha_creacion").Visible = False


            '' PONE IN-ACTIVO LAS FILAS 
            'For Each rwv As DevExpress.XtraVerticalGrid.Rows.EditorRow In vgc.Rows
            '    rwv.Properties.ReadOnly = True
            'Next

            Return True

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, " Error de Carga de Registros de BODEGA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Function tbEstado() As DataTable

        Dim tbstado As New DataTable
        tbstado.Columns.Add("Codigo")
        tbstado.Columns.Add("Descripcion")
        tbstado.Rows.Add(0, "Inactivo")
        tbstado.Rows.Add(1, "Activo")

        Return tbstado

    End Function
    Private Sub btnConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultar.ItemClick
        cargaLista(GridControl1, gvListado, "")
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        cargaDetalle(VGridControl1, True, "'-1'")
        nEstado = 2

    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        Dim bbandera As Boolean
        If nEstado = 2 Then  'Esta en Modo Nuevo Ingreso de Registro
            bbandera = CRUD("I")

            If bbandera Then
                cargaLista(GridControl1, gvListado, "")
                nEstado = 3
            End If
        ElseIf nEstado = 3 Then   'Esta en Modo de Modificacion de Registro
            bbandera = CRUD("U")
        End If
        ' Se se guardo todo bien 
        If bbandera Then
            'EstadoOpciones(True)
            'EstadoObjetos()
            Me.nEstado = nEstado + 4
            DevExpress.XtraEditors.XtraMessageBox.Show("El Proveedor Fue guardado satisfactoriamente.", Variables.NOMBRE_SISTEMA, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnModificar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificar.ItemClick
        nEstado = 3
    End Sub
    Public Function AbreviarTexto(texto As String) As String
        Dim palabras() As String = texto.Split(" "c)
        Dim abreviatura As String = ""

        For Each palabra As String In palabras
            If Not String.IsNullOrEmpty(palabra) Then
                abreviatura += palabra.Substring(0, 1).ToUpper()
            End If
        Next

        Return abreviatura
    End Function
    Private Sub cargar_parametros_sql(ByRef commsql As SqlClient.SqlCommand, ByVal sAccion As String)
        conexion.AbrirConexion()

        commsql.Parameters.AddWithValue("@id_bodega", AbreviarTexto())
        commsql.Parameters.AddWithValue("@nombre_bodega", nombre_bodega)
        commsql.Parameters.AddWithValue("@estado", estado)
        commsql.Parameters.AddWithValue("@id_usuario", id_usuario)
        commsql.Parameters.AddWithValue("@fecha_creacion", fecha_creacion)

    End Sub
    Function crear() As Object
        '  PARA INSERTAR EL REGISTRO DE LA TABLA GEN_PROVEEDOR
        'Me.valida()
        Dim commsql As New SqlClient.SqlCommand("mtto_GEN_PROVEEDOR")
        commsql.CommandType = CommandType.StoredProcedure
        cargar_parametros_sql(commsql, "I")
        Try
            Return commsql.ExecuteNonQuery
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, " Error de Ingreso de Registro en GEN_PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Function actualizar() As Object
        '  PARA INSERTAR EL REGISTRO DE LA TABLA GEN_PROVEEDOR
        'Me.valida()
        Dim commsql As New SqlClient.SqlCommand("mtto_GEN_PROVEEDOR")
        commsql.CommandType = CommandType.StoredProcedure
        cargar_parametros_sql(commsql, "U")
        Try
            Return commsql.ExecuteNonQuery
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, " Error de Ingreso de Registro en GEN_PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    Function eliminar() As Object
        '  PARA INSERTAR EL REGISTRO DE LA TABLA GEN_PROVEEDOR
        'Me.valida()
        Dim commsql As New SqlClient.SqlCommand("mtto_GEN_PROVEEDOR")
        commsql.CommandType = CommandType.StoredProcedure
        cargar_parametros_sql(commsql, "D")
        Try
            Return commsql.ExecuteNonQuery
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, " Error de Ingreso de Registro en GEN_PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    Private Function CRUD(ByVal sTipo As String) As Boolean
        Dim rw As DataRowView = VGridControl1.GetRecordObject(VGridControl1.FocusedRecord)
        cargafilasv(rw)
    End Function
    Function cargafilasv(ByRef rw As DataRowView) As Boolean


        'CARGA EL OBJETO DESDE UNA FILA DE VERTICALGRID 
        Try
            If Not rw Is Nothing Then
                id_bodega = AbreviarTexto(rw.Item("nombre_bodega"))
                nombre = rw.Item("nombre_bodega")
                estado = rw.Item("estado")
                usuario = rw.Item("id_usuario")
                fecha = DateTime.Now

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, " Error de carga del Registro en GEN_PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class