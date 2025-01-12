Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ReglaDeNegocio

Public Class frmEmpleados
    Public cargo As Boolean = False
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Empleados.CargarGrilla(dgvEmpleados)
        Area.CargarCombo(cbArea)
        Area.CargarComboFiltro(cbFiltrar)
        Ruta.CargarCombo(cbRuta)
        cbRuta.SelectedIndex = -1
        cbArea.SelectedIndex = -1
        cargo = True
    End Sub
    Private Function Validar() As Boolean
        Dim valido As Boolean = False
        If txtNombre.Text.Trim = "" Then
            MessageBox.Show("El nombre es un campo obligatorio.")
            txtNombre.Focus()
        ElseIf txtDireccion.Text.Trim = "" Then
            MessageBox.Show("La dirección es un campo obligatorio.")
            txtDireccion.Focus()
        ElseIf cbArea.SelectedIndex = -1 Then
            MessageBox.Show("El area es un campo obligatorio.")
            cbArea.Focus()
        ElseIf cbRuta.SelectedIndex = -1 Then
            MessageBox.Show("La ruta es un campo obligatorio.")
            cbRuta.Focus()
        Else
            valido = True
        End If
        Return valido
    End Function
    Private Sub Limpiar()
        txtNombre.Text = Nothing
        txtTelefono.Text = Nothing
        txtDireccion.Text = Nothing
        cbArea.SelectedIndex = -1
        cbRuta.SelectedIndex = -1
    End Sub
    Private Sub btLimpiar_Click(sender As Object, e As EventArgs) Handles btLimpiar.Click
        Limpiar()
    End Sub
    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        If Validar() Then
            Dim empleado As New Empleados
            If (Not (empleado.validarEmpleadoDuplicado(txtNombre.Text, txtDireccion.Text, cbArea.SelectedValue))) Then
                If empleado.Crear(txtNombre.Text, txtDireccion.Text, cbArea.SelectedValue, txtTelefono.Text, cbRuta.SelectedValue) Then
                    MessageBox.Show("Se creó el empleado satisfactoriamente.")
                    Empleados.CargarGrillaFiltro(dgvEmpleados, cbFiltrar.SelectedValue.ToString())
                    posicionarFila()
                    Limpiar()
                Else
                    If empleado.ValidarDuplicado(txtTelefono.Text) Then
                        MessageBox.Show("El número de teléfono ya se encuentra registrado.")
                    ElseIf empleado.BdCodeError <> 0 Then
                        MessageBox.Show(empleado.BdMsgError)
                    Else
                        MessageBox.Show("No se creó el cliente.")
                    End If
                End If
            Else
                MessageBox.Show("Ese empleado y sus datos, ya se encuentran registrados.")
            End If
        End If
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        If txtTelefono.Text.Trim <> "" Then
            Dim empleado As New Empleados
            If empleado.ConsultarPorTel(txtTelefono.Text) Then
                txtNombre.Text = empleado.Nombre
                seleccionarComboArea(empleado.Area)
                seleccionarComboRuta(empleado.Ruta)
                txtTelefono.Text = empleado.Telefono
                txtDireccion.Text = empleado.Direccion
                posicionarFila()
            Else
                MessageBox.Show("No se encontró al empleado.")
            End If
        Else
            MessageBox.Show("Digite el número de telefono.")
        End If

    End Sub

    Private Sub Consultar(e As DataGridViewCellEventArgs)
        'Parece que no se usa. Se remplazo por buscar por celdas en la tabla porque esta se carga al iniciar el formulario.
        Dim empleado As New Empleados
        If empleado.Consultar(txtNombre.Text, cbArea.SelectedValue(), txtTelefono.Text) Then
            txtDireccion.Text = empleado.Direccion
            seleccionarComboRuta(empleado.Ruta.ToString())
        Else
            If empleado.BdCodeError <> 0 Then
                MessageBox.Show(empleado.BdMsgError)
            Else
                MessageBox.Show("No se encontró el empleado.")
                Limpiar()
            End If
        End If
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        If Validar() Then
            'La idea es que del form tome los valores de la P.K. y de los input los nuevos valores.
            Dim empleado As New Empleados
            Dim Nombre, Area, Direccion As String
            empleado.Nombre = txtNombre.Text
            empleado.Area = cbArea.SelectedValue
            empleado.Direccion = txtDireccion.Text
            Nombre = InputBox("Introduzca el nombre: ", "Valor Nuevo.", txtNombre.Text)
            Area = InputBox("Introduzca el area: ", "Valor Nuevo.", cbArea.SelectedValue)
            Direccion = InputBox("Introduzca la dirección: ", "Valor Nuevo.", txtDireccion.Text)
            If empleado.Actualizar(Nombre, Area, Direccion, txtTelefono.Text, cbRuta.SelectedValue) Then
                MessageBox.Show("Se actualizó al empleado satisfactoriamente.")
                Empleados.CargarGrillaFiltro(dgvEmpleados, cbFiltrar.SelectedValue.ToString())
                posicionarFilaActualizar(Nombre, Area, Direccion)
                Limpiar()
            Else
                If empleado.BdCodeError <> 0 Then
                    MessageBox.Show(empleado.BdMsgError)
                Else
                    MessageBox.Show("No se actualizó el cliente.")
                End If
            End If
        End If
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If txtNombre.Text.Trim = "" Then
            MessageBox.Show("Falta el nombre del empleado a eliminar.")
        ElseIf cbArea.SelectedIndex = -1 Then
            MessageBox.Show("Falta el area del empleado a eliminar.")
        ElseIf txtDireccion.Text.Trim = "" Then
            MessageBox.Show("Falta la dirección del empleado a eliminar.")
        Else
            Dim empleado As New Empleados
            If empleado.Eliminar(txtNombre.Text, cbArea.SelectedValue, txtDireccion.Text) Then
                MessageBox.Show("Se eliminó al empleado satisfactoriamente.")
                txtTelefono.Text = Nothing
                Empleados.CargarGrillaFiltro(dgvEmpleados, cbFiltrar.SelectedValue.ToString())
                Limpiar()
            Else
                If empleado.BdCodeError <> 0 Then
                    MessageBox.Show(empleado.BdMsgError)
                Else
                    MessageBox.Show("No se elimino al empleado.")
                End If
            End If
        End If
    End Sub

    Private Sub btSAlir_Click(sender As Object, e As EventArgs) Handles btSAlir.Click
        Me.Close()
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        If e.RowIndex >= 0 Then
            dgvEmpleados.Rows(e.RowIndex).Selected = True
        End If
        If (e.RowIndex >= 0 AndAlso dgvEmpleados.Rows.Count <> e.RowIndex) Then
            txtNombre.Text = dgvEmpleados.Rows(e.RowIndex).Cells(0).Value.ToString()
            seleccionarComboArea(dgvEmpleados.Rows(e.RowIndex).Cells(1).Value.ToString())
            txtDireccion.Text = dgvEmpleados.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtTelefono.Text = dgvEmpleados.Rows(e.RowIndex).Cells(3).Value.ToString()
            seleccionarComboRuta(dgvEmpleados.Rows(e.RowIndex).Cells(4).Value.ToString())
            'Consultar(e)
        End If

    End Sub

    Private Sub cbFiltrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltrar.SelectedIndexChanged
        If cargo Then
            Empleados.CargarGrillaFiltro(dgvEmpleados, cbFiltrar.SelectedValue.ToString())
        End If
    End Sub
    Private Sub seleccionarComboRuta(comparar As String)
        Dim seleccion As Integer = -1
        For i As Integer = 0 To cbRuta.Items.Count() Step 1
            If i < cbRuta.Items.Count Then
                cbRuta.SelectedIndex = i
            End If
            If cbRuta.SelectedValue = comparar Then
                seleccion = i
                Exit For
            End If
        Next
        cbRuta.SelectedIndex = seleccion
    End Sub

    Private Sub seleccionarComboArea(comparar As String)
        Dim seleccion As Integer = -1
        For i As Integer = 0 To cbArea.Items.Count() Step 1
            If i < cbArea.Items.Count Then
                cbArea.SelectedIndex = i
            End If
            If cbArea.SelectedValue = comparar Then
                seleccion = i
                Exit For
            End If
        Next
        cbArea.SelectedIndex = seleccion
    End Sub
    Private Sub posicionarFila()
        Dim nombre As String = txtNombre.Text
        Dim area As String = cbArea.SelectedValue
        Dim direccion As String = txtDireccion.Text
        For Each fila As DataGridViewRow In dgvEmpleados.Rows
            If (fila.Cells("Nombre").Value IsNot Nothing AndAlso fila.Cells("Nombre").Value.ToString() = nombre) And
                (fila.Cells("Area").Value IsNot Nothing AndAlso fila.Cells("Area").Value.ToString() = area) And
                (fila.Cells("Direccion").Value IsNot Nothing AndAlso fila.Cells("Direccion").Value.ToString() = direccion) Then
                fila.Selected = True
                dgvEmpleados.FirstDisplayedScrollingRowIndex = dgvEmpleados.SelectedRows(0).Index
                Exit For
            End If
        Next
    End Sub
    Private Sub posicionarFilaActualizar(pNombre As String, pArea As String, pDireccion As String)
        Dim nombre As String = pNombre
        Dim area As String = pArea
        Dim direccion As String = pDireccion
        For Each fila As DataGridViewRow In dgvEmpleados.Rows
            If (fila.Cells("Nombre").Value IsNot Nothing AndAlso fila.Cells("Nombre").Value.ToString() = nombre) And
                (fila.Cells("Area").Value IsNot Nothing AndAlso fila.Cells("Area").Value.ToString() = area) And
                (fila.Cells("Direccion").Value IsNot Nothing AndAlso fila.Cells("Direccion").Value.ToString() = direccion) Then
                fila.Selected = True
                dgvEmpleados.FirstDisplayedScrollingRowIndex = dgvEmpleados.SelectedRows(0).Index
                Exit For
            End If
        Next
    End Sub
End Class