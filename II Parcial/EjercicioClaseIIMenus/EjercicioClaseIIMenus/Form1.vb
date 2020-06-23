Imports System.Runtime.InteropServices


Public Class Form1

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
        Private Shared Sub ReleaseCapture()
        End Sub

        <DllImport("user32.DLL", EntryPoint:="SendMessage")>
        Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
        End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub abrirFormulario(ByVal formHijo As Object)
        If panelForm.Controls.Count > 0 Then
            Me.panelForm.Controls.RemoveAt(0)

        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.panelForm.Controls.Add(frm)
        Me.panelForm.Tag = frm
        frm.Show()
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Button1.Click
        abrirFormulario(frmProductos)
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        abrirFormulario(frmEmpleados)
    End Sub
End Class
