<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDistribucionDeRutas
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.lbPlanta1 = New System.Windows.Forms.Label()
        Me.lbConductor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.dgvEntrada = New System.Windows.Forms.DataGridView()
        Me.lbEntrada = New System.Windows.Forms.Label()
        Me.dgvSalida = New System.Windows.Forms.DataGridView()
        Me.lbSalida = New System.Windows.Forms.Label()
        Me.cbConductor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtNovedades = New System.Windows.Forms.TextBox()
        Me.lbNovedades = New System.Windows.Forms.Label()
        Me.cbFiltrar1 = New System.Windows.Forms.ComboBox()
        Me.lbFiltrar1 = New System.Windows.Forms.Label()
        Me.cbFiltrar2 = New System.Windows.Forms.ComboBox()
        Me.lbFiltrar2 = New System.Windows.Forms.Label()
        Me.cbFiltrar3 = New System.Windows.Forms.ComboBox()
        Me.lbFiltrar3 = New System.Windows.Forms.Label()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btImportar = New System.Windows.Forms.Button()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbInfo
        '
        Me.lbInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbInfo.AutoSize = True
        Me.lbInfo.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.lbInfo.Location = New System.Drawing.Point(1374, -116)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(221, 25)
        Me.lbInfo.TabIndex = 52
        Me.lbInfo.Text = "Informacion de empleados"
        '
        'lbPlanta1
        '
        Me.lbPlanta1.AutoSize = True
        Me.lbPlanta1.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.lbPlanta1.Location = New System.Drawing.Point(162, -116)
        Me.lbPlanta1.Name = "lbPlanta1"
        Me.lbPlanta1.Size = New System.Drawing.Size(62, 25)
        Me.lbPlanta1.TabIndex = 47
        Me.lbPlanta1.Text = "Planta"
        '
        'lbConductor
        '
        Me.lbConductor.AutoSize = True
        Me.lbConductor.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.lbConductor.Location = New System.Drawing.Point(162, -116)
        Me.lbConductor.Name = "lbConductor"
        Me.lbConductor.Size = New System.Drawing.Size(94, 25)
        Me.lbConductor.TabIndex = 46
        Me.lbConductor.Text = "Conductor"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 37)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Informacion de empleados"
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvEmpleados.Location = New System.Drawing.Point(16, 113)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvEmpleados.Size = New System.Drawing.Size(940, 829)
        Me.dgvEmpleados.TabIndex = 54
        '
        'dgvEntrada
        '
        Me.dgvEntrada.AllowUserToAddRows = False
        Me.dgvEntrada.AllowUserToDeleteRows = False
        Me.dgvEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEntrada.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEntrada.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvEntrada.Location = New System.Drawing.Point(1015, 61)
        Me.dgvEntrada.Name = "dgvEntrada"
        Me.dgvEntrada.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEntrada.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dgvEntrada.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvEntrada.Size = New System.Drawing.Size(700, 440)
        Me.dgvEntrada.TabIndex = 78
        '
        'lbEntrada
        '
        Me.lbEntrada.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbEntrada.AutoSize = True
        Me.lbEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEntrada.Location = New System.Drawing.Point(1006, 5)
        Me.lbEntrada.Name = "lbEntrada"
        Me.lbEntrada.Size = New System.Drawing.Size(130, 37)
        Me.lbEntrada.TabIndex = 79
        Me.lbEntrada.Text = "Entrada"
        '
        'dgvSalida
        '
        Me.dgvSalida.AllowUserToAddRows = False
        Me.dgvSalida.AllowUserToDeleteRows = False
        Me.dgvSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSalida.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSalida.DefaultCellStyle = DataGridViewCellStyle22
        Me.dgvSalida.Location = New System.Drawing.Point(1013, 568)
        Me.dgvSalida.Name = "dgvSalida"
        Me.dgvSalida.ReadOnly = True
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSalida.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dgvSalida.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.dgvSalida.Size = New System.Drawing.Size(700, 440)
        Me.dgvSalida.TabIndex = 80
        '
        'lbSalida
        '
        Me.lbSalida.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbSalida.AutoSize = True
        Me.lbSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSalida.Location = New System.Drawing.Point(1006, 517)
        Me.lbSalida.Name = "lbSalida"
        Me.lbSalida.Size = New System.Drawing.Size(106, 37)
        Me.lbSalida.TabIndex = 83
        Me.lbSalida.Text = "Salida"
        '
        'cbConductor
        '
        Me.cbConductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConductor.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConductor.FormattingEnabled = True
        Me.cbConductor.Location = New System.Drawing.Point(144, 9)
        Me.cbConductor.Name = "cbConductor"
        Me.cbConductor.Size = New System.Drawing.Size(277, 41)
        Me.cbConductor.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 33)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Conductor"
        '
        'btnExportar
        '
        Me.btnExportar.AutoSize = True
        Me.btnExportar.BackColor = System.Drawing.Color.Green
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(303, 948)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(184, 60)
        Me.btnExportar.TabIndex = 86
        Me.btnExportar.Text = "EXPORTAR"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AutoSize = True
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(157, 948)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(140, 60)
        Me.btnLimpiar.TabIndex = 87
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtNovedades
        '
        Me.txtNovedades.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNovedades.Location = New System.Drawing.Point(568, 9)
        Me.txtNovedades.Name = "txtNovedades"
        Me.txtNovedades.Size = New System.Drawing.Size(388, 41)
        Me.txtNovedades.TabIndex = 90
        '
        'lbNovedades
        '
        Me.lbNovedades.AutoSize = True
        Me.lbNovedades.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNovedades.Location = New System.Drawing.Point(427, 17)
        Me.lbNovedades.Name = "lbNovedades"
        Me.lbNovedades.Size = New System.Drawing.Size(135, 33)
        Me.lbNovedades.TabIndex = 89
        Me.lbNovedades.Text = "Novedades"
        '
        'cbFiltrar1
        '
        Me.cbFiltrar1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltrar1.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltrar1.FormattingEnabled = True
        Me.cbFiltrar1.Location = New System.Drawing.Point(699, 66)
        Me.cbFiltrar1.Name = "cbFiltrar1"
        Me.cbFiltrar1.Size = New System.Drawing.Size(257, 41)
        Me.cbFiltrar1.TabIndex = 92
        '
        'lbFiltrar1
        '
        Me.lbFiltrar1.AutoSize = True
        Me.lbFiltrar1.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFiltrar1.Location = New System.Drawing.Point(554, 69)
        Me.lbFiltrar1.Name = "lbFiltrar1"
        Me.lbFiltrar1.Size = New System.Drawing.Size(132, 33)
        Me.lbFiltrar1.TabIndex = 91
        Me.lbFiltrar1.Text = "Filtrar Area"
        '
        'cbFiltrar2
        '
        Me.cbFiltrar2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbFiltrar2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltrar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltrar2.FormattingEnabled = True
        Me.cbFiltrar2.Location = New System.Drawing.Point(1308, 4)
        Me.cbFiltrar2.Name = "cbFiltrar2"
        Me.cbFiltrar2.Size = New System.Drawing.Size(292, 41)
        Me.cbFiltrar2.TabIndex = 94
        '
        'lbFiltrar2
        '
        Me.lbFiltrar2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbFiltrar2.AutoSize = True
        Me.lbFiltrar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFiltrar2.Location = New System.Drawing.Point(1142, 9)
        Me.lbFiltrar2.Name = "lbFiltrar2"
        Me.lbFiltrar2.Size = New System.Drawing.Size(160, 33)
        Me.lbFiltrar2.TabIndex = 93
        Me.lbFiltrar2.Text = "Filtrar Area"
        '
        'cbFiltrar3
        '
        Me.cbFiltrar3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbFiltrar3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltrar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFiltrar3.FormattingEnabled = True
        Me.cbFiltrar3.Location = New System.Drawing.Point(1308, 516)
        Me.cbFiltrar3.Name = "cbFiltrar3"
        Me.cbFiltrar3.Size = New System.Drawing.Size(292, 41)
        Me.cbFiltrar3.TabIndex = 96
        '
        'lbFiltrar3
        '
        Me.lbFiltrar3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbFiltrar3.AutoSize = True
        Me.lbFiltrar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFiltrar3.Location = New System.Drawing.Point(1142, 519)
        Me.lbFiltrar3.Name = "lbFiltrar3"
        Me.lbFiltrar3.Size = New System.Drawing.Size(160, 33)
        Me.lbFiltrar3.TabIndex = 95
        Me.lbFiltrar3.Text = "Filtrar Area"
        '
        'btSalir
        '
        Me.btSalir.AutoSize = True
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Location = New System.Drawing.Point(677, 948)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(120, 60)
        Me.btSalir.TabIndex = 97
        Me.btSalir.Text = "SALIR"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btImportar
        '
        Me.btImportar.AutoSize = True
        Me.btImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImportar.Location = New System.Drawing.Point(493, 948)
        Me.btImportar.Name = "btImportar"
        Me.btImportar.Size = New System.Drawing.Size(178, 60)
        Me.btImportar.TabIndex = 98
        Me.btImportar.Text = "IMPORTAR"
        Me.btImportar.UseVisualStyleBackColor = True
        '
        'frmDistribucionDeRutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1723, 1020)
        Me.Controls.Add(Me.btImportar)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.cbFiltrar3)
        Me.Controls.Add(Me.lbFiltrar3)
        Me.Controls.Add(Me.cbFiltrar2)
        Me.Controls.Add(Me.lbFiltrar2)
        Me.Controls.Add(Me.cbFiltrar1)
        Me.Controls.Add(Me.lbFiltrar1)
        Me.Controls.Add(Me.txtNovedades)
        Me.Controls.Add(Me.lbNovedades)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.cbConductor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbSalida)
        Me.Controls.Add(Me.dgvSalida)
        Me.Controls.Add(Me.lbEntrada)
        Me.Controls.Add(Me.dgvEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.lbInfo)
        Me.Controls.Add(Me.lbPlanta1)
        Me.Controls.Add(Me.lbConductor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDistribucionDeRutas"
        Me.Text = "Distribución De Rutas"
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbInfo As Label
    Friend WithEvents lbPlanta1 As Label
    Friend WithEvents lbConductor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents dgvEntrada As DataGridView
    Friend WithEvents lbEntrada As Label
    Friend WithEvents dgvSalida As DataGridView
    Friend WithEvents lbSalida As Label
    Friend WithEvents cbConductor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtNovedades As TextBox
    Friend WithEvents lbNovedades As Label
    Friend WithEvents cbFiltrar1 As ComboBox
    Friend WithEvents lbFiltrar1 As Label
    Friend WithEvents cbFiltrar2 As ComboBox
    Friend WithEvents lbFiltrar2 As Label
    Friend WithEvents cbFiltrar3 As ComboBox
    Friend WithEvents lbFiltrar3 As Label
    Friend WithEvents btSalir As Button
    Friend WithEvents btImportar As Button
End Class
