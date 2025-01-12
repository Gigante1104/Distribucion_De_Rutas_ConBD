Imports System.Data.OleDb
Imports System.Windows.Forms
Imports AccesoDatos

Public Class Conductor
    Public Property Nombre As String
    Public Sub New()
        Nombre = Nothing
    End Sub

    Public Shared Sub CargarCombo(ByVal pCombo As ComboBox)
        Dim cmb As New Combo
        Dim vSql As String = "SELECT [Nombre], 0 AS Orden FROM Conductores WHERE [Nombre] = 'No Asignado' UNION SELECT [Nombre], 1 AS Orden FROM Conductores WHERE [Nombre] <> 'No Asignado' ORDER BY Orden, [Nombre] ASC"
        cmb.Cargar(pCombo, vSql, "Nombre", "Nombre")
    End Sub

    Public Shared Sub CargarGrilla(ByVal dg As DataGridView)
        Dim dgvConductores As New Grilla()
        Dim vSql As String = "SELECT [Nombre], 0 AS Orden FROM Conductores WHERE [Nombre] = 'No Asignado' UNION SELECT [Nombre], 1 AS Orden FROM Conductores WHERE [Nombre] <> 'No Asignado' ORDER BY Orden, [Nombre] ASC"
        dgvConductores.CargarOrdenado(dg, vSql)
    End Sub

    Public Function Crear(ByVal pNombre As String) As Boolean
        Dim vNumReg As Integer
        Dim bd As New BaseDeDato()
        Dim vCreo As Boolean = False
        Dim vSql As String = "INSERT INTO Conductores (Nombre) VALUES (@Nombre)"
        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@Nombre", OleDbType.VarChar, pNombre)
        vNumReg = bd.EjecutarComando()
        bd.Desconectar()
        If (vNumReg > 0) Then
            vCreo = True
        End If
        Return vCreo
    End Function

    Public Function Eliminar(ByVal pNombre As String) As Boolean
        Dim vNumReg As Integer
        Dim bd As New BaseDeDato()
        Dim vSql As String = "DELETE FROM Conductores WHERE [Nombre]=@Nombre"
        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@Nombre", OleDbType.VarChar, pNombre)
        vNumReg = bd.EjecutarComando()
        bd.Desconectar()
        If (vNumReg > 0) Then
            Return True
        End If
        Return False
    End Function
End Class
