Imports System.Drawing.Printing
Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class formularioImpresion
    Private Sub formularioImpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 0 To contador - 1 Step 1

            rtxtImpresion.AppendText("      " & numeroRegistro(i) & "               " & nombres(i) + " " + apellidos(i) & "                   " & nota1(i).ToString & "%                " & nota2(i).ToString & "%                     " & nota3(i).ToString & "%             " & Math.Round(promedio(i), 2, MidpointRounding.AwayFromZero) & "%        " & textAproRepro(i) & vbCrLf)
        Next

        Me.Hide()
        PPD.Document = PD
        PPD.ShowDialog()
        Me.Visible = True

        Timer1.Start()

    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
    End Sub

    Private WithEvents PD As New Printing.PrintDocument
    Private PPD As New PrintPreviewDialog With {.WindowState = FormWindowState.Maximized}

    Private Sub PD_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        Dim Bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(Bmp, New Rectangle(0, 0, Bmp.Width, Bmp.Height))
        e.Graphics.DrawImage(Bmp, 0, 0)
    End Sub

End Class