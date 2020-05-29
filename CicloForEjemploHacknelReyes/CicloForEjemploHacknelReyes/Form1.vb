Public Class Form1
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnDesplejar.Click
        'Definicion de variables
        Dim contador As Int16
        'Arreglo
        Dim Numero(3) As Int16
        Dim Promedio As Int16
        Dim Suma As Int16

        Dim ValorIngresado As String

        'Ciclo repetitivo que llena el arreglo
        For contador = 1 To 3 Step 1
            'InputBox consulta el valor que se tomara como nota
            ValorIngresado = InputBox("Ingrese el valor ", contador, 0)
            Numero(contador) = Val(ValorIngresado)

            'Se comprueba que los valores ingresados sean correctos
            If Numero(contador) >= 0 And Numero(contador) <= 100 Then
                Suma = Suma + Numero(contador)
            Else
                MsgBox("Ha introducido un valor incorrecto, Saliendo del programa...", vbInformation)
                End
            End If

        Next

        'Impresion de resultados
        txtNota1.Text = Numero(1)
        txtNota2.Text = Numero(2)
        txtNota3.Text = Numero(3)

        'cALUCLO del promedio
        Promedio = Suma / 3

        'Impresion de resultados
        txtNotaFinal.Text = Suma
        txtPromedio.Text = Promedio

        'Se cheque el promedio e verifica los check box
        If Promedio >= 70 Then
            chboxApro.Enabled = True
            chboxApro.Checked = True
        Else
            chboxRepro.Enabled = True
            chboxRepro.Checked = True
            chboxApro.Checked = False
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chboxApro.Enabled = False
        chboxRepro.Enabled = False
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Funcion para limpiar todos los textBox
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
        chboxApro.Checked = False
        chboxRepro.Checked = False
        chboxApro.Enabled = False
        chboxApro.Enabled = False
    End Sub
End Class
