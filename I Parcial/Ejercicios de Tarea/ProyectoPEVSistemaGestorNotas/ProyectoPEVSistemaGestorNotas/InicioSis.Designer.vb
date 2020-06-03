<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.btnIngresarDatos = New System.Windows.Forms.Button()
        Me.btnIngresarAlumno = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarDatosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraExternaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SISTEMA GESTOR DE NOTAS ACADEMICAS"
        '
        'btnIngresarDatos
        '
        Me.btnIngresarDatos.Location = New System.Drawing.Point(65, 129)
        Me.btnIngresarDatos.Name = "btnIngresarDatos"
        Me.btnIngresarDatos.Size = New System.Drawing.Size(122, 39)
        Me.btnIngresarDatos.TabIndex = 0
        Me.btnIngresarDatos.Text = "INGRESAR DATOS"
        Me.btnIngresarDatos.UseVisualStyleBackColor = True
        '
        'btnIngresarAlumno
        '
        Me.btnIngresarAlumno.Location = New System.Drawing.Point(265, 129)
        Me.btnIngresarAlumno.Name = "btnIngresarAlumno"
        Me.btnIngresarAlumno.Size = New System.Drawing.Size(122, 39)
        Me.btnIngresarAlumno.TabIndex = 2
        Me.btnIngresarAlumno.Text = "IMPRIMIR LISTA DE ALUMNOS"
        Me.btnIngresarAlumno.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(168, 212)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(122, 39)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "@HacknelR ©"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.IngresarDatosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(481, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.CalculadoraExternaToolStripMenuItem.Text = "Calculadora"
        '
        'ImprimirLitsaDeAlumnosToolStripMenuItem
        '
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem.Name = "ImprimirLitsaDeAlumnosToolStripMenuItem"
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ImprimirLitsaDeAlumnosToolStripMenuItem.Text = "Imprimir Lista de Alumnos"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 318)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresarAlumno)
        Me.Controls.Add(Me.btnIngresarDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
        Me.Text = "Sistema Gestor de Notas Academicas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnIngresarDatos As Button
    Friend WithEvents btnIngresarAlumno As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarDatosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CalculadoraExternaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirLitsaDeAlumnosToolStripMenuItem As ToolStripMenuItem
End Class
