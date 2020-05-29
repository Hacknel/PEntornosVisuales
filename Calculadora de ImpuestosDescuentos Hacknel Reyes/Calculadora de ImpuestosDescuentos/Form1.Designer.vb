<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculadoraDescImpu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculadoraDescImpu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPUnitario = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.chbDescuento = New System.Windows.Forms.CheckBox()
        Me.chbImpuesto = New System.Windows.Forms.CheckBox()
        Me.comboxDesc = New System.Windows.Forms.ComboBox()
        Me.comboxImpuest = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RELLENE EL SIGUIENTE FORMULARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "P. UNITARIO: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(46, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CANTIDAD: "
        '
        'txtPUnitario
        '
        Me.txtPUnitario.BackColor = System.Drawing.SystemColors.Window
        Me.txtPUnitario.Location = New System.Drawing.Point(162, 73)
        Me.txtPUnitario.Name = "txtPUnitario"
        Me.txtPUnitario.Size = New System.Drawing.Size(95, 20)
        Me.txtPUnitario.TabIndex = 3
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidad.Location = New System.Drawing.Point(162, 102)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(95, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'chbDescuento
        '
        Me.chbDescuento.AutoSize = True
        Me.chbDescuento.BackColor = System.Drawing.Color.Transparent
        Me.chbDescuento.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbDescuento.Location = New System.Drawing.Point(49, 138)
        Me.chbDescuento.Name = "chbDescuento"
        Me.chbDescuento.Size = New System.Drawing.Size(163, 20)
        Me.chbDescuento.TabIndex = 5
        Me.chbDescuento.Text = "APLICAR DESCUENTO"
        Me.chbDescuento.UseVisualStyleBackColor = False
        '
        'chbImpuesto
        '
        Me.chbImpuesto.AutoSize = True
        Me.chbImpuesto.BackColor = System.Drawing.Color.Transparent
        Me.chbImpuesto.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbImpuesto.Location = New System.Drawing.Point(49, 191)
        Me.chbImpuesto.Name = "chbImpuesto"
        Me.chbImpuesto.Size = New System.Drawing.Size(155, 20)
        Me.chbImpuesto.TabIndex = 6
        Me.chbImpuesto.Text = "APLICAR IMPUESTO"
        Me.chbImpuesto.UseVisualStyleBackColor = False
        '
        'comboxDesc
        '
        Me.comboxDesc.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxDesc.FormattingEnabled = True
        Me.comboxDesc.Items.AddRange(New Object() {"DESCUENTO POR TERCERA EDAD (25%)", "DESCUENTO POR TEMPORADA (10%)", "DESCUENTO POR PAGO PRONTO (5%)", "DESCUENTO POR MEMBRESIA (12%)", "DESCUENTO POR LIQUIDACION (15%)", "DESCUENTO POR FIN DEL MUNDO (100%)"})
        Me.comboxDesc.Location = New System.Drawing.Point(49, 164)
        Me.comboxDesc.Name = "comboxDesc"
        Me.comboxDesc.Size = New System.Drawing.Size(249, 22)
        Me.comboxDesc.TabIndex = 7
        Me.comboxDesc.Text = "SELECCIONE UN DESCUENTO"
        '
        'comboxImpuest
        '
        Me.comboxImpuest.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxImpuest.FormattingEnabled = True
        Me.comboxImpuest.Items.AddRange(New Object() {"IMPUESTO SOBRE LA VENTA (15%)", "IMPUESTO SOBRE LA VENTA (17%)"})
        Me.comboxImpuest.Location = New System.Drawing.Point(49, 217)
        Me.comboxImpuest.Name = "comboxImpuest"
        Me.comboxImpuest.Size = New System.Drawing.Size(249, 22)
        Me.comboxImpuest.TabIndex = 8
        Me.comboxImpuest.Text = "SELECCIONE UN IMPUESTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "DETALLES FACTURA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SUBTOTAL: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "DESCUENTO: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 461)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ISV: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 492)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "TOTAL:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtSubTotal.Location = New System.Drawing.Point(141, 397)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(95, 20)
        Me.txtSubTotal.TabIndex = 14
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesc.Location = New System.Drawing.Point(141, 428)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(95, 20)
        Me.txtDesc.TabIndex = 15
        '
        'txtISV
        '
        Me.txtISV.BackColor = System.Drawing.SystemColors.Window
        Me.txtISV.Location = New System.Drawing.Point(141, 461)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.Size = New System.Drawing.Size(95, 20)
        Me.txtISV.TabIndex = 16
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal.Location = New System.Drawing.Point(141, 492)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(95, 20)
        Me.txtTotal.TabIndex = 17
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(95, 274)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(86, 30)
        Me.btnCalcular.TabIndex = 18
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(49, 537)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(86, 30)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(150, 538)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 30)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'CalculadoraDescImpu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(360, 591)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtISV)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.comboxImpuest)
        Me.Controls.Add(Me.comboxDesc)
        Me.Controls.Add(Me.chbImpuesto)
        Me.Controls.Add(Me.chbDescuento)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPUnitario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CalculadoraDescImpu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora de Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPUnitario As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents chbDescuento As CheckBox
    Friend WithEvents chbImpuesto As CheckBox
    Friend WithEvents comboxDesc As ComboBox
    Friend WithEvents comboxImpuest As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtISV As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
End Class
