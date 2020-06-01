Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Integer
        valor = InputBox("Ingrese un numero", "Ingreso")
        TextBox1.Text = valor
        Button2.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OPC As DialogResult
        OPC = MessageBox.Show("¿Desea Seguir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OPC = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim suma, resta, multi, valor As Integer
        Dim div As Double
        valor = Val(TextBox1.Text)
        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            multi = valor * i
            div = Format((valor / i).ToString)
            ComboBox1.Items.Add(valor & "+" & i & "= " & suma)
            ComboBox2.Items.Add(valor & "-" & i & "= " & resta)
            ComboBox3.Items.Add(valor & "x" & i & "= " & multi)
            ComboBox4.Items.Add(valor & "/" & i & "= " & div)
        Next
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub APAGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles APAGARToolStripMenuItem.Click
        End


    End Sub
End Class
