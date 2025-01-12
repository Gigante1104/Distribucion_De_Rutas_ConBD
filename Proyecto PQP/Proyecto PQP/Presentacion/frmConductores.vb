Imports ReglaDeNegocio

Public Class frmConductores
    Private Sub Cargar()
        Conductor.CargarGrilla(dgvConductores)
    End Sub

    Private Sub frmConductores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub Limpiar()
        txtConductores.Text = Nothing
    End Sub

    Private Sub btSAlir_Click_1(sender As Object, e As EventArgs) Handles btSAlir.Click
        Me.Close()
    End Sub

    Private Sub btAgregar_Click_1(sender As Object, e As EventArgs) Handles btAgregar.Click
        Dim conductor As New Conductor
        If conductor.Crear(txtConductores.Text) Then
            MessageBox.Show("Se creó el conductor satisfactoriamente")
            Conductor.CargarGrilla(dgvConductores)
            Limpiar()
        End If
    End Sub

    Private Sub btEliminar_Click_1(sender As Object, e As EventArgs) Handles btEliminar.Click
        If txtConductores.Text.Trim = "" Then
            MessageBox.Show("Falta el conductor a eliminar")
        Else
            Dim conductor As New Conductor
            If conductor.Eliminar(txtConductores.Text) Then
                MessageBox.Show("Se eliminó el conductor satisfactoriamente")
                txtConductores.Text = Nothing
                Conductor.CargarGrilla(dgvConductores)
                Limpiar()
            Else
                MessageBox.Show("No se encontró el conductor")

            End If
        End If
    End Sub

    Private Sub dgvConductores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConductores.CellClick
        If (e.RowIndex >= 0 AndAlso dgvConductores.Rows.Count <> e.RowIndex) Then
            txtConductores.Text = dgvConductores.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub
End Class