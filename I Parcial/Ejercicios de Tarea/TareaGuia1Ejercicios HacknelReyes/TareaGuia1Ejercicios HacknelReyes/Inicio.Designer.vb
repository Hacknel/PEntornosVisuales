<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuInicio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalculadora = New System.Windows.Forms.Button()
        Me.btnCuadratica = New System.Windows.Forms.Button()
        Me.btnNumeros = New System.Windows.Forms.Button()
        Me.btnAlmacenes = New System.Windows.Forms.Button()
        Me.btnSueldo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guia de Ejercicios I Parcial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "@HacknelR"
        '
        'btnCalculadora
        '
        Me.btnCalculadora.Location = New System.Drawing.Point(108, 118)
        Me.btnCalculadora.Name = "btnCalculadora"
        Me.btnCalculadora.Size = New System.Drawing.Size(115, 41)
        Me.btnCalculadora.TabIndex = 2
        Me.btnCalculadora.Text = "Calculadora"
        Me.btnCalculadora.UseVisualStyleBackColor = True
        '
        'btnCuadratica
        '
        Me.btnCuadratica.Location = New System.Drawing.Point(285, 118)
        Me.btnCuadratica.Name = "btnCuadratica"
        Me.btnCuadratica.Size = New System.Drawing.Size(115, 41)
        Me.btnCuadratica.TabIndex = 3
        Me.btnCuadratica.Text = "Formula General Cuadratica"
        Me.btnCuadratica.UseVisualStyleBackColor = True
        '
        'btnNumeros
        '
        Me.btnNumeros.Location = New System.Drawing.Point(285, 184)
        Me.btnNumeros.Name = "btnNumeros"
        Me.btnNumeros.Size = New System.Drawing.Size(115, 41)
        Me.btnNumeros.TabIndex = 4
        Me.btnNumeros.Text = "Contador de Numeros"
        Me.btnNumeros.UseVisualStyleBackColor = True
        '
        'btnAlmacenes
        '
        Me.btnAlmacenes.Location = New System.Drawing.Point(108, 184)
        Me.btnAlmacenes.Name = "btnAlmacenes"
        Me.btnAlmacenes.Size = New System.Drawing.Size(115, 41)
        Me.btnAlmacenes.TabIndex = 5
        Me.btnAlmacenes.Text = "Gestion Almacen"
        Me.btnAlmacenes.UseVisualStyleBackColor = True
        '
        'btnSueldo
        '
        Me.btnSueldo.Location = New System.Drawing.Point(199, 244)
        Me.btnSueldo.Name = "btnSueldo"
        Me.btnSueldo.Size = New System.Drawing.Size(115, 41)
        Me.btnSueldo.TabIndex = 6
        Me.btnSueldo.Text = "Calculadora Sueldo SAR"
        Me.btnSueldo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(339, 319)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(115, 41)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'MenuInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 392)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSueldo)
        Me.Controls.Add(Me.btnAlmacenes)
        Me.Controls.Add(Me.btnNumeros)
        Me.Controls.Add(Me.btnCuadratica)
        Me.Controls.Add(Me.btnCalculadora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuInicio"
        Me.Text = "Menu Principal Guia Ejercicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculadora As Button
    Friend WithEvents btnCuadratica As Button
    Friend WithEvents btnNumeros As Button
    Friend WithEvents btnAlmacenes As Button
    Friend WithEvents btnSueldo As Button
    Friend WithEvents btnSalir As Button
End Class
