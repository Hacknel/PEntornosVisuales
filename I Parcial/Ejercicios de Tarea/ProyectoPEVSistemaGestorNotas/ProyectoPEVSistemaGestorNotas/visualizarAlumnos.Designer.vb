<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visualizarAlumnos
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
        Me.cmbDatosAlumnos = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNota1 = New System.Windows.Forms.TextBox()
        Me.txtNota2 = New System.Windows.Forms.TextBox()
        Me.txtNota3 = New System.Windows.Forms.TextBox()
        Me.txtRegistro = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegresarAlInicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarDatosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraExternaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtiidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Visualizar Datos de Alumnos"
        '
        'cmbDatosAlumnos
        '
        Me.cmbDatosAlumnos.FormattingEnabled = True
        Me.cmbDatosAlumnos.Location = New System.Drawing.Point(85, 123)
        Me.cmbDatosAlumnos.Name = "cmbDatosAlumnos"
        Me.cmbDatosAlumnos.Size = New System.Drawing.Size(421, 21)
        Me.cmbDatosAlumnos.TabIndex = 1
        Me.cmbDatosAlumnos.Text = "Seleccione Registro Alumno"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "No. Registro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Apellidos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(82, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Nota Primer Parcial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nota Segundo Parcial"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 366)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Nota Tercer Parcial"
        '
        'txtNota1
        '
        Me.txtNota1.Location = New System.Drawing.Point(208, 294)
        Me.txtNota1.Name = "txtNota1"
        Me.txtNota1.Size = New System.Drawing.Size(59, 20)
        Me.txtNota1.TabIndex = 25
        Me.txtNota1.Text = "0"
        '
        'txtNota2
        '
        Me.txtNota2.Location = New System.Drawing.Point(208, 331)
        Me.txtNota2.Name = "txtNota2"
        Me.txtNota2.Size = New System.Drawing.Size(59, 20)
        Me.txtNota2.TabIndex = 26
        Me.txtNota2.Text = "0"
        '
        'txtNota3
        '
        Me.txtNota3.Location = New System.Drawing.Point(208, 366)
        Me.txtNota3.Name = "txtNota3"
        Me.txtNota3.Size = New System.Drawing.Size(59, 20)
        Me.txtNota3.TabIndex = 27
        Me.txtNota3.Text = "0"
        '
        'txtRegistro
        '
        Me.txtRegistro.Location = New System.Drawing.Point(154, 192)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(180, 20)
        Me.txtRegistro.TabIndex = 28
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(154, 230)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(180, 20)
        Me.txtNombres.TabIndex = 29
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(154, 263)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(180, 20)
        Me.txtApellidos.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(413, 344)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(93, 20)
        Me.txtEstado.TabIndex = 32
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(413, 409)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 29)
        Me.btnVolver.TabIndex = 34
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(529, 409)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(95, 29)
        Me.btnSalir.TabIndex = 35
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(367, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Promedio"
        '
        'txtPromedio
        '
        Me.txtPromedio.Location = New System.Drawing.Point(424, 309)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.Size = New System.Drawing.Size(59, 20)
        Me.txtPromedio.TabIndex = 37
        Me.txtPromedio.Text = "0"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.InicioToolStripMenuItem, Me.IngresarDatosToolStripMenuItem, Me.UtiidadesToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(665, 24)
        Me.MenuStrip.TabIndex = 42
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SALIRToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripMenuItem1.Text = "Archivo"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SALIRToolStripMenuItem.Text = "Salir"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarAlInicioToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'RegresarAlInicioToolStripMenuItem
        '
        Me.RegresarAlInicioToolStripMenuItem.Name = "RegresarAlInicioToolStripMenuItem"
        Me.RegresarAlInicioToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RegresarAlInicioToolStripMenuItem.Text = "Regresar"
        '
        'IngresarDatosToolStripMenuItem
        '
        Me.IngresarDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarDatosToolStripMenuItem1, Me.CalculadoraExternaToolStripMenuItem, Me.ImprimirLitsaDeAlumnosToolStripMenuItem})
        Me.IngresarDatosToolStripMenuItem.Name = "IngresarDatosToolStripMenuItem"
        Me.IngresarDatosToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.IngresarDatosToolStripMenuItem.Text = "Opciones"
        '
        'IngresarDatosToolStripMenuItem1
        '
        Me.IngresarDatosToolStripMenuItem1.Name = "IngresarDatosToolStripMenuItem1"
        Me.IngresarDatosToolStripMenuItem1.Size = New System.Drawing.Size(214, 22)
        Me.IngresarDatosToolStripMenuItem1.Text = "Ingresar Datos"
        '
        'CalculadoraExternaToolStripMenuItem
        '
        Me.CalculadoraExternaToolStripMenuItem.Name = "CalculadoraExternaToolStripMenuItem"
        Me.CalculadoraExternaToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.CalculadoraExternaToolStripMenuItem.Text = "Consultar Alumnos"
        '
        'ImprimirLitsaDeAlumnosToolStripMenuItem
        '
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem.Name = "ImprimirLitsaDeAlumnosToolStripMenuItem"
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem.Text = "Imprimir Lista de Alumnos"
        '
        'UtiidadesToolStripMenuItem
        '
        Me.UtiidadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem})
        Me.UtiidadesToolStripMenuItem.Name = "UtiidadesToolStripMenuItem"
        Me.UtiidadesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.UtiidadesToolStripMenuItem.Text = "Utiidades"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'visualizarAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 450)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtRegistro)
        Me.Controls.Add(Me.txtNota3)
        Me.Controls.Add(Me.txtNota2)
        Me.Controls.Add(Me.txtNota1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbDatosAlumnos)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "visualizarAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "visualizarAlumnos"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbDatosAlumnos As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNota1 As TextBox
    Friend WithEvents txtNota2 As TextBox
    Friend WithEvents txtNota3 As TextBox
    Friend WithEvents txtRegistro As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPromedio As TextBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegresarAlInicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarDatosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CalculadoraExternaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirLitsaDeAlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtiidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
End Class
