<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.dgvEstadoTraba = New System.Windows.Forms.DataGridView()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.dgvNiIdea = New System.Windows.Forms.DataGridView()
        Me.cmbCambioPedido = New System.Windows.Forms.ComboBox()
        Me.cmbCambioPersonal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvEstadoTraba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNiIdea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEstadoTraba
        '
        Me.dgvEstadoTraba.AllowUserToAddRows = False
        Me.dgvEstadoTraba.AllowUserToDeleteRows = False
        Me.dgvEstadoTraba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstadoTraba.Location = New System.Drawing.Point(12, 12)
        Me.dgvEstadoTraba.Name = "dgvEstadoTraba"
        Me.dgvEstadoTraba.ReadOnly = True
        Me.dgvEstadoTraba.Size = New System.Drawing.Size(426, 150)
        Me.dgvEstadoTraba.TabIndex = 0
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Location = New System.Drawing.Point(12, 198)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.Size = New System.Drawing.Size(426, 150)
        Me.dgvPedidos.TabIndex = 1
        '
        'dgvNiIdea
        '
        Me.dgvNiIdea.AllowUserToAddRows = False
        Me.dgvNiIdea.AllowUserToDeleteRows = False
        Me.dgvNiIdea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNiIdea.Location = New System.Drawing.Point(655, 137)
        Me.dgvNiIdea.Name = "dgvNiIdea"
        Me.dgvNiIdea.Size = New System.Drawing.Size(381, 150)
        Me.dgvNiIdea.TabIndex = 2
        '
        'cmbCambioPedido
        '
        Me.cmbCambioPedido.FormattingEnabled = True
        Me.cmbCambioPedido.Items.AddRange(New Object() {"Espera", "Ejecucion", "Entregado"})
        Me.cmbCambioPedido.Location = New System.Drawing.Point(655, 54)
        Me.cmbCambioPedido.Name = "cmbCambioPedido"
        Me.cmbCambioPedido.Size = New System.Drawing.Size(156, 21)
        Me.cmbCambioPedido.TabIndex = 3
        '
        'cmbCambioPersonal
        '
        Me.cmbCambioPersonal.FormattingEnabled = True
        Me.cmbCambioPersonal.Items.AddRange(New Object() {"Libre", "Ocupado"})
        Me.cmbCambioPersonal.Location = New System.Drawing.Point(856, 54)
        Me.cmbCambioPersonal.Name = "cmbCambioPersonal"
        Me.cmbCambioPersonal.Size = New System.Drawing.Size(156, 21)
        Me.cmbCambioPersonal.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(695, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ESTADO PEDIDO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(897, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ESTADO PERSONAL"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(775, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 426)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCambioPersonal)
        Me.Controls.Add(Me.cmbCambioPedido)
        Me.Controls.Add(Me.dgvNiIdea)
        Me.Controls.Add(Me.dgvPedidos)
        Me.Controls.Add(Me.dgvEstadoTraba)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgvEstadoTraba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNiIdea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEstadoTraba As DataGridView
    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents dgvNiIdea As DataGridView
    Friend WithEvents cmbCambioPedido As ComboBox
    Friend WithEvents cmbCambioPersonal As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
