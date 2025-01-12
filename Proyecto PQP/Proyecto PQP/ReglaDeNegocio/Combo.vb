Imports System.Data.OleDb
Imports System.Windows.Forms
Imports AccesoDatos
Public Class Combo
    Dim bd As New BaseDeDato()

    Public Sub Preparar(ByVal pSql As String)
        bd.Conectar()
        bd.CrearComando(pSql)
    End Sub

    Public Sub AsignarParametro(ByVal pNombre As String, ByVal pTipo As OleDbType, ByVal pValor As Object)
        bd.AsignarParametro(pNombre, pTipo, pValor)
    End Sub
    'Forma alternativa abajo.
    'Public Sub CargarCbFiltro(ByVal pCombo As ComboBox, ByVal pSql As String, ByVal pDisplayMember As String, ByVal pValueMember As String)
    '    bd.Conectar()
    '    'bd.CrearComando("SELECT [Nombre] FROM Area WHERE [Nombre] <> 'Todas Las Areas.' ORDER BY [Nombre] ASC")
    '    Dim dt2 As New DataTable()
    '    dt2 = bd.EjecutarConsultaDataTable()

    '    'bd.CrearComando("SELECT [Nombre] FROM Area WHERE [Nombre] = 'Todas Las Areas.'")
    '    'Dim nuevaFila As DataRow = dt2.NewRow()
    '    'nuevaFila("Nombre") = bd.EjecutarConsultaDataTable().Rows(0)("Nombre")
    '    'bd.Desconectar()
    '    'dt2.Rows.InsertAt(nuevaFila, 0)
    '    Dim area As Integer
    '    area = dt2.Rows.Count
    '    Dim vector(area - 1) As String
    '    Dim cadena As String
    '    For i As Integer = 0 To vector.Length - 1
    '        vector(i) = (dt2.Rows.Item(i)("Nombre").ToString)
    '        cadena += vector(i) + ", "
    '    Next
    '    MessageBox.Show(cadena)
    '    pCombo.DataSource = dt2
    '    pCombo.DisplayMember = pDisplayMember
    '    pCombo.ValueMember = pValueMember
    'End Sub
    Public Sub Cargar(ByVal pCombo As ComboBox, ByVal pDisplayMember As String, ByVal pValueMember As String)
        Dim dt As New DataTable()
        dt = bd.EjecutarConsultaDataTable()
        bd.Desconectar()
        pCombo.DataSource = dt
        pCombo.DisplayMember = pDisplayMember
        pCombo.ValueMember = pValueMember
    End Sub
    'Sobrecarga para ejecutar todos los metodos anteriores. Siempre y cuando se cargue un comobo simple.
    'Si cargamos un Combo box que dependa de otra, muy seguramente habra que colocar parametros a la consulta con asignar parametros.
    Public Sub Cargar(ByVal pCombo As ComboBox, ByVal pSql As String, ByVal pDisplayMember As String, ByVal pValueMember As String)
        Preparar(pSql)
        Cargar(pCombo, pDisplayMember, pValueMember)
    End Sub
End Class
