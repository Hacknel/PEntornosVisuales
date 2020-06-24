<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBolsasSolidariasTarea
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.m = New System.Windows.Forms.Label()
        Me.cmbCnatInte = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEstadoEcono = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chbBBasica = New System.Windows.Forms.CheckBox()
        Me.chbBRegular = New System.Windows.Forms.CheckBox()
        Me.btnConsultarContBasi = New System.Windows.Forms.Button()
        Me.btnConsultarContRegu = New System.Windows.Forms.Button()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpIngresoDatos = New System.Windows.Forms.GroupBox()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.dgvHistorial = New System.Windows.Forms.DataGridView()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantIntegrantesFamilia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoEconomico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoBolsa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbConsultas = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpIngresoDatos.SuspendLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(390, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(233, 50)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Programa Vida Mejor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          SGEBS"
        '
        'm
        '
        Me.m.AutoSize = True
        Me.m.Location = New System.Drawing.Point(443, 94)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(74, 13)
        Me.m.TabIndex = 34
        Me.m.Text = "Departamento"
        '
        'cmbCnatInte
        '
        Me.cmbCnatInte.FormattingEnabled = True
        Me.cmbCnatInte.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbCnatInte.Location = New System.Drawing.Point(679, 38)
        Me.cmbCnatInte.Name = "cmbCnatInte"
        Me.cmbCnatInte.Size = New System.Drawing.Size(45, 21)
        Me.cmbCnatInte.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(524, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Cant. Integrantes en la Familia"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(291, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(210, 20)
        Me.txtNombre.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Nombre Completo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Identidad"
        '
        'cmbEstadoEcono
        '
        Me.cmbEstadoEcono.FormattingEnabled = True
        Me.cmbEstadoEcono.Items.AddRange(New Object() {"Pobreza", "Pobreza Extrema", "Apoyo Social"})
        Me.cmbEstadoEcono.Location = New System.Drawing.Point(841, 37)
        Me.cmbEstadoEcono.Name = "cmbEstadoEcono"
        Me.cmbEstadoEcono.Size = New System.Drawing.Size(128, 21)
        Me.cmbEstadoEcono.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(739, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Estado Economico"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(77, 38)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentidad.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(167, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Tipo de Bolsa"
        '
        'chbBBasica
        '
        Me.chbBBasica.AutoSize = True
        Me.chbBBasica.Location = New System.Drawing.Point(241, 98)
        Me.chbBBasica.Name = "chbBBasica"
        Me.chbBBasica.Size = New System.Drawing.Size(79, 17)
        Me.chbBBasica.TabIndex = 41
        Me.chbBBasica.Text = "Basica(1-3)"
        Me.chbBBasica.UseVisualStyleBackColor = True
        '
        'chbBRegular
        '
        Me.chbBRegular.AutoSize = True
        Me.chbBRegular.Location = New System.Drawing.Point(345, 98)
        Me.chbBRegular.Name = "chbBRegular"
        Me.chbBRegular.Size = New System.Drawing.Size(81, 17)
        Me.chbBRegular.TabIndex = 42
        Me.chbBRegular.Text = "Regular(>3)"
        Me.chbBRegular.UseVisualStyleBackColor = True
        '
        'btnConsultarContBasi
        '
        Me.btnConsultarContBasi.Location = New System.Drawing.Point(241, 130)
        Me.btnConsultarContBasi.Name = "btnConsultarContBasi"
        Me.btnConsultarContBasi.Size = New System.Drawing.Size(67, 34)
        Me.btnConsultarContBasi.TabIndex = 43
        Me.btnConsultarContBasi.Text = "Consultar Contenido"
        Me.btnConsultarContBasi.UseVisualStyleBackColor = True
        '
        'btnConsultarContRegu
        '
        Me.btnConsultarContRegu.Location = New System.Drawing.Point(345, 130)
        Me.btnConsultarContRegu.Name = "btnConsultarContRegu"
        Me.btnConsultarContRegu.Size = New System.Drawing.Size(67, 34)
        Me.btnConsultarContRegu.TabIndex = 44
        Me.btnConsultarContRegu.Text = "Consultar Contenido"
        Me.btnConsultarContRegu.UseVisualStyleBackColor = True
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(523, 91)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(142, 21)
        Me.cmbDepartamento.TabIndex = 45
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(737, 91)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(112, 20)
        Me.txtMunicipio.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(684, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Municipio"
        '
        'grpIngresoDatos
        '
        Me.grpIngresoDatos.Controls.Add(Me.btnRegistar)
        Me.grpIngresoDatos.Controls.Add(Me.txtMunicipio)
        Me.grpIngresoDatos.Controls.Add(Me.Label2)
        Me.grpIngresoDatos.Controls.Add(Me.cmbDepartamento)
        Me.grpIngresoDatos.Controls.Add(Me.btnConsultarContRegu)
        Me.grpIngresoDatos.Controls.Add(Me.btnConsultarContBasi)
        Me.grpIngresoDatos.Controls.Add(Me.chbBRegular)
        Me.grpIngresoDatos.Controls.Add(Me.chbBBasica)
        Me.grpIngresoDatos.Controls.Add(Me.Label9)
        Me.grpIngresoDatos.Controls.Add(Me.txtIdentidad)
        Me.grpIngresoDatos.Controls.Add(Me.cmbEstadoEcono)
        Me.grpIngresoDatos.Controls.Add(Me.Label4)
        Me.grpIngresoDatos.Controls.Add(Me.m)
        Me.grpIngresoDatos.Controls.Add(Me.cmbCnatInte)
        Me.grpIngresoDatos.Controls.Add(Me.Label8)
        Me.grpIngresoDatos.Controls.Add(Me.txtNombre)
        Me.grpIngresoDatos.Controls.Add(Me.Label5)
        Me.grpIngresoDatos.Controls.Add(Me.Label3)
        Me.grpIngresoDatos.Location = New System.Drawing.Point(12, 77)
        Me.grpIngresoDatos.Name = "grpIngresoDatos"
        Me.grpIngresoDatos.Size = New System.Drawing.Size(1027, 181)
        Me.grpIngresoDatos.TabIndex = 48
        Me.grpIngresoDatos.TabStop = False
        Me.grpIngresoDatos.Text = "Ingreso de Datos"
        '
        'btnRegistar
        '
        Me.btnRegistar.Location = New System.Drawing.Point(770, 130)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(199, 34)
        Me.btnRegistar.TabIndex = 48
        Me.btnRegistar.Text = "Registrar"
        Me.btnRegistar.UseVisualStyleBackColor = True
        '
        'dgvHistorial
        '
        Me.dgvHistorial.AllowUserToDeleteRows = False
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identidad, Me.Nombre, Me.CantIntegrantesFamilia, Me.EstadoEconomico, Me.TipoBolsa, Me.Departamento, Me.Municipio})
        Me.dgvHistorial.Location = New System.Drawing.Point(17, 326)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.ReadOnly = True
        Me.dgvHistorial.Size = New System.Drawing.Size(1022, 207)
        Me.dgvHistorial.TabIndex = 49
        '
        'Identidad
        '
        Me.Identidad.HeaderText = "Identidad"
        Me.Identidad.Name = "Identidad"
        Me.Identidad.ReadOnly = True
        Me.Identidad.Width = 140
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre Completo"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 240
        '
        'CantIntegrantesFamilia
        '
        Me.CantIntegrantesFamilia.HeaderText = "Cant Integrantes Familia"
        Me.CantIntegrantesFamilia.Name = "CantIntegrantesFamilia"
        Me.CantIntegrantesFamilia.ReadOnly = True
        Me.CantIntegrantesFamilia.Width = 80
        '
        'EstadoEconomico
        '
        Me.EstadoEconomico.HeaderText = "Estado Economico"
        Me.EstadoEconomico.Name = "EstadoEconomico"
        Me.EstadoEconomico.ReadOnly = True
        Me.EstadoEconomico.Width = 130
        '
        'TipoBolsa
        '
        Me.TipoBolsa.HeaderText = "Tipo Bolsa"
        Me.TipoBolsa.Name = "TipoBolsa"
        Me.TipoBolsa.ReadOnly = True
        Me.TipoBolsa.Width = 130
        '
        'Departamento
        '
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        Me.Departamento.ReadOnly = True
        Me.Departamento.Width = 130
        '
        'Municipio
        '
        Me.Municipio.HeaderText = "Municipio"
        Me.Municipio.Name = "Municipio"
        Me.Municipio.ReadOnly = True
        Me.Municipio.Width = 130
        '
        'cmbConsultas
        '
        Me.cmbConsultas.FormattingEnabled = True
        Me.cmbConsultas.Items.AddRange(New Object() {"TODOS", "Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbConsultas.Location = New System.Drawing.Point(173, 282)
        Me.cmbConsultas.Name = "cmbConsultas"
        Me.cmbConsultas.Size = New System.Drawing.Size(147, 21)
        Me.cmbConsultas.TabIndex = 50
        Me.cmbConsultas.Text = "Seleccionar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Seleccione Mostrar Historial de"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(896, 282)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(85, 38)
        Me.btnLimpiar.TabIndex = 49
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmBolsasSolidariasTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 545)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbConsultas)
        Me.Controls.Add(Me.dgvHistorial)
        Me.Controls.Add(Me.grpIngresoDatos)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBolsasSolidariasTarea"
        Me.Text = "frmBolsasSolidarias"
        Me.grpIngresoDatos.ResumeLayout(False)
        Me.grpIngresoDatos.PerformLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents m As Label
    Friend WithEvents cmbCnatInte As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbEstadoEcono As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chbBBasica As CheckBox
    Friend WithEvents chbBRegular As CheckBox
    Friend WithEvents btnConsultarContBasi As Button
    Friend WithEvents btnConsultarContRegu As Button
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grpIngresoDatos As GroupBox
    Friend WithEvents btnRegistar As Button
    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents CantIntegrantesFamilia As DataGridViewTextBoxColumn
    Friend WithEvents EstadoEconomico As DataGridViewTextBoxColumn
    Friend WithEvents TipoBolsa As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewTextBoxColumn
    Friend WithEvents Municipio As DataGridViewTextBoxColumn
    Friend WithEvents cmbConsultas As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
