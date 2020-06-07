Public Class Calculadora

    Dim resultado As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim OperadorP As Boolean
    Dim historial As String
    Dim tipoOperacion As String

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        EvaluarConcatenacion()
        txtResultado.Text &= "0"
        historial &= "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        EvaluarConcatenacion()
        txtResultado.Text &= "1"
        historial &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        EvaluarConcatenacion()
        txtResultado.Text &= "2"
        historial &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        EvaluarConcatenacion()
        txtResultado.Text &= "3"
        historial &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        EvaluarConcatenacion()
        txtResultado.Text &= "4"
        historial &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        EvaluarConcatenacion()
        txtResultado.Text &= "5"
        historial &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        EvaluarConcatenacion()
        txtResultado.Text &= "6"
        historial &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        EvaluarConcatenacion()
        txtResultado.Text &= "7"
        historial &= "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluarConcatenacion()
        txtResultado.Text &= "8"
        historial &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        EvaluarConcatenacion()
        txtResultado.Text &= "9"
        historial &= "9"
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        Operaciones()
        tipoOperacion = "/"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Operaciones()
        tipoOperacion = "x"
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Operaciones()
        tipoOperacion = "-"
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Operaciones()
        tipoOperacion = "+"
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Operaciones()
        tipoOperacion = "="
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtResultado.Clear()
        valor2 = Nothing
        resultado = Nothing 
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        MenuInicio.Show()
    End Sub

    Public Sub Operaciones()
        OperadorP = True
        valor2 = Val(txtResultado.Text)

        If resultado IsNot Nothing Then
            If tipoOperacion = "+" Then
                resultado += valor2
                historial &= "+"
            End If
            If tipoOperacion = "-" Then
                resultado -= valor2
                historial &= "-"
            End If
            If tipoOperacion = "x" Then
                resultado *= valor2
                historial &= "x"
            End If
            If tipoOperacion = "/" Then
                If valor2 <> 0 Then
                    resultado += valor2
                    historial &= "÷"
                Else
                    MsgBox("Division por 0 Error Matematico")
                End If
            End If
            If tipoOperacion = "=" Then
                txtResultado.Text = resultado
                rtxtHistorial.AppendText(historial & "=" & resultado & vbCrLf)
            End If
        Else
            resultado = valor2
            txtResultado.Text = valor2
        End If
    End Sub

    Public Sub EvaluarConcatenacion()
        If OperadorP = True Then
            txtResultado.Text = ""
            OperadorP = False
        ElseIf txtResultado.Text = "0" Then
            txtResultado.Text = ""
        End If
    End Sub

End Class