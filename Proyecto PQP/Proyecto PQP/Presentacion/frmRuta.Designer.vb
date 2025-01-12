<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRuta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvRuta = New System.Windows.Forms.DataGridView()
        Me.btSAlir = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.lbRuta = New System.Windows.Forms.Label()
        CType(Me.dgvRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRuta
        '
        Me.dgvRuta.AllowUserToAddRows = False
        Me.dgvRuta.AllowUserToDeleteRows = False
        Me.dgvRuta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvRuta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRuta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRuta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRuta.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRuta.Location = New System.Drawing.Point(421, 183)
        Me.dgvRuta.Name = "dgvRuta"
        Me.dgvRuta.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.dgvRuta.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRuta.Size = New System.Drawing.Size(885, 783)
        Me.dgvRuta.TabIndex = 24
        '
        'btSAlir
        '
        Me.btSAlir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSAlir.AutoSize = True
        Me.btSAlir.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btSAlir.Location = New System.Drawing.Point(983, 108)
        Me.btSAlir.Name = "btSAlir"
        Me.btSAlir.Size = New System.Drawing.Size(85, 52)
        Me.btSAlir.TabIndex = 23
        Me.btSAlir.Text = "Salir"
        Me.btSAlir.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRuta.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.txtRuta.Location = New System.Drawing.Point(671, 36)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(465, 48)
        Me.txtRuta.TabIndex = 25
        '
        'btAgregar
        '
        Me.btAgregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btAgregar.AutoSize = True
        Me.btAgregar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btAgregar.Location = New System.Drawing.Point(659, 108)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(131, 52)
        Me.btAgregar.TabIndex = 21
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btEliminar.AutoSize = True
        Me.btEliminar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btEliminar.Location = New System.Drawing.Point(819, 108)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(131, 52)
        Me.btEliminar.TabIndex = 22
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'lbRuta
        '
        Me.lbRuta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbRuta.AutoSize = True
        Me.lbRuta.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.lbRuta.Location = New System.Drawing.Point(571, 42)
        Me.lbRuta.Name = "lbRuta"
        Me.lbRuta.Size = New System.Drawing.Size(79, 42)
        Me.lbRuta.TabIndex = 26
        Me.lbRuta.Text = "Ruta"
        '
        'frmRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1723, 1038)
        Me.Controls.Add(Me.dgvRuta)
        Me.Controls.Add(Me.btSAlir)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.lbRuta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRuta"
        Me.Text = "frmRuta"
        CType(Me.dgvRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRuta As DataGridView
    Friend WithEvents btSAlir As Button
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents btAgregar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents lbRuta As Label
End Class
