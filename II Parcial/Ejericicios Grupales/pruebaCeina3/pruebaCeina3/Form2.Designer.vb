<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.txtIdSector = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbEmpresas = New System.Windows.Forms.ComboBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtRef = New System.Windows.Forms.TextBox()
        Me.txtRefR = New System.Windows.Forms.TextBox()
        Me.btnConsultarR = New System.Windows.Forms.Button()
        Me.cmbEmpresasR = New System.Windows.Forms.ComboBox()
        Me.txtNombreR = New System.Windows.Forms.TextBox()
        Me.txtIdSectorR = New System.Windows.Forms.TextBox()
        Me.txtBarrioR = New System.Windows.Forms.TextBox()
        Me.txtTelefonoR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbEncargado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEstadoPersona = New System.Windows.Forms.ComboBox()
        Me.RealizarPedido = New System.Windows.Forms.Button()
        Me.txtDetalles = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbTipoEnvio = New System.Windows.Forms.ComboBox()
        Me.btnDesplejarHist = New System.Windows.Forms.Button()
        Me.cmbEstadoPaquete = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDinero = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar Pedido"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(47, 75)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(117, 20)
        Me.txtTelefono.TabIndex = 1
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(47, 226)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(117, 20)
        Me.txtBarrio.TabIndex = 3
        '
        'txtIdSector
        '
        Me.txtIdSector.Location = New System.Drawing.Point(190, 174)
        Me.txtIdSector.Name = "txtIdSector"
        Me.txtIdSector.Size = New System.Drawing.Size(117, 20)
        Me.txtIdSector.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(47, 174)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(117, 20)
        Me.txtNombre.TabIndex = 7
        '
        'cmbEmpresas
        '
        Me.cmbEmpresas.FormattingEnabled = True
        Me.cmbEmpresas.Location = New System.Drawing.Point(190, 75)
        Me.cmbEmpresas.Name = "cmbEmpresas"
        Me.cmbEmpresas.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpresas.TabIndex = 8
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(137, 119)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 9
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtRef
        '
        Me.txtRef.Location = New System.Drawing.Point(190, 226)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(117, 20)
        Me.txtRef.TabIndex = 10
        '
        'txtRefR
        '
        Me.txtRefR.Location = New System.Drawing.Point(514, 226)
        Me.txtRefR.Name = "txtRefR"
        Me.txtRefR.Size = New System.Drawing.Size(117, 20)
        Me.txtRefR.TabIndex = 18
        '
        'btnConsultarR
        '
        Me.btnConsultarR.Location = New System.Drawing.Point(461, 119)
        Me.btnConsultarR.Name = "btnConsultarR"
        Me.btnConsultarR.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultarR.TabIndex = 17
        Me.btnConsultarR.Text = "Consultar"
        Me.btnConsultarR.UseVisualStyleBackColor = True
        '
        'cmbEmpresasR
        '
        Me.cmbEmpresasR.FormattingEnabled = True
        Me.cmbEmpresasR.Location = New System.Drawing.Point(514, 75)
        Me.cmbEmpresasR.Name = "cmbEmpresasR"
        Me.cmbEmpresasR.Size = New System.Drawing.Size(121, 21)
        Me.cmbEmpresasR.TabIndex = 16
        '
        'txtNombreR
        '
        Me.txtNombreR.Location = New System.Drawing.Point(371, 174)
        Me.txtNombreR.Name = "txtNombreR"
        Me.txtNombreR.Size = New System.Drawing.Size(117, 20)
        Me.txtNombreR.TabIndex = 15
        '
        'txtIdSectorR
        '
        Me.txtIdSectorR.Location = New System.Drawing.Point(514, 174)
        Me.txtIdSectorR.Name = "txtIdSectorR"
        Me.txtIdSectorR.Size = New System.Drawing.Size(117, 20)
        Me.txtIdSectorR.TabIndex = 14
        '
        'txtBarrioR
        '
        Me.txtBarrioR.Location = New System.Drawing.Point(371, 226)
        Me.txtBarrioR.Name = "txtBarrioR"
        Me.txtBarrioR.Size = New System.Drawing.Size(117, 20)
        Me.txtBarrioR.TabIndex = 13
        '
        'txtTelefonoR
        '
        Me.txtTelefonoR.Location = New System.Drawing.Point(371, 75)
        Me.txtTelefonoR.Name = "txtTelefonoR"
        Me.txtTelefonoR.Size = New System.Drawing.Size(117, 20)
        Me.txtTelefonoR.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "RECIBIDOR"
        '
        'cmbEncargado
        '
        Me.cmbEncargado.FormattingEnabled = True
        Me.cmbEncargado.Location = New System.Drawing.Point(712, 75)
        Me.cmbEncargado.Name = "cmbEncargado"
        Me.cmbEncargado.Size = New System.Drawing.Size(99, 21)
        Me.cmbEncargado.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(708, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "ENCARGADO"
        '
        'cmbEstadoPersona
        '
        Me.cmbEstadoPersona.FormattingEnabled = True
        Me.cmbEstadoPersona.Items.AddRange(New Object() {"Libre", "Ocupado"})
        Me.cmbEstadoPersona.Location = New System.Drawing.Point(832, 75)
        Me.cmbEstadoPersona.Name = "cmbEstadoPersona"
        Me.cmbEstadoPersona.Size = New System.Drawing.Size(72, 21)
        Me.cmbEstadoPersona.TabIndex = 21
        '
        'RealizarPedido
        '
        Me.RealizarPedido.Location = New System.Drawing.Point(980, 45)
        Me.RealizarPedido.Name = "RealizarPedido"
        Me.RealizarPedido.Size = New System.Drawing.Size(232, 328)
        Me.RealizarPedido.TabIndex = 27
        Me.RealizarPedido.Text = "TAS BIEN"
        Me.RealizarPedido.UseVisualStyleBackColor = True
        '
        'txtDetalles
        '
        Me.txtDetalles.Location = New System.Drawing.Point(711, 226)
        Me.txtDetalles.Name = "txtDetalles"
        Me.txtDetalles.Size = New System.Drawing.Size(117, 20)
        Me.txtDetalles.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbTipoEnvio
        '
        Me.cmbTipoEnvio.FormattingEnabled = True
        Me.cmbTipoEnvio.Location = New System.Drawing.Point(845, 173)
        Me.cmbTipoEnvio.Name = "cmbTipoEnvio"
        Me.cmbTipoEnvio.Size = New System.Drawing.Size(99, 21)
        Me.cmbTipoEnvio.TabIndex = 30
        '
        'btnDesplejarHist
        '
        Me.btnDesplejarHist.Location = New System.Drawing.Point(869, 350)
        Me.btnDesplejarHist.Name = "btnDesplejarHist"
        Me.btnDesplejarHist.Size = New System.Drawing.Size(75, 23)
        Me.btnDesplejarHist.TabIndex = 31
        Me.btnDesplejarHist.Text = "Button2"
        Me.btnDesplejarHist.UseVisualStyleBackColor = True
        '
        'cmbEstadoPaquete
        '
        Me.cmbEstadoPaquete.FormattingEnabled = True
        Me.cmbEstadoPaquete.Items.AddRange(New Object() {"Espera", "Ejecucion"})
        Me.cmbEstadoPaquete.Location = New System.Drawing.Point(711, 173)
        Me.cmbEstadoPaquete.Name = "cmbEstadoPaquete"
        Me.cmbEstadoPaquete.Size = New System.Drawing.Size(99, 21)
        Me.cmbEstadoPaquete.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(678, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "estado paquete"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(863, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "estado personal"
        '
        'txtDinero
        '
        Me.txtDinero.Location = New System.Drawing.Point(561, 325)
        Me.txtDinero.Name = "txtDinero"
        Me.txtDinero.Size = New System.Drawing.Size(117, 20)
        Me.txtDinero.TabIndex = 35
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(697, 322)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 36
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 450)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtDinero)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbEstadoPaquete)
        Me.Controls.Add(Me.btnDesplejarHist)
        Me.Controls.Add(Me.cmbTipoEnvio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDetalles)
        Me.Controls.Add(Me.RealizarPedido)
        Me.Controls.Add(Me.cmbEstadoPersona)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbEncargado)
        Me.Controls.Add(Me.txtRefR)
        Me.Controls.Add(Me.btnConsultarR)
        Me.Controls.Add(Me.cmbEmpresasR)
        Me.Controls.Add(Me.txtNombreR)
        Me.Controls.Add(Me.txtIdSectorR)
        Me.Controls.Add(Me.txtBarrioR)
        Me.Controls.Add(Me.txtTelefonoR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRef)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.cmbEmpresas)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIdSector)
        Me.Controls.Add(Me.txtBarrio)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtBarrio As TextBox
    Friend WithEvents txtIdSector As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cmbEmpresas As ComboBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtRef As TextBox
    Friend WithEvents txtRefR As TextBox
    Friend WithEvents btnConsultarR As Button
    Friend WithEvents cmbEmpresasR As ComboBox
    Friend WithEvents txtNombreR As TextBox
    Friend WithEvents txtIdSectorR As TextBox
    Friend WithEvents txtBarrioR As TextBox
    Friend WithEvents txtTelefonoR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEncargado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbEstadoPersona As ComboBox
    Friend WithEvents RealizarPedido As Button
    Friend WithEvents txtDetalles As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbTipoEnvio As ComboBox
    Friend WithEvents btnDesplejarHist As Button
    Friend WithEvents cmbEstadoPaquete As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDinero As TextBox
    Friend WithEvents btnCalcular As Button
End Class
