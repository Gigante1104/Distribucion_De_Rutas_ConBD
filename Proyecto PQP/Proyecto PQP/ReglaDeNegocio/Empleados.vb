Imports AccesoDatos
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class Empleados
    Public Shared TelViejo As String
    Public Property Nombre As String
    Public Property Area As String
    Public Property Direccion As String
    Public Property Telefono As String
    Public Property Ruta As String
    Public Property BdCodeError As Integer
    Public Property BdMsgError As String

    Public Sub New()
        Nombre = Nothing
        Direccion = Nothing
        Area = Nothing
        Telefono = Nothing
        TelViejo = Nothing

        BdCodeError = Nothing
        BdMsgError = Nothing
    End Sub

    Public Sub New(ByVal pNombre As String, ByVal pDireccion As String, ByVal pSede As String, ByVal pTelefono As String, ByVal pArea As Integer)
        Nombre = pNombre
        Direccion = pDireccion
        Area = pSede
        Telefono = pTelefono
        TelViejo = Nothing

        BdCodeError = Nothing
        BdMsgError = Nothing
    End Sub

    Public Shared Sub CargarGrilla(ByVal dg As DataGridView)
        Dim dgvClientes As New Grilla() 'cuidado con este order by.
        Dim vSql As String = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Empleados ORDER BY [Nombre], [Area] ASC"
        dgvClientes.Cargar(dg, vSql)
    End Sub

    Public Shared Sub CargarGrillaFiltro(ByVal dg As DataGridView, ByVal filtro As String)
        Dim dgvClientes As New Grilla()
        Dim vSql As String
        If filtro = "Todas Las Areas." Then
            CargarGrilla(dg)
        ElseIf filtro = "Log. - Qco. - Dtg." Then
            vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Empleados WHERE [Area] = 'Log.' Or [Area] = 'Qco.' Or [Area] = 'Dtg.' ORDER BY [Nombre] ASC"
            dgvClientes.Cargar(dg, vSql)
        ElseIf filtro = "Ferr. - Qco." Then
            vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Empleados WHERE [Area] = 'Ferr.' Or [Area] = 'Qco.' ORDER BY [Nombre] ASC"
            dgvClientes.Cargar(dg, vSql)
        Else
            vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Empleados WHERE [Area] = '" & filtro & "' ORDER BY [Nombre] ASC"
            dgvClientes.Cargar(dg, vSql)
        End If
    End Sub

    Public Function validarEmpleadoDuplicado(ByVal pNombre As String, ByVal pDireccion As String, ByVal pArea As String) As Boolean
        Dim bd As New BaseDeDato()
        Dim dr As OleDbDataReader
        Dim vConsulto As Boolean = False
        Dim vSql As String = "SELECT [Nombre] FROM Empleados WHERE [Nombre]=@Nombre AND [Area]=@Area AND [Direccion]=@Direccion"
        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@Nombre", OleDbType.VarChar, pNombre)
        bd.AsignarParametro("@Area", OleDbType.VarChar, pArea)
        bd.AsignarParametro("@Direccion", OleDbType.VarChar, pDireccion)
        dr = bd.EjecutarConsulta()
        If (dr.Read()) Then
            vConsulto = True
        End If
        bd.Desconectar()
        Return vConsulto
    End Function
    Public Function Crear(ByVal pNombre As String, ByVal pDireccion As String, ByVal pArea As String, ByVal pTelefono As String, ByVal pRuta As String) As Boolean
        Dim vNumReg As Integer
        Dim bd As New BaseDeDato()
        Dim vCreo As Boolean = False
        Dim vSql As String = "INSERT INTO Empleados ([Nombre], [Telefono], [Direccion], [Area], [Ruta]) VALUES (@Nombre, @Telefono, @Direccion, @Area, @Ruta)"
        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@Nombre", OleDbType.VarChar, pNombre)
        bd.AsignarParametro("@Telefono", OleDbType.VarChar, pTelefono)
        bd.AsignarParametro("@Direccion", OleDbType.VarChar, pDireccion)
        bd.AsignarParametro("@Area", OleDbType.VarChar, pArea)
        bd.AsignarParametro("@Ruta", OleDbType.VarChar, pRuta)
        vNumReg = bd.EjecutarComando()
        bd.Desconectar()
        If (vNumReg > 0) Then
            vCreo = True
        Else
            If (bd.BdCodeError <> 0) Then
                BdCodeError = bd.BdCodeError
                BdMsgError = bd.BdMsgError
            End If
        End If
        Return vCreo
    End Function
    Private Function Rectificar(ByVal pNombre As String, ByVal pArea As String, ByVal pDireccion As String) As DataTable
        Dim bd As New BaseDeDato()
        Dim dt As DataTable
        Dim vSql As String = "SELECT [Nombre], [Area], [Direccion] FROM Empleados WHERE [Nombre]=@Nombre AND [Area]=@Area AND [Direccion]=@Direccion"
        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@Nombre", OleDbType.VarChar, pNombre)
        bd.AsignarParametro("@Area", OleDbType.VarChar, pArea)
        bd.AsignarParametro("@Direccion", OleDbType.VarChar, pDireccion)
        dt = bd.EjecutarConsultaDataTable()
        bd.Desconectar()
        Return dt
    End Function
    Public Function Actualizar(ByVal pNombreNuevo As String, ByVal pAreaNueva As String, ByVal pDireccionNueva As String, ByVal pTelefono As String, ByVal pRuta As String) As Boolean
        Dim vNumReg, respuesta As Integer
        Dim dt As DataTable
        Dim bd As New BaseDeDato()
        Dim vActualizo As Boolean = False
        Dim mensaje As String = ""
        Dim vSql As String = "UPDATE Empleados SET [Nombre]=@NombreNuevo, [Area]=@AreaNueva, [Direccion]=@DireccionNueva, [Telefono]=@Telefono, [Ruta]=@Ruta WHERE [Nombre]=@NombreA AND [Area]=@AreaA AND [Direccion]=@DireccionA"
        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@NombreNuevo", OleDbType.VarChar, pNombreNuevo)
        bd.AsignarParametro("@AreaNueva", OleDbType.VarChar, pAreaNueva)
        bd.AsignarParametro("@DireccionNueva", OleDbType.VarChar, pDireccionNueva)
        bd.AsignarParametro("@Telefono", OleDbType.VarChar, pTelefono)
        bd.AsignarParametro("@Ruta", OleDbType.VarChar, pRuta)
        bd.AsignarParametro("@NombreA", OleDbType.VarChar, Nombre)
        bd.AsignarParametro("@AreaA", OleDbType.VarChar, Area)
        bd.AsignarParametro("@DireccionA", OleDbType.VarChar, Direccion)
        dt = Rectificar(Nombre, Area, Direccion)
        vNumReg = dt.Rows.Count()
        If vNumReg > 0 Then
            mensaje += "Habran " & vNumReg & " registro(s) afectados." & vbNewLine
            For i As Integer = 0 To vNumReg - 1
                mensaje += "El empleado: " & dt(i)("Nombre").ToString() & ", con dirección: " & dt(i)("Direccion").ToString() & ", que trabaja en el area: " & dt(i)("Area").ToString() & vbNewLine
            Next
            mensaje += "¿Desea continuar?"
            respuesta = MsgBox(mensaje, vbYesNo)
            If respuesta = vbYes Then
                vNumReg = bd.EjecutarComando()
                If (vNumReg > 0) Then
                    vActualizo = True
                ElseIf (vNumReg > 1) Then
                    vActualizo = True
                    MessageBox.Show("Hubo " & vNumReg & " registros afectados.", "Alerta!")
                Else
                    If (bd.BdCodeError <> 0) Then
                        BdCodeError = bd.BdCodeError
                        BdMsgError = bd.BdMsgError
                    End If
                End If
            Else
                MessageBox.Show("No hubo registros afectados.", "Alerta!")
            End If
        Else
            vNumReg = bd.EjecutarComando()
            If (vNumReg > 0) Then
                vActualizo = True
            Else
                If (bd.BdCodeError <> 0) Then
                    BdCodeError = bd.BdCodeError
                    BdMsgError = bd.BdMsgError
                End If
            End If
        End If
        bd.Desconectar()
        Return vActualizo
    End Function
    'Metodo de más que no se esta usando actualmente.
    Public Function ActualizarTel(ByVal pNombre As String, ByVal pArea As String, ByVal pDireccion As String, ByVal pNuevoTel As String) As Boolean
        Dim vNumReg As Integer
        Dim bd As New BaseDeDato()
        Dim vActualizo As Boolean = False
        Dim vSql As String = "UPDATE Empleados SET [Telefono]=@NuevoTel WHERE [Nombre]=@Nombre AND [Area]=@Area AND [Direccion]=@Direccion OR [Telefono]=@TelViejo"
        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@NuevoTel", OleDbType.VarChar, pNuevoTel)
        bd.AsignarParametro("@Nombre", OleDbType.VarChar, pNombre)
        bd.AsignarParametro("@Area", OleDbType.VarChar, pArea)
        bd.AsignarParametro("@Direccion", OleDbType.VarChar, pDireccion)
        bd.AsignarParametro("@TelViejo", OleDbType.VarChar, TelViejo)
        vNumReg = bd.EjecutarComando()
        bd.Desconectar()
        If (vNumReg > 0) Then
            vActualizo = True
        Else
            If (bd.BdCodeError <> 0) Then
                BdCodeError = bd.BdCodeError
                BdMsgError = bd.BdMsgError
            End If
        End If

        Return vActualizo
    End Function

    Public Function ConsultarPorTel(ByVal pTelefono As String) As Boolean
        Dim bd As New BaseDeDato()
        Dim dr As OleDbDataReader
        Dim vConsulto As Boolean = False
        Dim vSql As String = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Empleados WHERE [Telefono]=@Telefono"
        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@Telefono", OleDbType.VarChar, pTelefono)
        dr = bd.EjecutarConsulta()
        If (dr.Read()) Then
            vConsulto = True
            Me.Nombre = dr("Nombre").ToString
            Me.Area = dr("Area").ToString
            Me.Direccion = dr("Direccion").ToString
            Me.Telefono = pTelefono
            Me.Ruta = dr("Ruta").ToString
        End If
        bd.Desconectar()
        Return vConsulto
    End Function
    'Metodo que no se esta usando actualmente, pero podría funcionar (aunque no busca por P.K).
    Public Function Consultar(ByVal pNombre As String, ByVal pArea As String, ByVal pTelefono As String) As Boolean
        Dim bd As New BaseDeDato()
        Dim dr As OleDbDataReader
        Dim vConsulto As Boolean = False
        Dim vSql As String
        If pTelefono = "" Then
            vSql = "SELECT [Direccion], [Ruta] FROM Empleados WHERE ([Nombre]=@Nombre AND [Area]=@Area)"
        Else
            vSql = "SELECT [Direccion], [Ruta] FROM Empleados WHERE ([Nombre]=@Nombre AND [Area]=@Area) OR [Telefono]=@Telefono"
        End If

        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@Nombre", OleDbType.VarChar, pNombre)
        bd.AsignarParametro("@Area", OleDbType.VarChar, pArea)
        bd.AsignarParametro("@Telefono", OleDbType.VarChar, pTelefono)
        dr = bd.EjecutarConsulta()
        If (dr.Read()) Then
            vConsulto = True
            Me.Nombre = pNombre
            Me.Telefono = pTelefono
            Me.Direccion = dr("Direccion")
            Me.Area = pArea
            Me.Ruta = dr("Ruta").ToString
        End If
        bd.Desconectar()
        Return vConsulto
    End Function

    Public Function Eliminar(ByVal pNombre As String, ByVal pArea As String, ByVal pDireccion As String) As Boolean
        Dim dt As DataTable
        Dim mensaje As String = ""
        Dim bd As New BaseDeDato()
        Dim vElimino As Boolean = False
        Dim vNumReg, respuesta As Integer
        Dim vSql As String = "DELETE FROM Empleados WHERE [Nombre]=@Nombre AND [Area]=@Area AND [Direccion]=@Direccion"
        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@Nombre", OleDbType.VarChar, pNombre)
        bd.AsignarParametro("@Area", OleDbType.VarChar, pArea)
        bd.AsignarParametro("@Direccion", OleDbType.VarChar, pDireccion)
        dt = Rectificar(pNombre, pArea, pDireccion)
        vNumReg = dt.Rows.Count()
        If vNumReg > 1 Then
            mensaje += "Habran " & vNumReg & " registro(s) afectados." & vbNewLine
            For i As Integer = 0 To vNumReg - 1
                mensaje += "El empleado: " & dt(i)("Nombre").ToString() & ", con dirección: " & dt(i)("Direccion").ToString() & ", que trabaja en el area: " & dt(i)("Area").ToString() & vbNewLine
            Next
            mensaje += "¿Desea continuar?"
            respuesta = MsgBox(mensaje, vbYesNo)
            If respuesta = vbYes Then
                vNumReg = bd.EjecutarComando()
                If (vNumReg > 0) Then
                    vElimino = True
                    MessageBox.Show("Hubo " & vNumReg & " registros afectados.", "Alerta!")
                Else
                    If (bd.BdCodeError <> 0) Then
                        BdCodeError = bd.BdCodeError
                        BdMsgError = bd.BdMsgError
                    End If
                End If
            Else
                MessageBox.Show("No hubo registros afectados.", "Alerta!")
            End If
        Else
            vNumReg = bd.EjecutarComando()
            If (vNumReg > 0) Then
                vElimino = True
            Else
                If (bd.BdCodeError <> 0) Then
                    BdCodeError = bd.BdCodeError
                    BdMsgError = bd.BdMsgError
                End If
            End If
        End If
        bd.Desconectar()
        Return vElimino
    End Function
    'La 2da etapa de validación. Si no se crea el empleado, se verifica si el teléfono ya se encuentra registrado.
    Public Function ValidarDuplicado(ByVal pTel As String) As Boolean
        Dim bd As New BaseDeDato()
        Dim dr As OleDbDataReader
        Dim vEncontro As Boolean = False
        Dim vSql As String = "SELECT [Telefono] FROM Empleados WHERE [Telefono]=@telefono"
        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@telefono", OleDbType.VarChar, pTel)
        dr = bd.EjecutarConsulta()
        If (dr.Read()) Then
            vEncontro = True
        End If
        bd.Desconectar()
        Return vEncontro
    End Function

End Class
