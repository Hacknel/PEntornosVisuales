<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Numeros
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Resultados = New System.Windows.Forms.GroupBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.txtTotalIng = New System.Windows.Forms.TextBox()
        Me.txtNegativo = New System.Windows.Forms.TextBox()
        Me.txtPositivos = New System.Windows.Forms.TextBox()
        Me.txtImpares = New System.Windows.Forms.TextBox()
        Me.txtPares = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLanzar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantNumeros1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbHistorial = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Resultados.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Contador de Numeros"
        '
        'Resultados
        '
        Me.Resultados.Controls.Add(Me.txtSuma)
        Me.Resultados.Controls.Add(Me.txtTotalIng)
        Me.Resultados.Controls.Add(Me.txtNegativo)
        Me.Resultados.Controls.Add(Me.txtPositivos)
        Me.Resultados.Controls.Add(Me.txtImpares)
        Me.Resultados.Controls.Add(Me.txtPares)
        Me.Resultados.Controls.Add(Me.Label8)
        Me.Resultados.Controls.Add(Me.Label7)
        Me.Resultados.Controls.Add(Me.Label6)
        Me.Resultados.Controls.Add(Me.Label5)
        Me.Resultados.Controls.Add(Me.Label3)
        Me.Resultados.Controls.Add(Me.Label4)
        Me.Resultados.Location = New System.Drawing.Point(12, 180)
        Me.Resultados.Name = "Resultados"
        Me.Resultados.Size = New System.Drawing.Size(424, 156)
        Me.Resultados.TabIndex = 29
        Me.Resultados.TabStop = False
        Me.Resultados.Text = "Resultados"
        '
        'txtSuma
        '
        Me.txtSuma.Location = New System.Drawing.Point(331, 91)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(52, 20)
        Me.txtSuma.TabIndex = 47
        '
        'txtTotalIng
        '
        Me.txtTotalIng.Location = New System.Drawing.Point(331, 62)
        Me.txtTotalIng.Name = "txtTotalIng"
        Me.txtTotalIng.Size = New System.Drawing.Size(52, 20)
        Me.txtTotalIng.TabIndex = 46
        '
        'txtNegativo
        '
        Me.txtNegativo.Location = New System.Drawing.Point(331, 30)
        Me.txtNegativo.Name = "txtNegativo"
        Me.txtNegativo.Size = New System.Drawing.Size(52, 20)
        Me.txtNegativo.TabIndex = 45
        '
        'txtPositivos
        '
        Me.txtPositivos.Location = New System.Drawing.Point(139, 91)
        Me.txtPositivos.Name = "txtPositivos"
        Me.txtPositivos.Size = New System.Drawing.Size(52, 20)
        Me.txtPositivos.TabIndex = 44
        '
        'txtImpares
        '
        Me.txtImpares.Location = New System.Drawing.Point(139, 62)
        Me.txtImpares.Name = "txtImpares"
        Me.txtImpares.Size = New System.Drawing.Size(52, 20)
        Me.txtImpares.TabIndex = 43
        '
        'txtPares
        '
        Me.txtPares.Location = New System.Drawing.Point(139, 30)
        Me.txtPares.Name = "txtPares"
        Me.txtPares.Size = New System.Drawing.Size(52, 20)
        Me.txtPares.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(221, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Suma de los Numeros"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(221, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Cantidad Ingresados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(221, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Cantidad Negativos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Cantidad Positivos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Cantidad Impares"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Cantidad Pares"
        '
        'btnLanzar
        '
        Me.btnLanzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLanzar.Location = New System.Drawing.Point(334, 119)
        Me.btnLanzar.Name = "btnLanzar"
        Me.btnLanzar.Size = New System.Drawing.Size(81, 38)
        Me.btnLanzar.TabIndex = 40
        Me.btnLanzar.Text = "Lanzar"
        Me.btnLanzar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Ingrese Cuantos Numeros Evaluara"
        '
        'txtCantNumeros1
        '
        Me.txtCantNumeros1.Location = New System.Drawing.Point(256, 129)
        Me.txtCantNumeros1.Name = "txtCantNumeros1"
        Me.txtCantNumeros1.Size = New System.Drawing.Size(57, 20)
        Me.txtCantNumeros1.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(423, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 21)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(348, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 21)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(199, 342)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(81, 27)
        Me.btnLimpiar.TabIndex = 44
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cmbHistorial
        '
        Me.cmbHistorial.FormattingEnabled = True
        Me.cmbHistorial.Location = New System.Drawing.Point(441, 185)
        Me.cmbHistorial.Name = "cmbHistorial"
        Me.cmbHistorial.Size = New System.Drawing.Size(64, 21)
        Me.cmbHistorial.TabIndex = 45
        Me.cmbHistorial.Text = "Historial"
        '
        'Numeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 389)
        Me.Controls.Add(Me.cmbHistorial)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtCantNumeros1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLanzar)
        Me.Controls.Add(Me.Resultados)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Numeros"
        Me.Text = "Numeros"
        Me.Resultados.ResumeLayout(False)
        Me.Resultados.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Resultados As GroupBox
    Friend WithEvents btnLanzar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantNumeros1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents txtTotalIng As TextBox
    Friend WithEvents txtNegativo As TextBox
    Friend WithEvents txtPositivos As TextBox
    Friend WithEvents txtImpares As TextBox
    Friend WithEvents txtPares As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cmbHistorial As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
