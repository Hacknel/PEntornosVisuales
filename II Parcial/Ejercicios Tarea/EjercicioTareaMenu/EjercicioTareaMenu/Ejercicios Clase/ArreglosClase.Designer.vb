﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArreglosClase
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbPrecios = New System.Windows.Forms.ComboBox()
        Me.btnPrecio = New System.Windows.Forms.Button()
        Me.CmbComputadoras = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.btnSolicitarMul = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMostarCompMult = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCantIngresar = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtVender = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.txtCantCon = New System.Windows.Forms.TextBox()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMOdelo = New System.Windows.Forms.TextBox()
        Me.Modelo = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmbPrecios)
        Me.GroupBox1.Controls.Add(Me.btnPrecio)
        Me.GroupBox1.Controls.Add(Me.CmbComputadoras)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 208)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidimensionales"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbPrecios
        '
        Me.cmbPrecios.FormattingEnabled = True
        Me.cmbPrecios.Location = New System.Drawing.Point(200, 114)
        Me.cmbPrecios.Name = "cmbPrecios"
        Me.cmbPrecios.Size = New System.Drawing.Size(164, 21)
        Me.cmbPrecios.TabIndex = 3
        '
        'btnPrecio
        '
        Me.btnPrecio.Location = New System.Drawing.Point(229, 61)
        Me.btnPrecio.Name = "btnPrecio"
        Me.btnPrecio.Size = New System.Drawing.Size(106, 37)
        Me.btnPrecio.TabIndex = 2
        Me.btnPrecio.Text = "Generar Precio"
        Me.btnPrecio.UseVisualStyleBackColor = True
        '
        'CmbComputadoras
        '
        Me.CmbComputadoras.FormattingEnabled = True
        Me.CmbComputadoras.Location = New System.Drawing.Point(6, 114)
        Me.CmbComputadoras.Name = "CmbComputadoras"
        Me.CmbComputadoras.Size = New System.Drawing.Size(169, 21)
        Me.CmbComputadoras.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(50, 61)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(106, 37)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Computadoras"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCant)
        Me.GroupBox2.Controls.Add(Me.btnSolicitarMul)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbMostarCompMult)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 135)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Multidimensionales"
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(179, 34)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(127, 20)
        Me.txtCant.TabIndex = 3
        '
        'btnSolicitarMul
        '
        Me.btnSolicitarMul.Location = New System.Drawing.Point(163, 71)
        Me.btnSolicitarMul.Name = "btnSolicitarMul"
        Me.btnSolicitarMul.Size = New System.Drawing.Size(75, 23)
        Me.btnSolicitarMul.TabIndex = 2
        Me.btnSolicitarMul.Text = "Solicitar"
        Me.btnSolicitarMul.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cant. Computadoras"
        '
        'cmbMostarCompMult
        '
        Me.cmbMostarCompMult.FormattingEnabled = True
        Me.cmbMostarCompMult.Location = New System.Drawing.Point(117, 100)
        Me.cmbMostarCompMult.Name = "cmbMostarCompMult"
        Me.cmbMostarCompMult.Size = New System.Drawing.Size(160, 21)
        Me.cmbMostarCompMult.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCantIngresar)
        Me.GroupBox4.Controls.Add(Me.btnRegistrar)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(430, 46)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(377, 127)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro"
        '
        'txtCantIngresar
        '
        Me.txtCantIngresar.Location = New System.Drawing.Point(179, 34)
        Me.txtCantIngresar.Name = "txtCantIngresar"
        Me.txtCantIngresar.Size = New System.Drawing.Size(127, 20)
        Me.txtCantIngresar.TabIndex = 3
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(163, 71)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 2
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cant. Computadoras"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtVender)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnVender)
        Me.GroupBox3.Controls.Add(Me.txtCantCon)
        Me.GroupBox3.Controls.Add(Me.Cantidad)
        Me.GroupBox3.Controls.Add(Me.txtPrecio)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtMOdelo)
        Me.GroupBox3.Controls.Add(Me.Modelo)
        Me.GroupBox3.Controls.Add(Me.txtMarca)
        Me.GroupBox3.Controls.Add(Me.btnConsultar)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(430, 188)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(377, 208)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registro"
        '
        'txtVender
        '
        Me.txtVender.Location = New System.Drawing.Point(285, 130)
        Me.txtVender.Name = "txtVender"
        Me.txtVender.Size = New System.Drawing.Size(77, 20)
        Me.txtVender.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cant. Venta"
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(285, 156)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(77, 23)
        Me.btnVender.TabIndex = 10
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'txtCantCon
        '
        Me.txtCantCon.Location = New System.Drawing.Point(129, 153)
        Me.txtCantCon.Name = "txtCantCon"
        Me.txtCantCon.Size = New System.Drawing.Size(127, 20)
        Me.txtCantCon.TabIndex = 9
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.Location = New System.Drawing.Point(20, 156)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(103, 13)
        Me.Cantidad.TabIndex = 8
        Me.Cantidad.Text = "Cant. Computadoras"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(129, 111)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(127, 20)
        Me.txtPrecio.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Precio"
        '
        'txtMOdelo
        '
        Me.txtMOdelo.Location = New System.Drawing.Point(129, 73)
        Me.txtMOdelo.Name = "txtMOdelo"
        Me.txtMOdelo.Size = New System.Drawing.Size(127, 20)
        Me.txtMOdelo.TabIndex = 5
        '
        'Modelo
        '
        Me.Modelo.AutoSize = True
        Me.Modelo.Location = New System.Drawing.Point(20, 76)
        Me.Modelo.Name = "Modelo"
        Me.Modelo.Size = New System.Drawing.Size(42, 13)
        Me.Modelo.TabIndex = 4
        Me.Modelo.Text = "Modelo"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(129, 31)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(127, 20)
        Me.txtMarca.TabIndex = 3
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(285, 31)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(77, 23)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marca"
        '
        'ArreglosClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ArreglosClase"
        Me.Text = "ArreglosClase"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbComputadoras As ComboBox
    Friend WithEvents btnPrecio As Button
    Friend WithEvents cmbPrecios As ComboBox
    Friend WithEvents btnSolicitarMul As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbMostarCompMult As ComboBox
    Friend WithEvents txtCant As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtCantIngresar As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCantCon As TextBox
    Friend WithEvents Cantidad As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMOdelo As TextBox
    Friend WithEvents Modelo As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVender As Button
    Friend WithEvents txtVender As TextBox
    Friend WithEvents Label4 As Label
End Class
