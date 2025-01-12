Imports ReglaDeNegocio

Public Class frmArea
    Private Sub frmArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Area.CargarGrilla(dgvArea)
    End Sub
    Private Sub Limpiar()
        txtArea.Text = Nothing
    End Sub

    Private Function Validar() As Boolean
        If txtArea.Text.Trim = "" Then
            MessageBox.Show("Digite el nombre del Area")
            txtArea.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        If Validar() Then
            Dim area As New Area
            If area.Crear(txtArea.Text) Then
                MessageBox.Show("Se agregó el area")
                Area.CargarGrilla(dgvArea)
                Limpiar()
            End If
        End If
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If txtArea.Text.Trim = "" Then
            MessageBox.Show("Digite el area para eliminar")
        Else
            Dim area As New Area
            If area.Eliminar(txtArea.Text) Then
                MessageBox.Show("Se eliminó el area")
                Area.CargarGrilla(dgvArea)
                Limpiar()
            End If
        End If
    End Sub

    Private Sub btSAlir_Click(sender As Object, e As EventArgs) Handles btSAlir.Click
        Me.Close()
    End Sub

    Private Sub dgvArea_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArea.CellClick
        If (e.RowIndex >= 0 AndAlso dgvArea.Rows.Count <> e.RowIndex) Then
            txtArea.Text = dgvArea.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

End Class