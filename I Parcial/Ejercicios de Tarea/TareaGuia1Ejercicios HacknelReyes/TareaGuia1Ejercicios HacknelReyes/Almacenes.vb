Imports System.ComponentModel

Public Class Almacenes

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        'Declaracion de variables
        Dim sumaTotal As Double
        Dim promedio As Double
        Dim aux As Double
        Dim valores(10) As Double

        'Asignacion de valores en el array
        valores(0) = Val(txt1A.Text)
        valores(1) = Val(txt2A.Text)
        valores(2) = Val(txt3A.Text)
        valores(3) = Val(txt4A.Text)
        valores(4) = Val(txt5A.Text)
        valores(5) = Val(txt6A.Text)
        valores(6) = Val(txt7A.Text)
        valores(7) = Val(txt8A.Text)
        valores(8) = Val(txt9A.Text)
        valores(9) = Val(txt10A.Text)

        'Comprobacion de los textBox que no esten vacios y contengan valores numericos
        If Me.ValidateChildren And txt1A.Text <> String.Empty And txt2A.Text <> String.Empty And txt3A.Text <> String.Empty And txt4A.Text <> String.Empty And txt5A.Text <> String.Empty And txt6A.Text <> String.Empty And txt7A.Text <> String.Empty And txt8A.Text <> String.Empty And txt9A.Text <> String.Empty And txt10A.Text <> String.Empty Then
            If Me.ValidateChildren And IsNumeric(txt1A.Text) = True And IsNumeric(txt2A.Text) = True And IsNumeric(txt3A.Text) = True And IsNumeric(txt4A.Text) = True And IsNumeric(txt5A.Text) = True And IsNumeric(txt6A.Text) = True And IsNumeric(txt7A.Text) = True And IsNumeric(txt8A.Text) = True And IsNumeric(txt9A.Text) = True And IsNumeric(txt10A.Text) = True Then
                'Realiza la suma de todos los valores
                For i = 0 To 9 Step 1
                    sumaTotal += valores(i)
                Next
                'Calculo del promedio
                promedio = sumaTotal / 10
                'Ordenamiento de los valores del arregl, de menor a mayor
                For j = 0 To 9 Step 1
                    For k = 0 To 9 - 1 Step 1
                        If valores(k) < valores(k + 1) Then
                            aux = valores(k + 1)
                            valores(k + 1) = valores(k)
                            valores(k) = aux
                        End If
                    Next
                Next

                For l = 0 To 9 Step 1
                    'Si un valor es mayor al promedio lo imprimira al historial
                    If valores(l) > promedio Then
                        Select Case valores(l)
                            Case txt1A.Text
                                rtxtListado.AppendText("Almacena 1A " & valores(l) & vbCrLf)
                            Case txt2A.Text
                                rtxtListado.AppendText("Almacena 2A " & valores(l) & vbCrLf)
                            Case txt3A.Text
                                rtxtListado.AppendText("Almacena 3A " & valores(l) & vbCrLf)
                            Case txt4A.Text
                                rtxtListado.AppendText("Almacena 4A " & valores(l) & vbCrLf)
                            Case txt5A.Text
                                rtxtListado.AppendText("Almacena 5A " & valores(l) & vbCrLf)
                            Case txt6A.Text
                                rtxtListado.AppendText("Almacena 6A " & valores(l) & vbCrLf)
                            Case txt7A.Text
                                rtxtListado.AppendText("Almacena 7A " & valores(l) & vbCrLf)
                            Case txt8A.Text
                                rtxtListado.AppendText("Almacena 8A " & valores(l) & vbCrLf)
                            Case txt9A.Text
                                rtxtListado.AppendText("Almacena 9A " & valores(l) & vbCrLf)
                            Case txt10A.Text
                                rtxtListado.AppendText("Almacena 10A " & valores(l) & vbCrLf)
                        End Select

                    End If
                Next
                'Impresion de los valores secundarios
                txtTotalV.Text = sumaTotal
                txtMedia.Text = promedio
            Else
                MessageBox.Show("Solo valores numericos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Todos los valores son necesarios! En case de ser 0 ingreselo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        MenuInicio.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class