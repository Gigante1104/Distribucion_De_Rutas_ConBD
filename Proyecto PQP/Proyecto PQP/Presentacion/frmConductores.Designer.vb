<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConductores
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
        Me.dgvConductores = New System.Windows.Forms.DataGridView()
        Me.btSAlir = New System.Windows.Forms.Button()
        Me.txtConductores = New System.Windows.Forms.TextBox()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.lbConductores = New System.Windows.Forms.Label()
        CType(Me.dgvConductores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConductores
        '
        Me.dgvConductores.AllowUserToAddRows = False
        Me.dgvConductores.AllowUserToDeleteRows = False
        Me.dgvConductores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvConductores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConductores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConductores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConductores.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvConductores.Location = New System.Drawing.Point(359, 218)
        Me.dgvConductores.Name = "dgvConductores"
        Me.dgvConductores.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.dgvConductores.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvConductores.Size = New System.Drawing.Size(1037, 777)
        Me.dgvConductores.TabIndex = 25
        '
        'btSAlir
        '
        Me.btSAlir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSAlir.AutoSize = True
        Me.btSAlir.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btSAlir.Location = New System.Drawing.Point(999, 138)
        Me.btSAlir.Name = "btSAlir"
        Me.btSAlir.Size = New System.Drawing.Size(85, 52)
        Me.btSAlir.TabIndex = 24
        Me.btSAlir.Text = "Salir"
        Me.btSAlir.UseVisualStyleBackColor = True
        '
        'txtConductores
        '
        Me.txtConductores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtConductores.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.txtConductores.Location = New System.Drawing.Point(722, 66)
        Me.txtConductores.Name = "txtConductores"
        Me.txtConductores.Size = New System.Drawing.Size(452, 48)
        Me.txtConductores.TabIndex = 26
        '
        'btAgregar
        '
        Me.btAgregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btAgregar.AutoSize = True
        Me.btAgregar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btAgregar.Location = New System.Drawing.Point(681, 138)
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
        Me.btEliminar.Location = New System.Drawing.Point(840, 138)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(131, 52)
        Me.btEliminar.TabIndex = 23
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'lbConductores
        '
        Me.lbConductores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbConductores.AutoSize = True
        Me.lbConductores.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.lbConductores.Location = New System.Drawing.Point(544, 69)
        Me.lbConductores.Name = "lbConductores"
        Me.lbConductores.Size = New System.Drawing.Size(151, 42)
        Me.lbConductores.TabIndex = 27
        Me.lbConductores.Text = "Conductor"
        '
        'frmConductores
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1723, 1038)
        Me.Controls.Add(Me.dgvConductores)
        Me.Controls.Add(Me.btSAlir)
        Me.Controls.Add(Me.txtConductores)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.lbConductores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConductores"
        Me.Text = "frmConductores"
        CType(Me.dgvConductores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvConductores As DataGridView
    Friend WithEvents btSAlir As Button
    Friend WithEvents txtConductores As TextBox
    Friend WithEvents btAgregar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents lbConductores As Label
End Class
