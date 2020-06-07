Imports System.ComponentModel

Public Class CalculoSalario
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Declaracion de variables
        Dim salarioBruto As Double = Val(txtMontoBruto.Text)
        Dim salarioNeto, aux1, aux2 As Double
        'Compruba que los valores ingresados sean correctos y numericos y no vacios
        If Me.ValidateChildren And IsNumeric(txtMontoBruto.Text) = True And txtMontoBruto.Text >= 0.01 Then
            'Valores exonerados
            If salarioBruto >= 0.01 And salarioBruto <= 17123.5 Then
                chbExonerado.Enabled = True
                chbExonerado.Checked = True
                txtSueldoNetoFinal.Text = Math.Round(salarioBruto, 2, MidpointRounding.AwayFromZero)
                txtExonerado.Text = Math.Round(salarioBruto, 2, MidpointRounding.AwayFromZero)
            End If
            'Valores con impuesto del 15%
            If salarioBruto >= 17123.51 And salarioBruto <= 24360.9 Then
                aux1 = (salarioBruto - 17123.5) * 0.15
                salarioNeto = salarioBruto - aux1
                chb15.Enabled = True
                chb15.Checked = True
                chbExonerado.Enabled = True
                chbExonerado.Checked = True
                txt15.Text = Math.Round(aux1, 2, MidpointRounding.AwayFromZero)
                txtSueldoNetoFinal.Text = Math.Round(salarioNeto, 2, MidpointRounding.AwayFromZero)
                txtExonerado.Text = "17123.5"
            End If
            'Valores con impuesto del 20%
            If salarioBruto >= 24360.91 And salarioBruto <= 52234.64 Then
                aux1 = (salarioBruto - 24360.9) * 0.2
                aux2 = aux1 + 1085.81
                salarioNeto = salarioBruto - aux2
                chb15.Enabled = True
                chb15.Checked = True
                chb20.Enabled = True
                chb20.Checked = True
                chbExonerado.Enabled = True
                chbExonerado.Checked = True
                txt15.Text = "1085.81"
                txt20.Text = Math.Round(aux1, 2, MidpointRounding.AwayFromZero)
                txtSueldoNetoFinal.Text = Math.Round(salarioNeto, 2, MidpointRounding.AwayFromZero)
                txtExonerado.Text = "17123.5"
            End If
            'Valores con impuesto al 25%
            If salarioBruto >= 52234.65 Then
                aux1 = (salarioBruto - 52234.64) * 0.25
                aux2 = aux1 + 1085.81 + 5574.75
                salarioNeto = salarioBruto - aux2
                chb15.Enabled = True
                chb15.Checked = True
                chb20.Enabled = True
                chb20.Checked = True
                chb25.Enabled = True
                chb25.Checked = True
                chbExonerado.Enabled = True
                chbExonerado.Checked = True
                txt15.Text = "1085.81"
                txt20.Text = "5574.75"
                txt25.Text = Math.Round(aux1, 2, MidpointRounding.AwayFromZero)
                txtSueldoNetoFinal.Text = Math.Round(salarioNeto, 2, MidpointRounding.AwayFromZero)
                txtExonerado.Text = "17123.5"
            End If
        Else
            MessageBox.Show("Ingrese valores numericos y mayores a 0.01!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtMontoBruto_Validating(sender As Object, e As CancelEventArgs) Handles txtMontoBruto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMontoBruto_MouseHover(sender As Object, e As EventArgs) Handles txtMontoBruto.MouseHover
        ToolTip1.SetToolTip(txtMontoBruto, "Ingrese el valor de su salario mensual")
        ToolTip1.ToolTipTitle = "Salario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub CalculoSalario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chb15.Enabled = False
        chb20.Enabled = False
        chb25.Enabled = False
        chbExonerado.Enabled = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Limpia los valores
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
        chb15.Checked = False
        chb15.Enabled = False
        chb20.Checked = False
        chb20.Enabled = False
        chb25.Checked = False
        chb25.Enabled = False
        chbExonerado.Checked = False
        chbExonerado.Enabled = False


    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
        MenuInicio.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class