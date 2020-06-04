<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class impresionDatos
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(173, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Impresion de Datos"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(470, 239)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(95, 29)
        Me.btnSalir.TabIndex = 38
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(360, 239)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 29)
        Me.btnVolver.TabIndex = 37
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 46)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Impresion a Archivo de Texto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(314, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 46)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Impresion a Pantalla"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.InicioToolStripMenuItem, Me.IngresarDatosToolStripMenuItem, Me.UtiidadesToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(581, 24)
        Me.MenuStrip.TabIndex = 41
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
        'impresionDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 283)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "impresionDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "impresionDatos"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarDatosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CalculadoraExternaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirLitsaDeAlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtiidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegresarAlInicioToolStripMenuItem As ToolStripMenuItem
End Class
