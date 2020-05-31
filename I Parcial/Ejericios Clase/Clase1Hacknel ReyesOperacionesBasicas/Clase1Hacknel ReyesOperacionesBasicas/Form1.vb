Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtSuma.Text = ""
        txtValor1.Text = ""
        txtValor2.Text = ""
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Valor1 As Integer = Val(txtValor1.Text)
        Dim Valor2 As Integer = Val(txtValor2.Text)
        Dim Suma As Integer

        Suma = Valor1 + Valor2

        txtSuma.Text = Suma

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class
