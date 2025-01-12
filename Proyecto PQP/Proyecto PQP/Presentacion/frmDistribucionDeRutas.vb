Imports ReglaDeNegocio
Imports System.Windows.Forms
Public Class frmDistribucionDeRutas
    Dim cargo As Boolean = False
    Dim UltimaOpcion As Integer = -1
    Private Sub frmDistribucionDeRutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DistribucionDeRutas.CargarComboConductor(cbConductor)
        DistribucionDeRutas.CargarComboFiltro(cbFiltrar1)
        DistribucionDeRutas.CargarComboFiltro(cbFiltrar2)
        DistribucionDeRutas.CargarComboFiltro(cbFiltrar3)
        DistribucionDeRutas.CargarGrilla(dgvEmpleados)
        DistribucionDeRutas.CargarGrillaTemp(0, dgvSalida)
        DistribucionDeRutas.CargarGrillaTemp(1, dgvEntrada)
        cbConductor.SelectedIndex = -1
        cargo = True
    End Sub

    Private Sub cbFiltrar1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltrar1.SelectedIndexChanged
        If cargo Then
            DistribucionDeRutas.CargarGrillaFiltro(dgvEmpleados, cbFiltrar1.SelectedValue.ToString())
        End If
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
        cargo = False
    End Sub

    Private Sub dgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        If e.RowIndex >= 0 Then
            dgvEmpleados.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub dgvEmpleados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellDoubleClick
        If txtNovedades.Text.Trim = "" Or cbConductor.SelectedIndex = -1 Then
            MessageBox.Show("Digite todos los campos")
            Return
        End If

        Dim opciones As New Opciones(UltimaOpcion)
        Dim resultado = opciones.ShowDialog()
        If resultado = DialogResult.OK Then
            opciones.Close()

            Dim nombre As String = dgvEmpleados.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim area As String = dgvEmpleados.Rows(e.RowIndex).Cells("Area").Value.ToString()
            Dim direccion As String = dgvEmpleados.Rows(e.RowIndex).Cells("Direccion").Value.ToString()
            Dim telefono As String = dgvEmpleados.Rows(e.RowIndex).Cells("Telefono").Value.ToString()
            Dim ruta As String = dgvEmpleados.Rows(e.RowIndex).Cells("Ruta").Value.ToString()
            Dim novedades As String = txtNovedades.Text
            Dim conductor As String = ""
            If (cbConductor.SelectedIndex <> -1) Then
                conductor = cbConductor.SelectedValue.ToString()
            End If

            If (Not (DistribucionDeRutas.validarIngreso(1, telefono, nombre, area, direccion))) Then
                If DistribucionDeRutas.AgregarTemp(1, nombre, area, direccion, telefono, ruta, conductor, novedades) Then
                    'DistribucionDeRutas.CargarGrillaTemp(1, dgvEntrada)
                    DistribucionDeRutas.CargarGrillaTempFiltro(1, dgvEntrada, cbFiltrar2.SelectedValue.ToString())
                    dgvEntrada.CurrentCell = dgvEntrada.Rows(dgvEntrada.Rows.Count - 1).Cells(0)
                    UltimaOpcion = 1
                Else
                    MessageBox.Show("No se agrego al empleado.")
                End If
            Else
                MessageBox.Show("El empleado ya esta ingresado.")
            End If
        ElseIf resultado = DialogResult.Cancel Then
            opciones.Close()

            Dim nombre As String = dgvEmpleados.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim area As String = dgvEmpleados.Rows(e.RowIndex).Cells("Area").Value.ToString()
            Dim direccion As String = dgvEmpleados.Rows(e.RowIndex).Cells("Direccion").Value.ToString()
            Dim telefono As String = dgvEmpleados.Rows(e.RowIndex).Cells("Telefono").Value.ToString()
            Dim ruta As String = dgvEmpleados.Rows(e.RowIndex).Cells("Ruta").Value.ToString()
            Dim novedades As String = txtNovedades.Text
            Dim conductor As String = ""
            If (cbConductor.SelectedIndex <> -1) Then
                Conductor = cbConductor.SelectedValue.ToString()
            End If

            If (Not (DistribucionDeRutas.validarIngreso(0, telefono, nombre, area, direccion))) Then
                If DistribucionDeRutas.AgregarTemp(0, nombre, area, direccion, telefono, ruta, conductor, novedades) Then
                    'DistribucionDeRutas.CargarGrillaTemp(0, dgvSalida)
                    DistribucionDeRutas.CargarGrillaTempFiltro(0, dgvSalida, cbFiltrar3.SelectedValue.ToString())
                    dgvSalida.CurrentCell = dgvSalida.Rows(dgvSalida.Rows.Count - 1).Cells(0)
                    UltimaOpcion = 0
                Else
                    MessageBox.Show("No se agrego al empleado.")
                End If
            Else
                MessageBox.Show("El empleado ya esta ingresado.")
            End If
        End If
    End Sub

    Private Sub dgvEntrada_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntrada.CellDoubleClick
        If (e.RowIndex >= 0 AndAlso dgvEntrada.Rows.Count <> e.RowIndex) Then
            Dim nombre As String = dgvEntrada.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim area As String = dgvEntrada.Rows(e.RowIndex).Cells("Area").Value.ToString()
            Dim direccion As String = dgvEntrada.Rows(e.RowIndex).Cells("Direccion").Value.ToString()

            DistribucionDeRutas.EliminarTemp(1, nombre, area, direccion)
            DistribucionDeRutas.CargarGrillaTempFiltro(1, dgvEntrada, cbFiltrar2.SelectedValue.ToString())
            If dgvEntrada.Rows.Count > 0 Then
                dgvEntrada.CurrentCell = dgvEntrada.Rows(dgvEntrada.Rows.Count - 1).Cells(0)
            End If
        End If
    End Sub

    Private Sub dgvSalida_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalida.CellDoubleClick
        If (e.RowIndex >= 0 AndAlso dgvSalida.Rows.Count <> e.RowIndex) Then
            Dim nombre As String = dgvSalida.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Dim area As String = dgvSalida.Rows(e.RowIndex).Cells("Area").Value.ToString()
            Dim direccion As String = dgvSalida.Rows(e.RowIndex).Cells("Direccion").Value.ToString()

            DistribucionDeRutas.EliminarTemp(0, nombre, area, direccion)
            DistribucionDeRutas.CargarGrillaTempFiltro(0, dgvSalida, cbFiltrar3.SelectedValue.ToString())
            If dgvSalida.Rows.Count > 0 Then
                dgvSalida.CurrentCell = dgvSalida.Rows(dgvSalida.Rows.Count - 1).Cells(0)
            End If
        End If
    End Sub

    Private Sub cbFiltrar3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltrar3.SelectedIndexChanged
        If cargo Then
            DistribucionDeRutas.CargarGrillaTempFiltro(0, dgvSalida, cbFiltrar3.SelectedValue.ToString())
        End If
    End Sub

    Private Sub cbFiltrar2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltrar2.SelectedIndexChanged
        If cargo Then
            DistribucionDeRutas.CargarGrillaTempFiltro(1, dgvEntrada, cbFiltrar2.SelectedValue.ToString())
        End If
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim dr As New DistribucionDeRutas
        dr.Exportar(dgvEntrada, dgvSalida)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim respuesta As Integer
        respuesta = MsgBox("¿Estas seguro que quieres eliminar las rutas creadas previamente?", vbYesNo)
        If respuesta = vbYes Then
            cargo = False
            DistribucionDeRutas.EliminarDBTemp()
            DistribucionDeRutas.CargarGrilla(dgvEmpleados)
            DistribucionDeRutas.CargarGrillaTemp(0, dgvSalida)
            DistribucionDeRutas.CargarGrillaTemp(1, dgvEntrada)
            cbConductor.SelectedIndex = -1
            cbFiltrar1.SelectedIndex = 0
            cbFiltrar2.SelectedIndex = 0
            cbFiltrar3.SelectedIndex = 0
            txtNovedades.Text = Nothing
            cargo = True
            MessageBox.Show("Datos de las rutas temporales borrados de forma correcta.")
        Else
            MessageBox.Show("No se eliminaron los datos.")
        End If
    End Sub
End Class