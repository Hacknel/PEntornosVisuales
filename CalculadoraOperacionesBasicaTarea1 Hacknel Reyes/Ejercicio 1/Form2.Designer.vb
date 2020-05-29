<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.ChboxSuma = New System.Windows.Forms.CheckBox()
        Me.ChboxResta = New System.Windows.Forms.CheckBox()
        Me.ChboxDivision = New System.Windows.Forms.CheckBox()
        Me.ChboxRaiz = New System.Windows.Forms.CheckBox()
        Me.ChboxMulti = New System.Windows.Forms.CheckBox()
        Me.ChboxPotencia = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(127, 73)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(143, 21)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Ingrese el Valor 1"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(126, 97)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(154, 20)
        Me.txtValor1.TabIndex = 1
        Me.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(298, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese el Valor 2"
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(302, 97)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(154, 20)
        Me.txtValor2.TabIndex = 4
        Me.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChboxSuma
        '
        Me.ChboxSuma.AutoSize = True
        Me.ChboxSuma.BackColor = System.Drawing.Color.Transparent
        Me.ChboxSuma.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChboxSuma.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChboxSuma.Location = New System.Drawing.Point(102, 176)
        Me.ChboxSuma.Name = "ChboxSuma"
        Me.ChboxSuma.Size = New System.Drawing.Size(57, 20)
        Me.ChboxSuma.TabIndex = 5
        Me.ChboxSuma.Text = "Suma"
        Me.ChboxSuma.UseVisualStyleBackColor = False
        '
        'ChboxResta
        '
        Me.ChboxResta.AutoSize = True
        Me.ChboxResta.BackColor = System.Drawing.Color.Transparent
        Me.ChboxResta.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChboxResta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChboxResta.Location = New System.Drawing.Point(102, 199)
        Me.ChboxResta.Name = "ChboxResta"
        Me.ChboxResta.Size = New System.Drawing.Size(61, 20)
        Me.ChboxResta.TabIndex = 6
        Me.ChboxResta.Text = "Resta"
        Me.ChboxResta.UseVisualStyleBackColor = False
        '
        'ChboxDivision
        '
        Me.ChboxDivision.AutoSize = True
        Me.ChboxDivision.BackColor = System.Drawing.Color.Transparent
        Me.ChboxDivision.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChboxDivision.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChboxDivision.Location = New System.Drawing.Point(207, 176)
        Me.ChboxDivision.Name = "ChboxDivision"
        Me.ChboxDivision.Size = New System.Drawing.Size(69, 20)
        Me.ChboxDivision.TabIndex = 7
        Me.ChboxDivision.Text = "Division"
        Me.ChboxDivision.UseVisualStyleBackColor = False
        '
        'ChboxRaiz
        '
        Me.ChboxRaiz.AutoSize = True
        Me.ChboxRaiz.BackColor = System.Drawing.Color.Transparent
        Me.ChboxRaiz.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChboxRaiz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChboxRaiz.Location = New System.Drawing.Point(207, 199)
        Me.ChboxRaiz.Name = "ChboxRaiz"
        Me.ChboxRaiz.Size = New System.Drawing.Size(106, 20)
        Me.ChboxRaiz.TabIndex = 8
        Me.ChboxRaiz.Text = "Raiz (Valor 1)"
        Me.ChboxRaiz.UseVisualStyleBackColor = False
        '
        'ChboxMulti
        '
        Me.ChboxMulti.AutoSize = True
        Me.ChboxMulti.BackColor = System.Drawing.Color.Transparent
        Me.ChboxMulti.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChboxMulti.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChboxMulti.Location = New System.Drawing.Point(321, 176)
        Me.ChboxMulti.Name = "ChboxMulti"
        Me.ChboxMulti.Size = New System.Drawing.Size(102, 20)
        Me.ChboxMulti.TabIndex = 9
        Me.ChboxMulti.Text = "Multiplicacion"
        Me.ChboxMulti.UseVisualStyleBackColor = False
        '
        'ChboxPotencia
        '
        Me.ChboxPotencia.AutoSize = True
        Me.ChboxPotencia.BackColor = System.Drawing.Color.Transparent
        Me.ChboxPotencia.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChboxPotencia.Location = New System.Drawing.Point(321, 199)
        Me.ChboxPotencia.Name = "ChboxPotencia"
        Me.ChboxPotencia.Size = New System.Drawing.Size(183, 20)
        Me.ChboxPotencia.TabIndex = 10
        Me.ChboxPotencia.Text = "Potencia ( Valor1 ^ Valor2)"
        Me.ChboxPotencia.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(352, 38)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Operaciones Matematicas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(245, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Resultado"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(215, 269)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(154, 20)
        Me.txtResultado.TabIndex = 13
        Me.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.OldLace
        Me.btnLimpiar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 313)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(107, 32)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "Limpiar Calculos"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(186, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Seleccione Solo una Opcion"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(583, 380)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChboxPotencia)
        Me.Controls.Add(Me.ChboxMulti)
        Me.Controls.Add(Me.ChboxRaiz)
        Me.Controls.Add(Me.ChboxDivision)
        Me.Controls.Add(Me.ChboxResta)
        Me.Controls.Add(Me.ChboxSuma)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form2"
        Me.Text = "Calculadora Matematica Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents ChboxSuma As CheckBox
    Friend WithEvents ChboxResta As CheckBox
    Friend WithEvents ChboxDivision As CheckBox
    Friend WithEvents ChboxRaiz As CheckBox
    Friend WithEvents ChboxMulti As CheckBox
    Friend WithEvents ChboxPotencia As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label5 As Label
End Class
