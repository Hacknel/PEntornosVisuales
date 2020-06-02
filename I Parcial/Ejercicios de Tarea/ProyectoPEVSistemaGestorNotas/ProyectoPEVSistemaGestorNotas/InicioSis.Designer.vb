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
        Me.btnConsultarAlumno = New System.Windows.Forms.Button()
        Me.btnIngresarAlumno = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SISTEMA GESTOR DE NOTAS ACADEMICAS"
        '
        'btnIngresarDatos
        '
        Me.btnIngresarDatos.Location = New System.Drawing.Point(97, 157)
        Me.btnIngresarDatos.Name = "btnIngresarDatos"
        Me.btnIngresarDatos.Size = New System.Drawing.Size(122, 39)
        Me.btnIngresarDatos.TabIndex = 0
        Me.btnIngresarDatos.Text = "INGRESAR DATOS"
        Me.btnIngresarDatos.UseVisualStyleBackColor = True
        '
        'btnConsultarAlumno
        '
        Me.btnConsultarAlumno.Location = New System.Drawing.Point(333, 157)
        Me.btnConsultarAlumno.Name = "btnConsultarAlumno"
        Me.btnConsultarAlumno.Size = New System.Drawing.Size(122, 39)
        Me.btnConsultarAlumno.TabIndex = 1
        Me.btnConsultarAlumno.Text = "CONSULTAR ALUMNO"
        Me.btnConsultarAlumno.UseVisualStyleBackColor = True
        '
        'btnIngresarAlumno
        '
        Me.btnIngresarAlumno.Location = New System.Drawing.Point(557, 157)
        Me.btnIngresarAlumno.Name = "btnIngresarAlumno"
        Me.btnIngresarAlumno.Size = New System.Drawing.Size(122, 39)
        Me.btnIngresarAlumno.TabIndex = 2
        Me.btnIngresarAlumno.Text = "IMPRIMIR LISTA DE ALUMNOS"
        Me.btnIngresarAlumno.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(333, 241)
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
        Me.Label2.Location = New System.Drawing.Point(12, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "@HacknelR ©"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 396)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresarAlumno)
        Me.Controls.Add(Me.btnConsultarAlumno)
        Me.Controls.Add(Me.btnIngresarDatos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Inicio"
        Me.Text = "Sistema Gestor de Notas Academicas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnIngresarDatos As Button
    Friend WithEvents btnConsultarAlumno As Button
    Friend WithEvents btnIngresarAlumno As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
End Class
