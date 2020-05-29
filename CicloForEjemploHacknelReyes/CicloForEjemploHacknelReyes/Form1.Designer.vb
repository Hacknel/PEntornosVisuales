<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDesplejar = New System.Windows.Forms.Button()
        Me.txtNota1 = New System.Windows.Forms.TextBox()
        Me.txtNota2 = New System.Windows.Forms.TextBox()
        Me.txtNota3 = New System.Windows.Forms.TextBox()
        Me.txtNotaFinal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chboxApro = New System.Windows.Forms.CheckBox()
        Me.chboxRepro = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculadora de Notas"
        '
        'btnDesplejar
        '
        Me.btnDesplejar.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesplejar.Location = New System.Drawing.Point(254, 130)
        Me.btnDesplejar.Name = "btnDesplejar"
        Me.btnDesplejar.Size = New System.Drawing.Size(142, 38)
        Me.btnDesplejar.TabIndex = 1
        Me.btnDesplejar.Text = "EJECUTAR"
        Me.btnDesplejar.UseVisualStyleBackColor = True
        '
        'txtNota1
        '
        Me.txtNota1.Location = New System.Drawing.Point(146, 219)
        Me.txtNota1.Name = "txtNota1"
        Me.txtNota1.Size = New System.Drawing.Size(89, 20)
        Me.txtNota1.TabIndex = 2
        '
        'txtNota2
        '
        Me.txtNota2.Location = New System.Drawing.Point(146, 245)
        Me.txtNota2.Name = "txtNota2"
        Me.txtNota2.Size = New System.Drawing.Size(89, 20)
        Me.txtNota2.TabIndex = 3
        '
        'txtNota3
        '
        Me.txtNota3.Location = New System.Drawing.Point(146, 271)
        Me.txtNota3.Name = "txtNota3"
        Me.txtNota3.Size = New System.Drawing.Size(89, 20)
        Me.txtNota3.TabIndex = 4
        '
        'txtNotaFinal
        '
        Me.txtNotaFinal.Location = New System.Drawing.Point(337, 226)
        Me.txtNotaFinal.Name = "txtNotaFinal"
        Me.txtNotaFinal.Size = New System.Drawing.Size(84, 20)
        Me.txtNotaFinal.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nota 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nota 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nota 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(251, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Suma de Notas"
        '
        'chboxApro
        '
        Me.chboxApro.AutoSize = True
        Me.chboxApro.Location = New System.Drawing.Point(460, 226)
        Me.chboxApro.Name = "chboxApro"
        Me.chboxApro.Size = New System.Drawing.Size(72, 17)
        Me.chboxApro.TabIndex = 12
        Me.chboxApro.Text = "Aprobado"
        Me.chboxApro.UseVisualStyleBackColor = True
        '
        'chboxRepro
        '
        Me.chboxRepro.AutoSize = True
        Me.chboxRepro.Location = New System.Drawing.Point(460, 271)
        Me.chboxRepro.Name = "chboxRepro"
        Me.chboxRepro.Size = New System.Drawing.Size(79, 17)
        Me.chboxRepro.TabIndex = 13
        Me.chboxRepro.Text = "Reprobado"
        Me.chboxRepro.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(280, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Promedio"
        '
        'txtPromedio
        '
        Me.txtPromedio.Location = New System.Drawing.Point(337, 271)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.Size = New System.Drawing.Size(84, 20)
        Me.txtPromedio.TabIndex = 14
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(538, 294)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(87, 26)
        Me.btnLimpiar.TabIndex = 16
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 332)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.chboxRepro)
        Me.Controls.Add(Me.chboxApro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNotaFinal)
        Me.Controls.Add(Me.txtNota3)
        Me.Controls.Add(Me.txtNota2)
        Me.Controls.Add(Me.txtNota1)
        Me.Controls.Add(Me.btnDesplejar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDesplejar As Button
    Friend WithEvents txtNota1 As TextBox
    Friend WithEvents txtNota2 As TextBox
    Friend WithEvents txtNota3 As TextBox
    Friend WithEvents txtNotaFinal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chboxApro As CheckBox
    Friend WithEvents chboxRepro As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPromedio As TextBox
    Friend WithEvents btnLimpiar As Button
End Class
