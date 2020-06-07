<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculoSalario
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMontoBruto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSueldoNetoFinal = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.chbExonerado = New System.Windows.Forms.CheckBox()
        Me.chb15 = New System.Windows.Forms.CheckBox()
        Me.chb20 = New System.Windows.Forms.CheckBox()
        Me.chb25 = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txt15 = New System.Windows.Forms.TextBox()
        Me.txtExonerado = New System.Windows.Forms.TextBox()
        Me.txt20 = New System.Windows.Forms.TextBox()
        Me.txt25 = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Calculadora Salarios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Salario Bruto Mensual Lps."
        '
        'txtMontoBruto
        '
        Me.txtMontoBruto.Location = New System.Drawing.Point(190, 125)
        Me.txtMontoBruto.Name = "txtMontoBruto"
        Me.txtMontoBruto.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoBruto.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(193, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Sueldo Neto"
        '
        'txtSueldoNetoFinal
        '
        Me.txtSueldoNetoFinal.Location = New System.Drawing.Point(178, 318)
        Me.txtSueldoNetoFinal.Name = "txtSueldoNetoFinal"
        Me.txtSueldoNetoFinal.Size = New System.Drawing.Size(93, 20)
        Me.txtSueldoNetoFinal.TabIndex = 33
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(353, 365)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(83, 21)
        Me.btnSalir.TabIndex = 35
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.Location = New System.Drawing.Point(278, 365)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(69, 21)
        Me.btnRegresar.TabIndex = 34
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(163, 161)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(81, 38)
        Me.btnCalcular.TabIndex = 40
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'chbExonerado
        '
        Me.chbExonerado.AutoSize = True
        Me.chbExonerado.Location = New System.Drawing.Point(40, 230)
        Me.chbExonerado.Name = "chbExonerado"
        Me.chbExonerado.Size = New System.Drawing.Size(77, 17)
        Me.chbExonerado.TabIndex = 41
        Me.chbExonerado.Text = "Exonerado"
        Me.chbExonerado.UseVisualStyleBackColor = True
        '
        'chb15
        '
        Me.chb15.AutoSize = True
        Me.chb15.Location = New System.Drawing.Point(136, 230)
        Me.chb15.Name = "chb15"
        Me.chb15.Size = New System.Drawing.Size(90, 17)
        Me.chb15.TabIndex = 42
        Me.chb15.Text = "Gravado 15%"
        Me.chb15.UseVisualStyleBackColor = True
        '
        'chb20
        '
        Me.chb20.AutoSize = True
        Me.chb20.Location = New System.Drawing.Point(232, 230)
        Me.chb20.Name = "chb20"
        Me.chb20.Size = New System.Drawing.Size(90, 17)
        Me.chb20.TabIndex = 43
        Me.chb20.Text = "Gravado 20%"
        Me.chb20.UseVisualStyleBackColor = True
        '
        'chb25
        '
        Me.chb25.AutoSize = True
        Me.chb25.Location = New System.Drawing.Point(328, 230)
        Me.chb25.Name = "chb25"
        Me.chb25.Size = New System.Drawing.Size(90, 17)
        Me.chb25.TabIndex = 44
        Me.chb25.Text = "Gravado 25%"
        Me.chb25.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txt15
        '
        Me.txt15.Location = New System.Drawing.Point(136, 253)
        Me.txt15.Name = "txt15"
        Me.txt15.Size = New System.Drawing.Size(77, 20)
        Me.txt15.TabIndex = 46
        '
        'txtExonerado
        '
        Me.txtExonerado.Location = New System.Drawing.Point(40, 253)
        Me.txtExonerado.Name = "txtExonerado"
        Me.txtExonerado.Size = New System.Drawing.Size(77, 20)
        Me.txtExonerado.TabIndex = 47
        '
        'txt20
        '
        Me.txt20.Location = New System.Drawing.Point(232, 253)
        Me.txt20.Name = "txt20"
        Me.txt20.Size = New System.Drawing.Size(77, 20)
        Me.txt20.TabIndex = 48
        '
        'txt25
        '
        Me.txt25.Location = New System.Drawing.Point(328, 253)
        Me.txt25.Name = "txt25"
        Me.txt25.Size = New System.Drawing.Size(77, 20)
        Me.txt25.TabIndex = 49
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 359)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(79, 27)
        Me.btnLimpiar.TabIndex = 50
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'CalculoSalario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 403)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txt25)
        Me.Controls.Add(Me.txt20)
        Me.Controls.Add(Me.txtExonerado)
        Me.Controls.Add(Me.txt15)
        Me.Controls.Add(Me.chb25)
        Me.Controls.Add(Me.chb20)
        Me.Controls.Add(Me.chb15)
        Me.Controls.Add(Me.chbExonerado)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.txtSueldoNetoFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMontoBruto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CalculoSalario"
        Me.Text = "CalculoSalario"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMontoBruto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSueldoNetoFinal As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents chbExonerado As CheckBox
    Friend WithEvents chb15 As CheckBox
    Friend WithEvents chb20 As CheckBox
    Friend WithEvents chb25 As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txt25 As TextBox
    Friend WithEvents txt20 As TextBox
    Friend WithEvents txtExonerado As TextBox
    Friend WithEvents txt15 As TextBox
    Friend WithEvents btnLimpiar As Button
End Class
