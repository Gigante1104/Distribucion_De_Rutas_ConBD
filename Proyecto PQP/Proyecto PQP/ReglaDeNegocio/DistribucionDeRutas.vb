Imports System.Data.OleDb
Imports System.Windows.Forms
Imports AccesoDatos
Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel



Public Class DistribucionDeRutas
    Public Property Nombre As String
    Public Property Telefono As String
    Public Property Direccion As Integer
    Public Property BdCodeError As Integer
    Public Property BdMsgError As String
    Public Sub New()
        Nombre = Nothing
        Telefono = Nothing
        Direccion = Nothing

        BdCodeError = Nothing
        BdMsgError = Nothing
    End Sub

    Public Sub New(ByVal pNombre As String, ByVal pTelefono As String, ByVal pDireccion As Integer)
        Nombre = pNombre
        Telefono = pTelefono
        Direccion = pDireccion

        BdCodeError = Nothing
        BdMsgError = Nothing
    End Sub

    Public Shared Sub CargarComboFiltro(ByVal pCombo As ComboBox)
        Dim cmb As New Combo
        Dim vSql As String = "SELECT [Nombre], 0 AS Orden FROM Area WHERE [Nombre] = 'Todas Las Areas.' UNION SELECT [Nombre], 1 AS Orden FROM Area WHERE [Nombre] <> 'Todas Las Areas.' ORDER BY Orden, [Nombre] ASC"
        cmb.Cargar(pCombo, vSql, "Nombre", "Nombre")
    End Sub

    Public Shared Sub CargarComboConductor(ByVal pCombo As ComboBox)
        Dim cmb As New Combo
        Dim vSql As String = "SELECT [Nombre], 0 AS Orden FROM Conductores WHERE [Nombre] = 'No Asignado' UNION SELECT [Nombre], 1 AS Orden FROM Conductores WHERE [Nombre] <> 'No Asignado' ORDER BY Orden, [Nombre] ASC"
        cmb.Cargar(pCombo, vSql, "Nombre", "Nombre")
    End Sub

    Public Shared Sub CargarGrilla(ByVal dg As DataGridView)
        Dim dgvClientes As New Grilla()
        Dim vSql As String = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Empleados ORDER BY [Nombre] ASC"
        dgvClientes.Cargar(dg, vSql)
    End Sub

    Public Shared Function validarIngreso(ByVal opcion As Integer, ByVal pTelefono As String, ByVal pNombre As String, ByVal pArea As String, ByVal pDireccion As String) As Boolean
        Dim bd As New BaseDeDato()
        Dim dr As OleDbDataReader
        Dim vConsulto As Boolean = False
        Dim vSql As String
        'Con esos sqls garantizamos que el empleado no se repita en la misma tabla o el mismo turno.
        If (opcion = 1) Then
            vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono] FROM Entradas WHERE [Nombre]=@Nombre AND [Area]=@Area AND [Direccion]=@Direccion"
            ' vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono] FROM Entradas WHERE [Nombre]=@Nombre AND [Telefono]=@Telefono And [Direccion]=@Direccion"
        Else
            ' vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono] FROM Salidas WHERE [Nombre]=@Nombre AND [Telefono]=@Telefono And [Direccion]=@Direccion"
            vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono] FROM Salidas WHERE [Nombre]=@Nombre AND [Area]=@Area AND [Direccion]=@Direccion"
        End If

        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@Nombre", OleDbType.VarChar, pNombre)
        bd.AsignarParametro("@Area", OleDbType.VarChar, pArea)
        ' bd.AsignarParametro("@Telefono", OleDbType.VarChar, pTelefono)
        bd.AsignarParametro("@Direccion", OleDbType.VarChar, pDireccion)
        dr = bd.EjecutarConsulta()
        If (dr.Read()) Then
            vConsulto = True
        End If
        bd.Desconectar()
        Return vConsulto
    End Function
    Public Shared Sub CargarGrillaTemp(opcion As Integer, ByVal dg As DataGridView)
        Dim vSql As String
        Dim dgvClientes As New Grilla()
        If opcion = 1 Then
            vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta], [Conductor], [Novedades] FROM Entradas"
        Else
            vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta], [Conductor], [Novedades] FROM Salidas"
        End If

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

    Public Shared Sub CargarGrillaTempFiltro(opcion As Integer, ByVal dg As DataGridView, ByVal filtro As String)
        Dim dgvClientes As New Grilla()
        Dim vSql As String

        If filtro = "Todas Las Areas." Then
            CargarGrillaTemp(opcion, dg)
        Else
            If opcion = 1 Then
                If filtro = "Log. - Qco. - Dtg." Then
                    vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Entradas WHERE [Area] = 'Log.' Or [Area] = 'Qco.' Or [Area] = 'Dtg.' ORDER BY [Nombre] ASC"
                    dgvClientes.Cargar(dg, vSql)
                ElseIf filtro = "Ferr. - Qco." Then
                    vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Entradas WHERE [Area] = 'Ferr.' Or [Area] = 'Qco.' ORDER BY [Nombre] ASC"
                    dgvClientes.Cargar(dg, vSql)
                Else
                    vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Entradas WHERE [Area] = '" & filtro & "' ORDER BY [Nombre] ASC"
                    dgvClientes.Cargar(dg, vSql)
                End If
            Else

                If filtro = "Log. - Qco. - Dtg." Then
                    vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Salidas WHERE [Area] = 'Log.' Or [Area] = 'Qco.' Or [Area] = 'Dtg.' ORDER BY [Nombre] ASC"
                    dgvClientes.Cargar(dg, vSql)
                ElseIf filtro = "Ferr. - Qco." Then
                    vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Salidas WHERE [Area] = 'Ferr.' Or [Area] = 'Qco.' ORDER BY [Nombre] ASC"
                    dgvClientes.Cargar(dg, vSql)
                Else
                    vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta] FROM Salidas WHERE [Area] = '" & filtro & "' ORDER BY [Nombre] ASC"
                    dgvClientes.Cargar(dg, vSql)
                End If
            End If
        End If



        'Dim dgvClientes As New Grilla()
        'Dim vSql As String
        'If opcion = 1 Then
        '    vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta], [Conductor], [Novedades] FROM Entradas where [Area] = '" & filtro & "'"
        'Else
        '    vSql = "SELECT [Nombre], [Area], [Direccion], [Telefono], [Ruta], [Conductor], [Novedades] FROM Salidas where [Area] = '" & filtro & "'"
        'End If

        'dgvClientes.Cargar(dg, vSql)
    End Sub

    Public Function Exportar(ByVal dgvEntrada As DataGridView, ByVal dgvSalida As DataGridView) As Boolean
        Dim vExporto As Boolean = False
        Dim excel As New Microsoft.Office.Interop.Excel.Application
        Dim cuadro As New CuadroDeEspera()
        Try
            'Creación de todas las variables a usar
            Dim libro As Microsoft.Office.Interop.Excel.Workbook = excel.Workbooks.Add(Type.Missing)
            Dim hojaSalida As Microsoft.Office.Interop.Excel.Worksheet = CType(libro.Sheets.Add(), Microsoft.Office.Interop.Excel.Worksheet)
            Dim hojaEntrada As Microsoft.Office.Interop.Excel.Worksheet = CType(libro.Sheets.Add(), Microsoft.Office.Interop.Excel.Worksheet)

            Dim celda As Microsoft.Office.Interop.Excel.Range

            Dim anchoEntrada() As Integer = {36, 7, 64, 29, 22, 12, 14, 2}
            Dim anchoSalida() As Integer = {36, 7, 64, 29, 22, 12, 14, 2}

            Dim rango As Excel.Range

            Dim filaSalida As Microsoft.Office.Interop.Excel.Range
            Dim filaEntrada As Microsoft.Office.Interop.Excel.Range

            Dim dataRangeEntrada, dataRangeSalida As String

            Dim saveFileDialog1 As New SaveFileDialog()

            Dim hojaEliminar As Microsoft.Office.Interop.Excel.Worksheet
            'Hasta aqui.
            cuadro.lbMsgEspera.Text = "Agregando hojas al libro de excel..."
            cuadro.Show()

            hojaSalida.Name = "Salida"
            hojaEntrada.Name = "Entrada"

            Threading.Thread.Sleep(300)
            cuadro.lbMsgEspera.Text = "Aplicando el zoom correspondiente a las hojas de excel..."

            hojaSalida.Activate()
            hojaSalida.Application.ActiveWindow.Zoom = 140

            hojaEntrada.Activate()
            hojaEntrada.Application.ActiveWindow.Zoom = 140

            Threading.Thread.Sleep(300)
            cuadro.lbMsgEspera.Text = "Agregando primera fila y colocando sus datos en mayúsculas..."

            For j As Integer = 0 To dgvEntrada.Columns.Count - 1
                hojaEntrada.Cells(1, j + 1) = dgvEntrada.Columns(j).HeaderText.ToUpper
                hojaSalida.Cells(1, j + 1) = dgvSalida.Columns(j).HeaderText.ToUpper
            Next
            Threading.Thread.Sleep(300)
            cuadro.lbMsgEspera.Text = "Agregando todos los datos de los empleados a las hojas de excel..."

            For Each dgv As DataGridView In {dgvEntrada, dgvSalida}
                For i As Integer = 0 To dgv.Rows.Count - 1
                    For j As Integer = 0 To dgv.Columns.Count - 1
                        'Dim celda As Microsoft.Office.Interop.Excel.Range = If(dgv Is dgvEntrada, hojaEntrada, hojaSalida).Cells(i + 2, j + 1)
                        celda = If(dgv Is dgvEntrada, hojaEntrada, hojaSalida).Cells(i + 2, j + 1)
                        celda.Value = dgv.Rows(i).Cells(j).Value?.ToString()
                        celda.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft
                    Next
                Next
            Next
            Threading.Thread.Sleep(300)
            cuadro.lbMsgEspera.Text = "Agregando el ancho de las columnas a las hojas..."

            'Dim anchoEntrada() As Integer = {36, 7, 64, 29, 22, 12, 13, 2}
            'Dim anchoSalida() As Integer = {36, 7, 64, 29, 22, 12, 13, 2}

            For i As Integer = 0 To anchoEntrada.Length - 1
                hojaEntrada.Cells(1, i + 1).ColumnWidth = anchoEntrada(i)
                hojaSalida.Cells(1, i + 1).ColumnWidth = anchoSalida(i)
            Next

            Threading.Thread.Sleep(300)

            cuadro.lbMsgEspera.Text = "Agregando filtros a la primera fila..."

            'Dim rango As Excel.Range = hojaSalida.Range("A1", "G1")
            rango = hojaSalida.Range("A1", "G1")
            rango.AutoFilter(Field:=1)

            rango = hojaEntrada.Range("A1", "G1")
            rango.AutoFilter(Field:=1)

            Threading.Thread.Sleep(300)
            cuadro.lbMsgEspera.Text = "Agregando colores a la primera fila..."

            'Dim filaSalida As Microsoft.Office.Interop.Excel.Range = hojaSalida.Range("A1", "G1")
            filaSalida = hojaSalida.Range("A1", "G1")
            filaSalida.Interior.Color = RGB(169, 208, 142)

            'Dim filaEntrada As Microsoft.Office.Interop.Excel.Range = hojaEntrada.Range("A1", "G1")
            filaEntrada = hojaEntrada.Range("A1", "G1")
            filaEntrada.Interior.Color = RGB(169, 208, 142)

            Threading.Thread.Sleep(300)
            cuadro.lbMsgEspera.Text = "Agregando bordes a las celdas de las hojas..."

            'Dim dataRangeEntrada As String = $"A1: {Convert.ToChar(dgvEntrada.Columns.Count + 64)}{dgvEntrada.Rows.Count + 1}"
            'Dim dataRangeSalida As String = $"A1:{Convert.ToChar(dgvSalida.Columns.Count + 64)}{dgvSalida.Rows.Count + 1}"
            dataRangeEntrada = $"A1: {Convert.ToChar(dgvEntrada.Columns.Count + 64)}{dgvEntrada.Rows.Count + 1}"
            dataRangeSalida = $"A1:{Convert.ToChar(dgvSalida.Columns.Count + 64)}{dgvSalida.Rows.Count + 1}"
            hojaEntrada.Range(dataRangeEntrada).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            hojaSalida.Range(dataRangeSalida).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

            Threading.Thread.Sleep(300)
            cuadro.lbMsgEspera.Text = "Agregando una fuente adecuada a las celdas..."

            hojaEntrada.Range(dataRangeEntrada).Cells.Font.Name = "Calibri"
            hojaSalida.Range(dataRangeSalida).Cells.Font.Name = "Calibri"

            hojaEntrada.Range(dataRangeEntrada).Cells.Font.Size = 12
            hojaSalida.Range(dataRangeSalida).Cells.Font.Size = 12

            hojaEntrada.Range(dataRangeEntrada).Cells.Font.Bold = True
            hojaSalida.Range(dataRangeSalida).Cells.Font.Bold = True

            cuadro.lbMsgEspera.Text = "Creando el archivo de excel para guardarlo..."
            Threading.Thread.Sleep(300)

            'Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Archivo de Excel (.xlsx)|.xlsx"
            saveFileDialog1.Title = "Guardar archivo de Excel"
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                'Dim hojaEliminar As Microsoft.Office.Interop.Excel.Worksheet = Nothing
                hojaEliminar = Nothing
                For Each hoja As Microsoft.Office.Interop.Excel.Worksheet In libro.Worksheets
                    If hoja.Name = "Hoja1" Then
                        hojaEliminar = hoja
                        Exit For
                    End If
                Next
                hojaEliminar.Delete()
                libro.SaveAs(saveFileDialog1.FileName)
                vExporto = True
                cuadro.lbMsgEspera.Text = "Arcivo de excel creado y guardado exitosamente."
                Threading.Thread.Sleep(1000)
            Else
                MessageBox.Show("El archivo no fue guardado.")
            End If
            cuadro.Close()

        Catch ex As Exception
            BdMsgError = ex.Message
        Finally

            excel.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel)
            excel = Nothing
            GC.Collect()
        End Try
        Return vExporto
    End Function

    Public Shared Function AgregarTemp(opcion As Integer, nombre As String, area As String, direccion As String, telefono As String, ruta As String, conductor As String, novedades As String)
        Dim bd As New BaseDeDato()
        Dim vNumReg As Integer
        Dim vCreo As Boolean = False
        Dim vSql As String
        If opcion = 1 Then
            vSql = "INSERT INTO Entradas ([Nombre], [Area], [Direccion], [Telefono], [Ruta], [Conductor], [Novedades]) VALUES (@nombre, @area, @direccion, @telefono, @ruta, @conductor, @novedades)"
        Else
            vSql = "INSERT INTO Salidas ([Nombre], [Area], [Direccion], [Telefono], [Ruta], [Conductor], [Novedades]) VALUES (@nombre, @area, @direccion, @telefono, @ruta, @conductor, @novedades)"
        End If

        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@nombre", OleDbType.VarChar, nombre)
        bd.AsignarParametro("@area", OleDbType.VarChar, area)
        bd.AsignarParametro("@direccion", OleDbType.VarChar, direccion)
        bd.AsignarParametro("@telefono", OleDbType.VarChar, telefono)
        bd.AsignarParametro("@ruta", OleDbType.VarChar, ruta)
        bd.AsignarParametro("@conductor", OleDbType.VarChar, conductor)
        bd.AsignarParametro("@novedades", OleDbType.VarChar, novedades)

        vNumReg = bd.EjecutarComando()
        bd.Desconectar()
        If (vNumReg > 0) Then
            vCreo = True
        End If
        Return vCreo
    End Function

    Public Shared Function EliminarDBTemp()
        Dim bd As New BaseDeDato()
        Dim vNumReg As Integer
        Dim vCreo1 As Boolean = False
        Dim vCreo2 As Boolean = False
        Dim vSql As String = "DELETE [Nombre], [Area], [Direccion], [Telefono], [Ruta], [Conductor], [Novedades] FROM Entradas"

        bd.Conectar()
        bd.CrearComando(vSql)

        vNumReg = bd.EjecutarComando()
        If (vNumReg > 0) Then
            vCreo1 = True
        End If
        vSql = "DELETE [Nombre], [Area], [Direccion], [Telefono], [Ruta], [Conductor], [Novedades] FROM Salidas"
        bd.CrearComando(vSql)
        vNumReg = bd.EjecutarComando()
        If (vNumReg > 0) Then
            vCreo2 = True
        End If
        bd.Desconectar()
        If vCreo1 AndAlso vCreo2 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function EliminarTemp(opcion As Integer, nombre As String, area As String, direccion As String)
        Dim vNumReg As Integer
        Dim bd As New BaseDeDato()
        Dim vCreo As Boolean = False
        Dim vSql As String

        If opcion = 1 Then
            vSql = "DELETE FROM Entradas WHERE [Nombre]=@Nombre and [Area] = @Area and [Direccion] = @Direccion"
        Else
            vSql = "DELETE FROM Salidas WHERE [Nombre]=@Nombre and [Area] = @Area and [Direccion] = @Direccion"
        End If

        bd.Conectar()
        bd.CrearComando(vSql)
        bd.AsignarParametro("@Nombre", OleDbType.VarChar, nombre)
        bd.AsignarParametro("@Area", OleDbType.VarChar, area)
        bd.AsignarParametro("@Direccion", OleDbType.VarChar, direccion)

        vNumReg = bd.EjecutarComando()
        bd.Desconectar()
        If (vNumReg > 0) Then
            vCreo = True
        End If
        Return vCreo
    End Function
End Class
