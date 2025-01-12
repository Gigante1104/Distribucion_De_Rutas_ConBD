Imports System.Windows.Forms
Imports ReglaDeNegocio

Public Class frmAdmin
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = Screen.PrimaryScreen.Bounds.Size
        Me.MaximumSize = Screen.PrimaryScreen.Bounds.Size
        panelContenedor.Dock = DockStyle.Fill

        btArea.FlatStyle = FlatStyle.Flat
        btConductores.FlatStyle = FlatStyle.Flat
        btDistribucion.FlatStyle = FlatStyle.Flat
        btEmpleados.FlatStyle = FlatStyle.Flat
        btRuta.FlatStyle = FlatStyle.Flat
        btSalir.FlatStyle = FlatStyle.Flat

        btArea.FlatAppearance.BorderSize = 0
        btConductores.FlatAppearance.BorderSize = 0
        btDistribucion.FlatAppearance.BorderSize = 0
        btEmpleados.FlatAppearance.BorderSize = 0
        btRuta.FlatAppearance.BorderSize = 0
        btSalir.FlatAppearance.BorderSize = 0

    End Sub

    Private Sub AbrirFormHijo(ByVal formulario As Form)
        If (panelContenedor.Controls.Count > 0) Then
            Me.panelContenedor.Controls.RemoveAt(0)
        End If

        formulario.Dock = DockStyle.Fill
        formulario.StartPosition = FormStartPosition.Manual
        formulario.Size = panelContenedor.Size
        formulario.TopLevel = False
        formulario.Parent = panelContenedor
        formulario.Visible = True
    End Sub
    Private Sub btArea_Click(sender As Object, e As EventArgs) Handles btArea.Click
        AbrirFormHijo(frmArea)
    End Sub
    Private Sub btConductores_Click(sender As Object, e As EventArgs) Handles btConductores.Click
        AbrirFormHijo(frmConductores)
    End Sub
    Private Sub btDistribucion_Click(sender As Object, e As EventArgs) Handles btDistribucion.Click
        AbrirFormHijo(frmDistribucionDeRutas)
    End Sub
    Private Sub btEmpleados_Click(sender As Object, e As EventArgs) Handles btEmpleados.Click
        AbrirFormHijo(frmEmpleados)
    End Sub
    Private Sub btRuta_Click(sender As Object, e As EventArgs) Handles btRuta.Click
        AbrirFormHijo(frmRuta)
    End Sub
    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Application.Exit()
    End Sub
    Private Sub frmAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class