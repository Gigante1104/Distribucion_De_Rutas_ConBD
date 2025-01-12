Imports System.Windows.Forms.MonthCalendar
Imports ReglaDeNegocio
Public Class frmRuta
    Private Sub frmRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ruta.CargarGrilla(dgvRuta)
    End Sub
    Private Sub Limpiar()
        txtRuta.Text = Nothing
    End Sub

    Private Function Validar() As Boolean
        If txtRuta.Text.Trim = "" Then
            MessageBox.Show("Digite el nombre de la ruta.")
            txtRuta.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        If Validar() Then
            Dim ruta As New Ruta
            If ruta.Crear(txtRuta.Text) Then
                MessageBox.Show("Se agregó la ruta.")
                Ruta.CargarGrilla(dgvRuta)
                Limpiar()
            End If
        End If
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If txtRuta.Text.Trim = "" Then
            MessageBox.Show("Digite la ruta para eliminar")
        Else
            Dim ruta As New Ruta
            If ruta.Eliminar(txtRuta.Text) Then
                MessageBox.Show("Se eliminó la ruta")
                Ruta.CargarGrilla(dgvRuta)
                Limpiar()
            Else
                MessageBox.Show("No se eliminó la ruta")
            End If
        End If
    End Sub

    Private Sub btSAlir_Click(sender As Object, e As EventArgs) Handles btSAlir.Click
        Me.Close()
    End Sub

    Private Sub dgvRuta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRuta.CellClick
        If (e.RowIndex >= 0 AndAlso dgvRuta.Rows.Count <> e.RowIndex) Then
            txtRuta.Text = dgvRuta.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub
End Class