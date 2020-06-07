Imports System.ComponentModel

Public Class FormulaCuadratica
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Se declaran las varibales a utlizar y se asignan sus valores como double
        Dim valorA As Double = Val(txtA.Text)
        Dim valorB As Double = Val(txtB.Text)
        Dim valorC As Double = Val(txtC.Text)
        Dim respuesta1 As Double
        Dim respuesta2 As Double
        Dim aux As Double
        Dim auxI As Double
        Dim auxI2 As Double

        'Se realiza el calculo de los primeros valores
        aux = (Math.Pow(-valorB, 2) - (4 * valorA * valorC))

        'Comprobacion de los respectivos textbox
        If Me.ValidateChildren And txtA.Text <> String.Empty And txtB.Text <> String.Empty And txtC.Text <> String.Empty Then
            If IsNumeric(valorA) = True And IsNumeric(valorA) = True And IsNumeric(valorC) = True Then
                'Defineque ti[pde solucion tendra la ecuacion
                If valorA <> 0 Then
                    'si tiene solucion real
                    If aux > 0 Then
                        respuesta1 = (-1 * (valorB) + Math.Sqrt(aux)) / (2 * valorA)
                        respuesta2 = (-1 * (valorB) - Math.Sqrt(aux)) / (2 * valorA)
                        'Redondeo e impresion
                        txtRes1.Text = Math.Round(respuesta1, 2, MidpointRounding.AwayFromZero)
                        txtRes2.Text = Math.Round(respuesta2, 2, MidpointRounding.AwayFromZero)
                    Else
                        'Si tiene solucion imaginaria
                        auxI = -valorB / (2 * valorA)
                        auxI2 = Math.Sqrt(Math.Abs(aux)) / (2 * valorA)
                        'Redondeo e impresion
                        txtRes1.Text = Math.Round(auxI, 2, MidpointRounding.AwayFromZero) & "+" & Math.Round(auxI2, 2, MidpointRounding.AwayFromZero) & "i"
                        txtRes2.Text = Math.Round(auxI, 2, MidpointRounding.AwayFromZero) & "-" & Math.Round(auxI2, 2, MidpointRounding.AwayFromZero) & "i"


                    End If
                Else
                    MsgBox("Solo se permiten valores numericos")
                End If
            End If
        End If



    End Sub

    Private Sub txtA_Validating(sender As Object, e As CancelEventArgs) Handles txtA.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio")
            txtA.Clear()
        End If
    End Sub

    Private Sub txtB_Validating(sender As Object, e As CancelEventArgs) Handles txtB.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio, si es 0 introduzcalo")
            txtA.Clear()
        End If
    End Sub

    Private Sub txtC_Validating(sender As Object, e As CancelEventArgs) Handles txtC.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligatorio, si es 0 introduzcalo")
            txtA.Clear()
        End If
    End Sub

    Private Sub txtA_MouseHover(sender As Object, e As EventArgs) Handles txtA.MouseHover
        toolTip.SetToolTip(txtA, "X^2")
        toolTip.ToolTipTitle = "Valor X"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtB_MouseHover(sender As Object, e As EventArgs) Handles txtB.MouseHover
        toolTip.SetToolTip(txtA, "X")
        toolTip.ToolTipTitle = "Valor X"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtC_MouseHover(sender As Object, e As EventArgs) Handles txtC.MouseHover
        toolTip.SetToolTip(txtC, "Constante")
        toolTip.ToolTipTitle = "Valor C"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
        For Each control As Control In GroupBox1.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If

        Next
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs)
        Me.Close()
        MenuInicio.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub FormulaCuadratica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class