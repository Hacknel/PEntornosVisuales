<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.btnMini = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.BtnBolsasSolidarias = New System.Windows.Forms.Button()
        Me.LogoFront = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.panelTotal = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMuestraProg = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelSuperior.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.LogoFront, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTotal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelSuperior.Controls.Add(Me.btnMini)
        Me.panelSuperior.Controls.Add(Me.btnCerrar)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(1100, 44)
        Me.panelSuperior.TabIndex = 1
        '
        'btnMini
        '
        Me.btnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMini.BackColor = System.Drawing.Color.Transparent
        Me.btnMini.BackgroundImage = CType(resources.GetObject("btnMini.BackgroundImage"), System.Drawing.Image)
        Me.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMini.Location = New System.Drawing.Point(533, 1)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(40, 40)
        Me.btnMini.TabIndex = 1
        Me.btnMini.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(579, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'TimerOcultar
        '
        '
        'TimerMostrar
        '
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.SystemColors.Control
        Me.panelMenu.Controls.Add(Me.BtnBolsasSolidarias)
        Me.panelMenu.Controls.Add(Me.LogoFront)
        Me.panelMenu.Controls.Add(Me.Button2)
        Me.panelMenu.Controls.Add(Me.Button1)
        Me.panelMenu.Controls.Add(Me.btnMenu)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMenu.Location = New System.Drawing.Point(0, 44)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(1100, 195)
        Me.panelMenu.TabIndex = 4
        '
        'BtnBolsasSolidarias
        '
        Me.BtnBolsasSolidarias.Location = New System.Drawing.Point(399, 6)
        Me.BtnBolsasSolidarias.Name = "BtnBolsasSolidarias"
        Me.BtnBolsasSolidarias.Size = New System.Drawing.Size(104, 47)
        Me.BtnBolsasSolidarias.TabIndex = 6
        Me.BtnBolsasSolidarias.Text = "Ejercicio Entrega Bolsas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnBolsasSolidarias.UseVisualStyleBackColor = True
        '
        'LogoFront
        '
        Me.LogoFront.Image = Global.EjercicioTareaMenu.My.Resources.Resources.Logo_HacknelFRont
        Me.LogoFront.Location = New System.Drawing.Point(515, 61)
        Me.LogoFront.Name = "LogoFront"
        Me.LogoFront.Size = New System.Drawing.Size(127, 135)
        Me.LogoFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoFront.TabIndex = 5
        Me.LogoFront.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(232, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 47)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Ejercicio Libreta de Ahorro"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(72, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ejercicio Arreglos 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(1064, 0)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(36, 36)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.TabStop = False
        '
        'panelTotal
        '
        Me.panelTotal.BackColor = System.Drawing.Color.MidnightBlue
        Me.panelTotal.Controls.Add(Me.lblHora)
        Me.panelTotal.Controls.Add(Me.Label1)
        Me.panelTotal.Controls.Add(Me.PanelMuestraProg)
        Me.panelTotal.Controls.Add(Me.PictureBox1)
        Me.panelTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTotal.Location = New System.Drawing.Point(0, 0)
        Me.panelTotal.Name = "panelTotal"
        Me.panelTotal.Size = New System.Drawing.Size(1100, 900)
        Me.panelTotal.TabIndex = 2
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Kristen ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHora.Location = New System.Drawing.Point(474, 246)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(0, 29)
        Me.lblHora.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(487, 865)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "@HacknelR"
        '
        'PanelMuestraProg
        '
        Me.PanelMuestraProg.BackColor = System.Drawing.Color.MidnightBlue
        Me.PanelMuestraProg.Location = New System.Drawing.Point(12, 278)
        Me.PanelMuestraProg.Name = "PanelMuestraProg"
        Me.PanelMuestraProg.Size = New System.Drawing.Size(1076, 584)
        Me.PanelMuestraProg.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(515, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 900)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.panelTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal"
        Me.Text = "Form1"
        Me.panelSuperior.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        CType(Me.LogoFront, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTotal.ResumeLayout(False)
        Me.panelTotal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelSuperior As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMini As Button
    Friend WithEvents TimerOcultar As Timer
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelTotal As Panel
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMuestraProg As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LogoFront As PictureBox
    Friend WithEvents lblHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnBolsasSolidarias As Button
End Class
