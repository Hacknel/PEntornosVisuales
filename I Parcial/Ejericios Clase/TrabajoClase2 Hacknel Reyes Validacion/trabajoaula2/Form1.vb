Public Class Form1
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim valor As Int16
        If txtnumero.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtnumero.text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtnumero.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtnumero.Text)
            If valor = 0 Then
                MsgBox("Numero Cero", vbInformation)
            ElseIf valor > 0 Then
                MsgBox("Numero positivo")
            ElseIf valor < 0 Then
                MsgBox("Numero negativo")

            End If

        End If
    End Sub

    Private Sub txtnumero_TextChanged(sender As Object, e As EventArgs) Handles txtnumero.TextChanged

    End Sub
End Class
