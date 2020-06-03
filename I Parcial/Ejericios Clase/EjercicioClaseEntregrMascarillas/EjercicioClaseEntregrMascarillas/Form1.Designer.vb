<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDepartamentos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCantidadDeparta = New System.Windows.Forms.TextBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMunicipios = New System.Windows.Forms.TextBox()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad Departamentos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad Municipios"
        '
        'cmbDepartamentos
        '
        Me.cmbDepartamentos.FormattingEnabled = True
        Me.cmbDepartamentos.Location = New System.Drawing.Point(149, 148)
        Me.cmbDepartamentos.Name = "cmbDepartamentos"
        Me.cmbDepartamentos.Size = New System.Drawing.Size(98, 21)
        Me.cmbDepartamentos.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad por Departamento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCantidadDeparta)
        Me.GroupBox1.Controls.Add(Me.btnSolicitar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbDepartamentos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 209)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cantidad por Departamento"
        '
        'txtCantidadDeparta
        '
        Me.txtCantidadDeparta.Location = New System.Drawing.Point(136, 47)
        Me.txtCantidadDeparta.Name = "txtCantidadDeparta"
        Me.txtCantidadDeparta.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadDeparta.TabIndex = 6
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(73, 89)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(98, 28)
        Me.btnSolicitar.TabIndex = 5
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMunicipios)
        Me.GroupBox2.Controls.Add(Me.btnEntregar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(309, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 208)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Distribucion"
        '
        'txtMunicipios
        '
        Me.txtMunicipios.Location = New System.Drawing.Point(130, 86)
        Me.txtMunicipios.Name = "txtMunicipios"
        Me.txtMunicipios.Size = New System.Drawing.Size(100, 20)
        Me.txtMunicipios.TabIndex = 8
        '
        'btnEntregar
        '
        Me.btnEntregar.Location = New System.Drawing.Point(85, 122)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(98, 28)
        Me.btnEntregar.TabIndex = 7
        Me.btnEntregar.Text = "Entregar"
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(445, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Stock"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(486, 301)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 333)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDepartamentos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCantidadDeparta As TextBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEntregar As Button
    Friend WithEvents txtMunicipios As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStock As TextBox
End Class
