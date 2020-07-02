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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.txtTelPedi = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombrePedidor = New System.Windows.Forms.TextBox()
        Me.txtDireccionProce = New System.Windows.Forms.TextBox()
        Me.txtVehiculo = New System.Windows.Forms.TextBox()
        Me.txtPrimerNom = New System.Windows.Forms.TextBox()
        Me.txtTelManda = New System.Windows.Forms.TextBox()
        Me.txtTipoManda = New System.Windows.Forms.TextBox()
        Me.txtDetallesManda = New System.Windows.Forms.TextBox()
        Me.txtDireccionDest = New System.Windows.Forms.TextBox()
        Me.Bd_VoyVolandoCeibaDataSet = New pruebaCeina3.bd_VoyVolandoCeibaDataSet()
        Me.BdVoyVolandoCeibaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Consultar = New System.Windows.Forms.Button()
        Me.dgvProcedencia = New System.Windows.Forms.DataGridView()
        Me.dgvRecepc = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvEncarga = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbIdFacturas = New System.Windows.Forms.ComboBox()
        CType(Me.Bd_VoyVolandoCeibaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdVoyVolandoCeibaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProcedencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecepc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEncarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero de Factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(491, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tel Pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(597, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Primer Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(907, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Detalles Mandado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1242, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Primer Nombre "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1136, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tel Mandadero"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1020, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tipo de Mandado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(810, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Direccion Destino"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(689, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Direccion Procedencia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1356, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Vehiculo"
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(120, 113)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtFactura.TabIndex = 11
        '
        'txtTelPedi
        '
        Me.txtTelPedi.Location = New System.Drawing.Point(475, 52)
        Me.txtTelPedi.Name = "txtTelPedi"
        Me.txtTelPedi.Size = New System.Drawing.Size(100, 20)
        Me.txtTelPedi.TabIndex = 12
        '
        'txtPrimerNombrePedidor
        '
        Me.txtPrimerNombrePedidor.Location = New System.Drawing.Point(581, 52)
        Me.txtPrimerNombrePedidor.Name = "txtPrimerNombrePedidor"
        Me.txtPrimerNombrePedidor.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimerNombrePedidor.TabIndex = 13
        '
        'txtDireccionProce
        '
        Me.txtDireccionProce.Location = New System.Drawing.Point(692, 52)
        Me.txtDireccionProce.Name = "txtDireccionProce"
        Me.txtDireccionProce.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccionProce.TabIndex = 14
        '
        'txtVehiculo
        '
        Me.txtVehiculo.Location = New System.Drawing.Point(1331, 52)
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.Size = New System.Drawing.Size(100, 20)
        Me.txtVehiculo.TabIndex = 15
        '
        'txtPrimerNom
        '
        Me.txtPrimerNom.Location = New System.Drawing.Point(1225, 52)
        Me.txtPrimerNom.Name = "txtPrimerNom"
        Me.txtPrimerNom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimerNom.TabIndex = 16
        '
        'txtTelManda
        '
        Me.txtTelManda.Location = New System.Drawing.Point(1119, 52)
        Me.txtTelManda.Name = "txtTelManda"
        Me.txtTelManda.Size = New System.Drawing.Size(100, 20)
        Me.txtTelManda.TabIndex = 17
        '
        'txtTipoManda
        '
        Me.txtTipoManda.Location = New System.Drawing.Point(1013, 52)
        Me.txtTipoManda.Name = "txtTipoManda"
        Me.txtTipoManda.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoManda.TabIndex = 18
        '
        'txtDetallesManda
        '
        Me.txtDetallesManda.Location = New System.Drawing.Point(907, 52)
        Me.txtDetallesManda.Name = "txtDetallesManda"
        Me.txtDetallesManda.Size = New System.Drawing.Size(100, 20)
        Me.txtDetallesManda.TabIndex = 19
        '
        'txtDireccionDest
        '
        Me.txtDireccionDest.Location = New System.Drawing.Point(801, 52)
        Me.txtDireccionDest.Name = "txtDireccionDest"
        Me.txtDireccionDest.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccionDest.TabIndex = 20
        '
        'Bd_VoyVolandoCeibaDataSet
        '
        Me.Bd_VoyVolandoCeibaDataSet.DataSetName = "bd_VoyVolandoCeibaDataSet"
        Me.Bd_VoyVolandoCeibaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BdVoyVolandoCeibaDataSetBindingSource
        '
        Me.BdVoyVolandoCeibaDataSetBindingSource.DataSource = Me.Bd_VoyVolandoCeibaDataSet
        Me.BdVoyVolandoCeibaDataSetBindingSource.Position = 0
        '
        'Consultar
        '
        Me.Consultar.Location = New System.Drawing.Point(630, 551)
        Me.Consultar.Name = "Consultar"
        Me.Consultar.Size = New System.Drawing.Size(75, 23)
        Me.Consultar.TabIndex = 22
        Me.Consultar.Text = "Consultar"
        Me.Consultar.UseVisualStyleBackColor = True
        '
        'dgvProcedencia
        '
        Me.dgvProcedencia.AllowUserToDeleteRows = False
        Me.dgvProcedencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProcedencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProcedencia.Location = New System.Drawing.Point(15, 181)
        Me.dgvProcedencia.Name = "dgvProcedencia"
        Me.dgvProcedencia.ReadOnly = True
        Me.dgvProcedencia.Size = New System.Drawing.Size(641, 119)
        Me.dgvProcedencia.TabIndex = 25
        '
        'dgvRecepc
        '
        Me.dgvRecepc.AllowUserToDeleteRows = False
        Me.dgvRecepc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRecepc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecepc.Location = New System.Drawing.Point(690, 181)
        Me.dgvRecepc.Name = "dgvRecepc"
        Me.dgvRecepc.ReadOnly = True
        Me.dgvRecepc.Size = New System.Drawing.Size(641, 119)
        Me.dgvRecepc.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Procedencia"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(687, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Recepcion"
        '
        'dgvEncarga
        '
        Me.dgvEncarga.AllowUserToDeleteRows = False
        Me.dgvEncarga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEncarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEncarga.Location = New System.Drawing.Point(262, 364)
        Me.dgvEncarga.Name = "dgvEncarga"
        Me.dgvEncarga.ReadOnly = True
        Me.dgvEncarga.Size = New System.Drawing.Size(803, 131)
        Me.dgvEncarga.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(259, 333)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Encargado"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(418, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Numero de Factura"
        '
        'cmbIdFacturas
        '
        Me.cmbIdFacturas.FormattingEnabled = True
        Me.cmbIdFacturas.Location = New System.Drawing.Point(440, 113)
        Me.cmbIdFacturas.Name = "cmbIdFacturas"
        Me.cmbIdFacturas.Size = New System.Drawing.Size(50, 21)
        Me.cmbIdFacturas.TabIndex = 32
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1500, 610)
        Me.Controls.Add(Me.cmbIdFacturas)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dgvEncarga)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvProcedencia)
        Me.Controls.Add(Me.Consultar)
        Me.Controls.Add(Me.txtDireccionDest)
        Me.Controls.Add(Me.txtDetallesManda)
        Me.Controls.Add(Me.txtTipoManda)
        Me.Controls.Add(Me.txtTelManda)
        Me.Controls.Add(Me.txtPrimerNom)
        Me.Controls.Add(Me.txtVehiculo)
        Me.Controls.Add(Me.txtDireccionProce)
        Me.Controls.Add(Me.txtPrimerNombrePedidor)
        Me.Controls.Add(Me.txtTelPedi)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvRecepc)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Bd_VoyVolandoCeibaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdVoyVolandoCeibaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProcedencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecepc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEncarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents txtTelPedi As TextBox
    Friend WithEvents txtPrimerNombrePedidor As TextBox
    Friend WithEvents txtDireccionProce As TextBox
    Friend WithEvents txtVehiculo As TextBox
    Friend WithEvents txtPrimerNom As TextBox
    Friend WithEvents txtTelManda As TextBox
    Friend WithEvents txtTipoManda As TextBox
    Friend WithEvents txtDetallesManda As TextBox
    Friend WithEvents txtDireccionDest As TextBox
    Friend WithEvents BdVoyVolandoCeibaDataSetBindingSource As BindingSource
    Friend WithEvents Bd_VoyVolandoCeibaDataSet As bd_VoyVolandoCeibaDataSet
    Friend WithEvents Consultar As Button
    Friend WithEvents dgvProcedencia As DataGridView
    Friend WithEvents dgvRecepc As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvEncarga As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbIdFacturas As ComboBox
End Class
