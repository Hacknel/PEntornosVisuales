<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibretaAhorroClase
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
        Me.ingresoInfo = New System.Windows.Forms.GroupBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.m = New System.Windows.Forms.Label()
        Me.cmbInteres = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtEdad = New System.Windows.Forms.MaskedTextBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAperturar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.lstRetiros = New System.Windows.Forms.ListBox()
        Me.LstDepositos = New System.Windows.Forms.ListBox()
        Me.cmbInfoAll = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolTipHoo = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.mtxtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.ingresoInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ingresoInfo
        '
        Me.ingresoInfo.Controls.Add(Me.txtCiudad)
        Me.ingresoInfo.Controls.Add(Me.m)
        Me.ingresoInfo.Controls.Add(Me.cmbInteres)
        Me.ingresoInfo.Controls.Add(Me.Label11)
        Me.ingresoInfo.Controls.Add(Me.txtMonto)
        Me.ingresoInfo.Controls.Add(Me.mtxtIdentidad)
        Me.ingresoInfo.Controls.Add(Me.mtxtEdad)
        Me.ingresoInfo.Controls.Add(Me.cmbPais)
        Me.ingresoInfo.Controls.Add(Me.Label8)
        Me.ingresoInfo.Controls.Add(Me.txtApellido)
        Me.ingresoInfo.Controls.Add(Me.Label7)
        Me.ingresoInfo.Controls.Add(Me.Label6)
        Me.ingresoInfo.Controls.Add(Me.txtNombre)
        Me.ingresoInfo.Controls.Add(Me.Label5)
        Me.ingresoInfo.Controls.Add(Me.btnAperturar)
        Me.ingresoInfo.Controls.Add(Me.Label2)
        Me.ingresoInfo.Controls.Add(Me.Label1)
        Me.ingresoInfo.Location = New System.Drawing.Point(27, 25)
        Me.ingresoInfo.Name = "ingresoInfo"
        Me.ingresoInfo.Size = New System.Drawing.Size(701, 141)
        Me.ingresoInfo.TabIndex = 0
        Me.ingresoInfo.TabStop = False
        Me.ingresoInfo.Text = "Ingreso de Informacion"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(76, 90)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(100, 20)
        Me.txtCiudad.TabIndex = 19
        '
        'm
        '
        Me.m.AutoSize = True
        Me.m.Location = New System.Drawing.Point(26, 93)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(40, 13)
        Me.m.TabIndex = 18
        Me.m.Text = "Ciudad"
        '
        'cmbInteres
        '
        Me.cmbInteres.FormattingEnabled = True
        Me.cmbInteres.Items.AddRange(New Object() {"0.3%", "0.5%", "1%"})
        Me.cmbInteres.Location = New System.Drawing.Point(426, 90)
        Me.cmbInteres.Name = "cmbInteres"
        Me.cmbInteres.Size = New System.Drawing.Size(105, 21)
        Me.cmbInteres.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(381, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Interes"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(319, 90)
        Me.txtMonto.Mask = "99999"
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(42, 20)
        Me.txtMonto.TabIndex = 15
        Me.txtMonto.ValidatingType = GetType(Integer)
        '
        'mtxtEdad
        '
        Me.mtxtEdad.Location = New System.Drawing.Point(231, 90)
        Me.mtxtEdad.Mask = "99"
        Me.mtxtEdad.Name = "mtxtEdad"
        Me.mtxtEdad.Size = New System.Drawing.Size(21, 20)
        Me.mtxtEdad.TabIndex = 13
        Me.mtxtEdad.ValidatingType = GetType(Integer)
        '
        'cmbPais
        '
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Items.AddRange(New Object() {"Belice", "Costa Rica", "El Salvador", "Guatemala", "Honduras", "Nicaragua", "Panama"})
        Me.cmbPais.Location = New System.Drawing.Point(561, 34)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(121, 21)
        Me.cmbPais.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(528, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Pais"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(193, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Edad"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(239, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre"
        '
        'btnAperturar
        '
        Me.btnAperturar.Location = New System.Drawing.Point(620, 90)
        Me.btnAperturar.Name = "btnAperturar"
        Me.btnAperturar.Size = New System.Drawing.Size(75, 45)
        Me.btnAperturar.TabIndex = 2
        Me.btnAperturar.Text = "Aperturar Cuenta"
        Me.btnAperturar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRetirar)
        Me.GroupBox2.Controls.Add(Me.btnDepositar)
        Me.GroupBox2.Location = New System.Drawing.Point(126, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 62)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operaciones"
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(125, 24)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(75, 24)
        Me.btnRetirar.TabIndex = 6
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(9, 24)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(75, 24)
        Me.btnDepositar.TabIndex = 5
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox3.Controls.Add(Me.txtSaldo)
        Me.GroupBox3.Controls.Add(Me.lstRetiros)
        Me.GroupBox3.Controls.Add(Me.LstDepositos)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(701, 226)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(632, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Saldo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(440, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Retiros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Depositos"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(620, 196)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 24)
        Me.BtnLimpiar.TabIndex = 7
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(625, 170)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(65, 20)
        Me.txtSaldo.TabIndex = 5
        '
        'lstRetiros
        '
        Me.lstRetiros.FormattingEnabled = True
        Me.lstRetiros.Location = New System.Drawing.Point(332, 47)
        Me.lstRetiros.Name = "lstRetiros"
        Me.lstRetiros.Size = New System.Drawing.Size(256, 173)
        Me.lstRetiros.TabIndex = 1
        '
        'LstDepositos
        '
        Me.LstDepositos.FormattingEnabled = True
        Me.LstDepositos.Location = New System.Drawing.Point(34, 47)
        Me.LstDepositos.Name = "LstDepositos"
        Me.LstDepositos.Size = New System.Drawing.Size(256, 173)
        Me.LstDepositos.TabIndex = 0
        '
        'cmbInfoAll
        '
        Me.cmbInfoAll.FormattingEnabled = True
        Me.cmbInfoAll.Location = New System.Drawing.Point(510, 196)
        Me.cmbInfoAll.Name = "cmbInfoAll"
        Me.cmbInfoAll.Size = New System.Drawing.Size(138, 21)
        Me.cmbInfoAll.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(396, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 26)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Seleccione  ID para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "consultar Informacion"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(359, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(409, 34)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 10
        '
        'mtxtIdentidad
        '
        Me.mtxtIdentidad.Location = New System.Drawing.Point(76, 34)
        Me.mtxtIdentidad.Mask = "0000-0000-00000"
        Me.mtxtIdentidad.Name = "mtxtIdentidad"
        Me.mtxtIdentidad.Size = New System.Drawing.Size(100, 20)
        Me.mtxtIdentidad.TabIndex = 14
        '
        'frmLibretaAhorroClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(751, 487)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbInfoAll)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ingresoInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLibretaAhorroClase"
        Me.Text = "frmLibretaAhorroClase"
        Me.ingresoInfo.ResumeLayout(False)
        Me.ingresoInfo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ingresoInfo As GroupBox
    Friend WithEvents btnAperturar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnRetirar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents lstRetiros As ListBox
    Friend WithEvents LstDepositos As ListBox
    Friend WithEvents mtxtEdad As MaskedTextBox
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMonto As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbInfoAll As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbInteres As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ToolTipHoo As ToolTip
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents m As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents mtxtIdentidad As MaskedTextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label7 As Label
End Class
