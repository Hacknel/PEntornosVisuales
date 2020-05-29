Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs)

        Dim Valor As Int16

        Valor = Val(txtValor1.Text)

        If Valor = "" Then
            MsgBox("Introduzca un valor!", vbInformation)
        ElseIf Not IsNumeric(Valor) Then

        End If

    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ChboxSuma_CheckedChanged(sender As Object, e As EventArgs) Handles ChboxSuma.CheckedChanged
        Dim Valor1 As Int16 = Val(txtValor1.Text)
        Dim Valor2 As Int16 = Val(txtValor2.Text)
        Dim Suma As Int16

        If (txtValor1.Text = "") Or (txtValor2.Text = "") Then
            MsgBox("Ingrese un Valor!", vbInformation)
        ElseIf Not IsNumeric(txtValor1.Text) Or Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor numerico!", vbInformation)
        Else
            Suma = Valor1 + Valor2
        End If

        ChboxResta.Checked = False
        ChboxMulti.Checked = False
        ChboxRaiz.Checked = False
        ChboxDivision.Checked = False
        ChboxPotencia.Checked = False

        txtResultado.Text = Suma

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Clear()
        txtValor2.Clear()
        txtResultado.Clear()
        ChboxSuma.Checked = False
        ChboxResta.Checked = False
        ChboxMulti.Checked = False
        ChboxRaiz.Checked = False
        ChboxDivision.Checked = False
        ChboxPotencia.Checked = False
    End Sub

    Private Sub ChboxResta_CheckedChanged(sender As Object, e As EventArgs) Handles ChboxResta.CheckedChanged
        Dim Valor1 As Int16 = Val(txtValor1.Text)
        Dim Valor2 As Int16 = Val(txtValor2.Text)
        Dim Resta As Int16

        If (txtValor1.Text = "") Or (txtValor2.Text = "") Then
            MsgBox("Ingrese un Valor!", vbInformation)
        ElseIf Not IsNumeric(txtValor1.Text) Or Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor numerico!", vbInformation)
        Else
            Resta = Valor1 - Valor2
        End If

        ChboxSuma.Checked = False
        ChboxMulti.Checked = False
        ChboxRaiz.Checked = False
        ChboxDivision.Checked = False
        ChboxPotencia.Checked = False

        txtResultado.Text = Resta
    End Sub

    Private Sub ChboxMulti_CheckedChanged(sender As Object, e As EventArgs) Handles ChboxMulti.CheckedChanged
        Dim Valor1 As Int16 = Val(txtValor1.Text)
        Dim Valor2 As Int16 = Val(txtValor2.Text)
        Dim Multi As Int16

        If (txtValor1.Text = "") Or (txtValor2.Text = "") Then
            MsgBox("Ingrese un Valor!", vbInformation)
        ElseIf Not IsNumeric(txtValor1.Text) Or Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor numerico!", vbInformation)
        Else
            Multi = Valor1 * Valor2
        End If

        ChboxResta.Checked = False
        ChboxSuma.Checked = False
        ChboxRaiz.Checked = False
        ChboxDivision.Checked = False
        ChboxPotencia.Checked = False

        txtResultado.Text = Multi
    End Sub

    Private Sub ChboxRaiz_CheckedChanged(sender As Object, e As EventArgs) Handles ChboxRaiz.CheckedChanged
        Dim Valor1 As Double = Val(txtValor1.Text)
        Dim Valor2 As Double = Val(txtValor2.Text)
        Dim Raiz As Double

        If (txtValor1.Text = "") Then
            MsgBox("Ingrese un Valor!", vbInformation)
        ElseIf Not IsNumeric(txtValor1.Text) Then
            MsgBox("Ingrese un valor numerico!", vbInformation)
        ElseIf Valor1 < 0 Then
            MsgBox("Ingreso Numero Negativo, El Resultado es un Numero Imaginario")
        Else
            Raiz = Math.Sqrt(Valor1)
        End If

        ChboxResta.Checked = False
        ChboxMulti.Checked = False
        ChboxSuma.Checked = False
        ChboxDivision.Checked = False
        ChboxPotencia.Checked = False

        txtResultado.Text = Raiz
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles ChboxPotencia.CheckedChanged
        Dim Valor1 As Double = Val(txtValor1.Text)
        Dim Valor2 As Double = Val(txtValor2.Text)
        Dim Elevado As Double

        If (txtValor1.Text = "") Or (txtValor2.Text = "") Then
            MsgBox("Ingrese un Valor!", vbInformation)
        ElseIf Not IsNumeric(txtValor1.Text) Or Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor numerico!", vbInformation)
        ElseIf Valor1 < 0 Then
            MsgBox("Ingreso Numero Negativo, El Resultado es un Numero Imaginario")
        Else
            Elevado = Math.Pow(Valor1, Valor2)
        End If

        ChboxResta.Checked = False
        ChboxMulti.Checked = False
        ChboxRaiz.Checked = False
        ChboxDivision.Checked = False
        ChboxSuma.Checked = False

        txtResultado.Text = Elevado
    End Sub

    Private Sub txtResultado_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged

    End Sub

    Private Sub ChboxDivision_CheckedChanged(sender As Object, e As EventArgs) Handles ChboxDivision.CheckedChanged
        Dim Valor1 As Double = Val(txtValor1.Text)
        Dim Valor2 As Double = Val(txtValor2.Text)
        Dim Division As Double

        If (txtValor1.Text = "") Or (txtValor2.Text = "") Then
            MsgBox("Ingrese un Valor!", vbInformation)
        ElseIf Not IsNumeric(txtValor1.Text) Or Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor numerico!", vbInformation)
        ElseIf Valor1 < 0 Then
            MsgBox("Ingreso Numero Negativo, El Resultado es un Numero Imaginario")
        Else
            If Valor2 = 0 Then
                MsgBox("No se puede Realizar la Division (Valor 2 = 0)")
            Else
                Division = Valor1 / Valor2
            End If
        End If

        ChboxResta.Checked = False
        ChboxMulti.Checked = False
        ChboxRaiz.Checked = False
        ChboxSuma.Checked = False
        ChboxPotencia.Checked = False

        txtResultado.Text = Division
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class