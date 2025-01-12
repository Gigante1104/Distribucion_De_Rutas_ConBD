<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CuadroDeEspera
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbMsgEspera = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbMsgEspera
        '
        Me.lbMsgEspera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMsgEspera.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMsgEspera.Location = New System.Drawing.Point(0, 0)
        Me.lbMsgEspera.Name = "lbMsgEspera"
        Me.lbMsgEspera.Size = New System.Drawing.Size(473, 168)
        Me.lbMsgEspera.TabIndex = 0
        Me.lbMsgEspera.Text = ",,,,"
        Me.lbMsgEspera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CuadroDeEspera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 168)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbMsgEspera)
        Me.Name = "CuadroDeEspera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CuadroDeEspera"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbMsgEspera As Windows.Forms.Label
End Class
