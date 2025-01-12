<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btEntrada = New System.Windows.Forms.Button()
        Me.btSalida = New System.Windows.Forms.Button()
        Me.lbElija = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btEntrada
        '
        Me.btEntrada.Location = New System.Drawing.Point(12, 34)
        Me.btEntrada.Name = "btEntrada"
        Me.btEntrada.Size = New System.Drawing.Size(65, 30)
        Me.btEntrada.TabIndex = 0
        Me.btEntrada.Text = "Entrada"
        Me.btEntrada.UseVisualStyleBackColor = True
        '
        'btSalida
        '
        Me.btSalida.Location = New System.Drawing.Point(124, 34)
        Me.btSalida.Name = "btSalida"
        Me.btSalida.Size = New System.Drawing.Size(65, 30)
        Me.btSalida.TabIndex = 1
        Me.btSalida.Text = "Salida"
        Me.btSalida.UseVisualStyleBackColor = True
        '
        'lbElija
        '
        Me.lbElija.AutoSize = True
        Me.lbElija.Location = New System.Drawing.Point(67, 9)
        Me.lbElija.Name = "lbElija"
        Me.lbElija.Size = New System.Drawing.Size(63, 13)
        Me.lbElija.TabIndex = 2
        Me.lbElija.Text = "Elija la tabla"
        '
        'Opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 78)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbElija)
        Me.Controls.Add(Me.btSalida)
        Me.Controls.Add(Me.btEntrada)
        Me.Name = "Opciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btEntrada As Button
    Friend WithEvents btSalida As Button
    Friend WithEvents lbElija As Label
End Class
