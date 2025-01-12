<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btConductores = New System.Windows.Forms.Button()
        Me.btArea = New System.Windows.Forms.Button()
        Me.btEmpleados = New System.Windows.Forms.Button()
        Me.btDistribucion = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btRuta = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.292035!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.70796!))
        Me.TableLayoutPanel1.Controls.Add(Me.panelContenedor, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 735.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1910, 1047)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelContenedor.Location = New System.Drawing.Point(180, 3)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(1723, 1038)
        Me.panelContenedor.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btConductores, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btArea, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btEmpleados, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btDistribucion, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btSalir, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btRuta, 0, 4)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(171, 1041)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btConductores
        '
        Me.btConductores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btConductores.AutoSize = True
        Me.btConductores.BackColor = System.Drawing.Color.White
        Me.btConductores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btConductores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btConductores.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btConductores.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConductores.Location = New System.Drawing.Point(3, 176)
        Me.btConductores.Name = "btConductores"
        Me.btConductores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btConductores.Size = New System.Drawing.Size(165, 167)
        Me.btConductores.TabIndex = 2
        Me.btConductores.Text = "Conductores"
        Me.btConductores.UseVisualStyleBackColor = False
        '
        'btArea
        '
        Me.btArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btArea.AutoSize = True
        Me.btArea.BackColor = System.Drawing.Color.White
        Me.btArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btArea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btArea.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btArea.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btArea.Location = New System.Drawing.Point(3, 3)
        Me.btArea.Name = "btArea"
        Me.btArea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btArea.Size = New System.Drawing.Size(165, 167)
        Me.btArea.TabIndex = 1
        Me.btArea.Text = "Area"
        Me.btArea.UseVisualStyleBackColor = False
        '
        'btEmpleados
        '
        Me.btEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEmpleados.AutoSize = True
        Me.btEmpleados.BackColor = System.Drawing.Color.White
        Me.btEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btEmpleados.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEmpleados.Location = New System.Drawing.Point(3, 522)
        Me.btEmpleados.Name = "btEmpleados"
        Me.btEmpleados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btEmpleados.Size = New System.Drawing.Size(165, 167)
        Me.btEmpleados.TabIndex = 4
        Me.btEmpleados.Text = "Empleados"
        Me.btEmpleados.UseVisualStyleBackColor = False
        '
        'btDistribucion
        '
        Me.btDistribucion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btDistribucion.AutoSize = True
        Me.btDistribucion.BackColor = System.Drawing.Color.White
        Me.btDistribucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btDistribucion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btDistribucion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btDistribucion.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDistribucion.Location = New System.Drawing.Point(3, 349)
        Me.btDistribucion.Name = "btDistribucion"
        Me.btDistribucion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btDistribucion.Size = New System.Drawing.Size(165, 167)
        Me.btDistribucion.TabIndex = 3
        Me.btDistribucion.Text = "Distribución De Rutas"
        Me.btDistribucion.UseVisualStyleBackColor = False
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.AutoSize = True
        Me.btSalir.BackColor = System.Drawing.Color.White
        Me.btSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btSalir.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Location = New System.Drawing.Point(3, 868)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btSalir.Size = New System.Drawing.Size(165, 170)
        Me.btSalir.TabIndex = 6
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'btRuta
        '
        Me.btRuta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btRuta.AutoSize = True
        Me.btRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btRuta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRuta.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btRuta.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.btRuta.Location = New System.Drawing.Point(3, 695)
        Me.btRuta.Name = "btRuta"
        Me.btRuta.Size = New System.Drawing.Size(165, 167)
        Me.btRuta.TabIndex = 5
        Me.btRuta.Text = "Ruta"
        Me.btRuta.UseVisualStyleBackColor = False
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdmin"
        Me.Text = "MENÚ ADMINISTRADOR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btSalir As Button
    Friend WithEvents btDistribucion As Button
    Friend WithEvents btEmpleados As Button
    Friend WithEvents btArea As Button
    Friend WithEvents btConductores As Button
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents btRuta As Button
End Class
