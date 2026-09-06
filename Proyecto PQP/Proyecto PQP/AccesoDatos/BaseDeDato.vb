Imports System.Data.OleDb
Imports System.Net.Mime.MediaTypeNames
Public Class BaseDeDato

    Public Property BdCodeError As Integer
    Public Property BdMsgError As String

    Dim cadConex As String
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand

    Sub New()
        BdCodeError = 0
        BdMsgError = ""
        ' AppDomain.CurrentDomain.BaseDirectory obtiene la ruta del .exe sin importar la capa en la que estés
        Dim rutaBase As String = AppDomain.CurrentDomain.BaseDirectory
        Dim rutaBD As String = System.IO.Path.Combine(rutaBase, "BdProyect", "bd Proyecto.accdb")

        cadConex = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & rutaBD
    End Sub

    Public Sub Conectar()
        cn = New OleDbConnection(cadConex)
        cn.Open()
    End Sub

    Public Sub Desconectar()
        cn.Close()
    End Sub

    Public Sub CrearComando(ByVal pSql)
        cmd = New OleDbCommand(pSql, cn)
    End Sub

    Public Sub AsignarParametro(ByVal pNombre As String, ByVal pTypo As OleDbType, ByVal pValor As Object)
        cmd.Parameters.Add(pNombre, pTypo).Value = pValor
    End Sub

    Public Function EjecutarComando() As Integer
        Dim vNumReg As Integer
        Try
            vNumReg = cmd.ExecuteNonQuery()
        Catch ex As OleDbException
            Desconectar()
            BdCodeError = ex.ErrorCode
            BdMsgError = ex.Message
        End Try
        Return vNumReg
    End Function

    Public Function EjecutarConsulta() As OleDbDataReader
        Return cmd.ExecuteReader()
    End Function

    Public Function EjecutarConsultaDataTable() As DataTable
        Dim dt As New DataTable()
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Class
