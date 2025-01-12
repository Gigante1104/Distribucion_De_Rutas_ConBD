<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Me.lbArea = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btSAlir = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.lbFiltrar = New System.Windows.Forms.Label()
        Me.cbFiltrar = New System.Windows.Forms.ComboBox()
        Me.lbRuta = New System.Windows.Forms.Label()
        Me.cbRuta = New System.Windows.Forms.ComboBox()
        Me.btLimpiar = New System.Windows.Forms.Button()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbArea
        '
        Me.lbArea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbArea.AutoSize = True
        Me.lbArea.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.lbArea.Location = New System.Drawing.Point(265, 121)
        Me.lbArea.Name = "lbArea"
        Me.lbArea.Size = New System.Drawing.Size(79, 42)
        Me.lbArea.TabIndex = 39
        Me.lbArea.Text = "Area"
        '
        'txtTelefono
        '
        Me.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTelefono.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.txtTelefono.Location = New System.Drawing.Point(392, 200)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(324, 48)
        Me.txtTelefono.TabIndex = 36
        '
        'lbDireccion
        '
        Me.lbDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbDireccion.AutoSize = True
        Me.lbDireccion.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.lbDireccion.Location = New System.Drawing.Point(722, 206)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(137, 42)
        Me.lbDireccion.TabIndex = 35
        Me.lbDireccion.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDireccion.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.txtDireccion.Location = New System.Drawing.Point(865, 200)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(475, 48)
        Me.txtDireccion.TabIndex = 34
        '
        'lbNombre
        '
        Me.lbNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.lbNombre.Location = New System.Drawing.Point(265, 43)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(121, 42)
        Me.lbNombre.TabIndex = 33
        Me.lbNombre.Text = "Nombre"
        '
        'lbTelefono
        '
        Me.lbTelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.lbTelefono.Location = New System.Drawing.Point(265, 203)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(130, 42)
        Me.lbTelefono.TabIndex = 31
        Me.lbTelefono.Text = "Teléfono"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombre.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.txtNombre.Location = New System.Drawing.Point(392, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(887, 48)
        Me.txtNombre.TabIndex = 30
        '
        'btSAlir
        '
        Me.btSAlir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSAlir.AutoSize = True
        Me.btSAlir.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btSAlir.Location = New System.Drawing.Point(875, 314)
        Me.btSAlir.Name = "btSAlir"
        Me.btSAlir.Size = New System.Drawing.Size(85, 52)
        Me.btSAlir.TabIndex = 5
        Me.btSAlir.Text = "Salir"
        Me.btSAlir.UseVisualStyleBackColor = True
        '
        'btBuscar
        '
        Me.btBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btBuscar.AutoSize = True
        Me.btBuscar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btBuscar.Location = New System.Drawing.Point(506, 314)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(117, 52)
        Me.btBuscar.TabIndex = 2
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btEliminar.AutoSize = True
        Me.btEliminar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btEliminar.Location = New System.Drawing.Point(738, 314)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(131, 52)
        Me.btEliminar.TabIndex = 4
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btActualizar.AutoSize = True
        Me.btActualizar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btActualizar.Location = New System.Drawing.Point(629, 314)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(103, 52)
        Me.btActualizar.TabIndex = 3
        Me.btActualizar.Text = "Editar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpleados.Location = New System.Drawing.Point(150, 372)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmpleados.Size = New System.Drawing.Size(1326, 630)
        Me.dgvEmpleados.TabIndex = 28
        '
        'btAgregar
        '
        Me.btAgregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btAgregar.AutoSize = True
        Me.btAgregar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btAgregar.Location = New System.Drawing.Point(369, 314)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(131, 52)
        Me.btAgregar.TabIndex = 1
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'cbArea
        '
        Me.cbArea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbArea.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Location = New System.Drawing.Point(350, 118)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(366, 50)
        Me.cbArea.TabIndex = 40
        '
        'lbFiltrar
        '
        Me.lbFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbFiltrar.AutoSize = True
        Me.lbFiltrar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.lbFiltrar.Location = New System.Drawing.Point(966, 319)
        Me.lbFiltrar.Name = "lbFiltrar"
        Me.lbFiltrar.Size = New System.Drawing.Size(161, 42)
        Me.lbFiltrar.TabIndex = 41
        Me.lbFiltrar.Text = "Filtrar Area"
        '
        'cbFiltrar
        '
        Me.cbFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltrar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.cbFiltrar.FormattingEnabled = True
        Me.cbFiltrar.Location = New System.Drawing.Point(1133, 316)
        Me.cbFiltrar.Name = "cbFiltrar"
        Me.cbFiltrar.Size = New System.Drawing.Size(304, 50)
        Me.cbFiltrar.TabIndex = 42
        '
        'lbRuta
        '
        Me.lbRuta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbRuta.AutoSize = True
        Me.lbRuta.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.lbRuta.Location = New System.Drawing.Point(898, 121)
        Me.lbRuta.Name = "lbRuta"
        Me.lbRuta.Size = New System.Drawing.Size(79, 42)
        Me.lbRuta.TabIndex = 43
        Me.lbRuta.Text = "Ruta"
        '
        'cbRuta
        '
        Me.cbRuta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRuta.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.cbRuta.FormattingEnabled = True
        Me.cbRuta.Location = New System.Drawing.Point(999, 118)
        Me.cbRuta.Name = "cbRuta"
        Me.cbRuta.Size = New System.Drawing.Size(341, 50)
        Me.cbRuta.TabIndex = 44
        '
        'btLimpiar
        '
        Me.btLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btLimpiar.AutoSize = True
        Me.btLimpiar.Font = New System.Drawing.Font("Arial Narrow", 26.25!)
        Me.btLimpiar.Location = New System.Drawing.Point(232, 316)
        Me.btLimpiar.Name = "btLimpiar"
        Me.btLimpiar.Size = New System.Drawing.Size(131, 52)
        Me.btLimpiar.TabIndex = 45
        Me.btLimpiar.Text = "Limpiar"
        Me.btLimpiar.UseVisualStyleBackColor = True
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1723, 1038)
        Me.Controls.Add(Me.btLimpiar)
        Me.Controls.Add(Me.lbRuta)
        Me.Controls.Add(Me.cbRuta)
        Me.Controls.Add(Me.cbFiltrar)
        Me.Controls.Add(Me.lbFiltrar)
        Me.Controls.Add(Me.btSAlir)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.lbArea)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cbArea)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbDireccion)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lbTelefono)
        Me.Controls.Add(Me.txtTelefono)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmpleados"
        Me.Text = "frmClientes"
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbArea As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lbDireccion As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbTelefono As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btSAlir As Button
    Friend WithEvents btBuscar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents btAgregar As Button
    Friend WithEvents cbArea As ComboBox
    Friend WithEvents lbFiltrar As Label
    Friend WithEvents cbFiltrar As ComboBox
    Friend WithEvents lbRuta As Label
    Friend WithEvents cbRuta As ComboBox
    Friend WithEvents btLimpiar As Button
End Class
