Imports AccesoDatos
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class Area
    Public Shared Sub CargarCombo(ByVal pCombo As ComboBox)
        Dim cmb As New Combo
        Dim vSql As String = "SELECT [Nombre] FROM Area WHERE [Nombre] <> 'Todas Las Areas.' AND [Nombre] <> 'Ferr. - Qco.' AND [Nombre] <> 'Log. - Qco. - Dtg.'"
        cmb.Cargar(pCombo, vSql, "Nombre", "Nombre")
    End Sub
    Public Shared Sub CargarComboFiltro(ByVal pCombo As ComboBox)
        Dim cmb As New Combo
        Dim vSql As String = "SELECT [Nombre], 0 AS Orden FROM Area WHERE [Nombre] = 'Todas Las Areas.' UNION SELECT [Nombre], 1 AS Orden FROM Area WHERE [Nombre] <> 'Todas Las Areas.' ORDER BY Orden, [Nombre] ASC"
        cmb.Cargar(pCombo, vSql, "Nombre", "Nombre")
    End Sub
    Public Shared Sub CargarGrilla(ByVal dg As DataGridView)
        Dim dgvArea As New Grilla()
        Dim vSql As String = "SELECT [Nombre], 0 AS Orden FROM Area WHERE [Nombre] = 'Todas Las Areas.' UNION SELECT [Nombre], 1 AS Orden FROM Area WHERE [Nombre] <> 'Todas Las Areas.' ORDER BY Orden, [Nombre] ASC"
        dgvArea.CargarOrdenado(dg, vSql)
    End Sub

    Public Function Crear(ByVal pNombre As String) As Boolean
        Dim bd As New BaseDeDato()
        Dim vNumReg As Integer
        Dim vSql As String = "INSERT INTO Area (Nombre) VALUES (@Nombre)"
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

    Public Function Eliminar(ByVal pNombre As String) As Boolean
        Dim vNumReg As Integer
        Dim bd As New BaseDeDato()
        Dim vSql As String = "DELETE FROM Area WHERE [Nombre]=@Nombre"
        Dim vElimino As Boolean = False
        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@Nombre", OleDbType.VarChar, pNombre)
        vNumReg = bd.EjecutarComando()
        bd.Desconectar()
        If (vNumReg > 0) Then
            vElimino = True
        End If
        Return vElimino
    End Function
End Class

