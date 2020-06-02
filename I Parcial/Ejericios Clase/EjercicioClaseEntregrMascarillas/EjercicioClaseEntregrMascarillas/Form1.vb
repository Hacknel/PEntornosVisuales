Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim departamentos, mascarillas As Integer
        departamentos = Val(txtCantidadDeparta.Text)
        For i = 1 To departamentos Step 1
            Do
                mascarillas = InputBox("Ingrese la cantidad de mascarillas", "Ingresar")

            Loop While (mascarillas < 0 Or mascarillas > 10000)
            cmbCantDeparta.Items.Add(mascarillas)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCantDeparta.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim idDepartamento, itemDepartamento, municipios, cantEntrega As Integer
        idDepartamento = cmbDepartamento.SelectedIndex
        itemDepartamento = cmbDepartamento.SelectedItem.ToString

        municipios = Val(txtMunicipios.Text)

        Select Case idDepartamento
            Case 0
                For i = 1 To municipios Step 1
                    While (itemDepartamento > 0)

                        cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                        If (itemDepartamento > cantEntrega) Then
                            municipios += 1
                            itemDepartamento -= cantEntrega
                            txtStock.Text = itemDepartamento
                        Else
                            MessageBox.Show("No hay suficientes mascarillas", "Erro de entrega", MessageBoxButtons.OK, MessageBoxButtons.OKCancel)
                        End If
                    End While
                Next
        End Select


        txtStock.Text = itemDepartamento
    End Sub
End Class
