Imports System.ComponentModel

Public Class Numeros
    Private Sub btnLanzar_Click(sender As Object, e As EventArgs) Handles btnLanzar.Click
        'Declaracion de variables
        Dim cantidadNumeros As Integer = Val(txtCantNumeros1.Text)
        Dim valores, cantPares, cantImpares, cantPositivos, canNegativos, cantIngresador, suma As Integer
        Dim valor As String
        Try
            'Comprueba que el valor ingresados sea numerico y mayor a 0
            If IsNumeric(txtCantNumeros1.Text) = True And cantidadNumeros > 0 Then
                'Dependiedo de la cantidad de valores desplejara los inputbox
                For i = 1 To cantidadNumeros Step 1
                    valor = InputBox("Ingrese el valor " & i, "Ingreso de valores")
                    'Verifica que los valores sean distintos de vacio y sean numericos
                    If IsNumeric(valor) = True And valor <> String.Empty Then
                        'Se hace la respecttivas comprobaciones y asignaciones delos valores
                        valores = Val(valor)
                        cantIngresador += 1
                        suma += valores
                        txtTotalIng.Text = cantIngresador
                        txtSuma.Text = suma
                        cmbHistorial.Items.Add(valores)

                        If valores Mod 2 = 0 Then
                            cantPares += 1
                            txtPares.Text = cantPares
                        ElseIf valores Mod 2 <> 0 Then
                            cantImpares += 1
                            txtImpares.Text = cantImpares
                        End If
                        If valores > 0 Then
                            cantPositivos += 1
                            txtPositivos.Text = cantPositivos
                        ElseIf valores < 0 Then
                            canNegativos += 1
                            txtNegativo.Text = canNegativos
                        End If
                    Else
                        MessageBox.Show("Ingrese Solo valores numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Ingrese Solo valores numericos y mayores a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtCantNumeros1_Validating(sender As Object, e As CancelEventArgs) Handles txtCantNumeros1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        MenuInicio.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
        For Each control As Control In Resultados.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
    End Sub

End Class