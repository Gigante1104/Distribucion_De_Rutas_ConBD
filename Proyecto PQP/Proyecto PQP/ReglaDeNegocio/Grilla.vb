Imports System.Data.OleDb
Imports System.Windows.Forms
Imports AccesoDatos
Public Class Grilla
    Dim bd As New BaseDeDato()

    Public Sub Preparar(ByVal pSql As String)
        bd.Conectar()
        bd.CrearComando(pSql)
    End Sub

    Public Sub AsignarParametro(ByVal pNombre As String, ByVal pTipo As OleDbType, ByVal pValor As Object)
        bd.AsignarParametro(pNombre, pTipo, pValor)
    End Sub

    Public Sub Cargar(ByVal pGrilla As DataGridView)
        Dim dt As New DataTable()
        dt = bd.EjecutarConsultaDataTable()
        pGrilla.DataSource = dt
        bd.Desconectar()
    End Sub
    Public Sub CargarOrdenado(ByVal pGrilla As DataGridView, ByVal pSql As String)
        bd.Conectar()
        bd.CrearComando(pSql)
        Dim dt As New DataTable()
        dt = bd.EjecutarConsultaDataTable()
        dt.Columns.Remove("Orden")
        pGrilla.DataSource = dt
        bd.Desconectar()
    End Sub
    'Sobrecarga para ejecutar todos los metodos anteriores. Siempre y cuando se cargue un comobo simple.
    'Si cargamos un Combo box que dependa de otra, muy seguramente habra que colocar parametros a la consulta con asignar parametros.
    Public Sub Cargar(ByVal pGrilla As DataGridView, ByVal pSql As String)
        Preparar(pSql)
        Cargar(pGrilla)
    End Sub
End Class
