Imports System.Runtime.InteropServices
Public Class MenuPrincipal

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    'Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
    'btnMax.Visible = False
    'btnRestaura.Visible = True
    'indowState = FormWindowState.Maximized
    'End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Private Sub btnRestaura_Click(sender As Object, e As EventArgs) Handles btnRestaura.Click
    'btnRestaura.Visible = False
    'btnMax.Visible = True
    'Me.WindowState = FormWindowState.Normal
    'End Sub

    Private Sub TimerOcultarMenu_Tick(sender As Object, e As EventArgs) Handles TimerOcultar.Tick
        If panelMenu.Height <= 55 Then
            Me.TimerOcultar.Enabled = False
        Else
            Me.panelMenu.Height = panelMenu.Height - 20
        End If
    End Sub

    Private Sub TimerMostrar_Tick(sender As Object, e As EventArgs) Handles TimerMostrar.Tick
        If panelMenu.Height >= 195 Then
            Me.TimerMostrar.Enabled = False
        Else
            Me.panelMenu.Height = panelMenu.Height + 20
        End If
    End Sub

    Private Sub btnMenu_Click_2(sender As Object, e As EventArgs) Handles btnMenu.Click
        If panelMenu.Height = 195 Then
            TimerOcultar.Enabled = True
            LogoFront.Visible = False
        ElseIf panelMenu.Height = 55 Then
            TimerMostrar.Enabled = True
            'panelMenu.BackColor = Color.MidnightBlue
            LogoFront.Visible = True
        End If

    End Sub

    Private Sub abrirFormulario(ByVal formHijo As Object)
        If PanelMuestraProg.Controls.Count > 0 Then
            Me.PanelMuestraProg.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelMuestraProg.Controls.Add(frm)
        Me.PanelMuestraProg.Tag = frm
        frm.Show()
        Me.TimerOcultar.Enabled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        abrirFormulario(ArreglosClase)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFormulario(frmLibretaAhorroClase)
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        'LogoFront.Visible = False
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = String.Format("{0:G}", DateTime.Now)
    End Sub

    Private Sub BtnBolsasSolidarias_Click(sender As Object, e As EventArgs) Handles BtnBolsasSolidarias.Click
        abrirFormulario(frmBolsasSolidariasTarea)
    End Sub
End Class
