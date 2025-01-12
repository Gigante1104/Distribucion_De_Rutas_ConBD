Public Class Opciones
    Dim UltimaOpcion As Integer = -1
    Public Sub New(ByVal opcion As Integer)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        UltimaOpcion = opcion
    End Sub
    Private Sub Opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UltimaOpcion = 1 Then
            btEntrada.TabIndex() = 0
        ElseIf UltimaOpcion = 0 Then
            btSalida.TabIndex = 0
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btEntrada.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btSalida.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class