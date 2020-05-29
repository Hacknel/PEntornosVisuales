Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Comentarios

        'Inicio
        Dim valor1 As Integer
        Dim Valor2 As Integer

        Dim Suma As Integer
        Dim Resta As Integer
        Dim Multiplicacion As Integer

        Dim Calc1 As Integer
        Dim Calc2 As Integer

        valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        'Proceso
        Suma = valor1 + Valor2
        Resta = valor1 - Valor2
        Multiplicacion = valor1 * Valor2

        If Valor2 = 0 Then
            txtDivision.Text = "Imposible"
        Else
            txtDivision.Text = valor1 / Valor2
        End If

        Calc1 = valor1 Mod 2
        Calc2 = Valor2 Mod 2

        If Calc1 = 0 Then
            txtPar.Text = "SI"
        Else
            txtPar.Text = "NO"
        End If

        If Calc2 = 0 Then
            txtPar2.Text = "SI"
        Else
            txtPar2.Text = "NO"
        End If


        'Salida
        txtSuma.Text = Suma
        txtResta.Text = Resta
        txtMultiplicacion.Text = Multiplicacion


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtDivision.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Clear()
        txtValor2.Clear()
        txtSuma.Clear()
        txtResta.Clear()
        txtPar2.Clear()
        txtPar.Clear()
        txtMultiplicacion.Clear()
        txtDivision.Clear()

    End Sub
End Class
