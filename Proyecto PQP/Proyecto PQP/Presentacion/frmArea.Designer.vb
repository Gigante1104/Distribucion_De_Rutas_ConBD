<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArea
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbArea = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btSAlir = New System.Windows.Forms.Button()
        Me.dgvArea = New System.Windows.Forms.DataGridView()
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbArea
        '
        Me.lbArea.AutoSize = True
        Me.lbArea.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbArea.Location = New System.Drawing.Point(600, 63)
        Me.lbArea.Name = "lbArea"
        Me.lbArea.Size = New System.Drawing.Size(79, 42)
        Me.lbArea.TabIndex = 20
        Me.lbArea.Text = "Area"
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.txtArea.Location = New System.Drawing.Point(690, 60)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(330, 48)
        Me.txtArea.TabIndex = 17
        '
        'btAgregar
        '
        Me.btAgregar.AutoSize = True
        Me.btAgregar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btAgregar.Location = New System.Drawing.Point(621, 122)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(131, 52)
        Me.btAgregar.TabIndex = 1
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.AutoSize = True
        Me.btEliminar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btEliminar.Location = New System.Drawing.Point(809, 122)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(131, 52)
        Me.btEliminar.TabIndex = 4
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btSAlir
        '
        Me.btSAlir.AutoSize = True
        Me.btSAlir.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btSAlir.Location = New System.Drawing.Point(990, 122)
        Me.btSAlir.Name = "btSAlir"
        Me.btSAlir.Size = New System.Drawing.Size(85, 52)
        Me.btSAlir.TabIndex = 5
        Me.btSAlir.Text = "Salir"
        Me.btSAlir.UseVisualStyleBackColor = True
        '
        'dgvArea
        '
        Me.dgvArea.AllowUserToAddRows = False
        Me.dgvArea.AllowUserToDeleteRows = False
        Me.dgvArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvArea.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArea.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvArea.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvArea.Location = New System.Drawing.Point(291, 201)
        Me.dgvArea.Name = "dgvArea"
        Me.dgvArea.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvArea.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvArea.Size = New System.Drawing.Size(1153, 740)
        Me.dgvArea.TabIndex = 13
        '
        'frmArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1723, 1038)
        Me.Controls.Add(Me.dgvArea)
        Me.Controls.Add(Me.btSAlir)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.lbArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmArea"
        Me.Text = "frmAutos"
        CType(Me.dgvArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbArea As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents btAgregar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btSAlir As Button
    Private WithEvents dgvArea As DataGridView
End Class
