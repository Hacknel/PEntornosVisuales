Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim departamentos, mascarillas As Integer

        departamentos = Val(txtCantidadDeparta.Text)

        If Me.ValidateChildren And txtCantidadDeparta.Text <> String.Empty And departamentos <= 18 Then
            For i = 1 To departamentos Step 1
                Do
                    mascarillas = Val(InputBox("Ingrese la cantidad de mascarillas " & i, "Ingresar"))
                    If mascarillas > 10000 Then
                        MessageBox.Show("Ha ingresado mas de 10000 mascarillas, imposible por su licencia de software", "Error en Cantidad de mascarillas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Loop While (mascarillas < 0 Or mascarillas > 10000)
                cmbDepartamentos.Items.Add(mascarillas)
            Next
        Else
            MessageBox.Show("Revise los datos ingresados", "Error en cantidad de departamento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamentos.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim idDepartamento, municipios As Integer
        Dim itemDepartamento As String = cmbDepartamentos.SelectedItem.ToString
        idDepartamento = cmbDepartamentos.SelectedIndex

        municipios = Val(txtMunicipios.Text)

        If Me.ValidateChildren And txtCantidadDeparta.Text <> String.Empty And municipios <= 298 Then
            For i = 0 To 17 Step 1
                If i = idDepartamento Then
                    txtStock.Text = CalculosMasca(municipios, itemDepartamento)
                    Exit For
                End If
            Next
        Else
            MessageBox.Show("Revise los datos ingresados", "Error en cantidad de productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Public Function CalculosMasca(cantidadMunicipios As Integer, itemDepartamento As String)

        Dim cantEntrega As Integer

        For i = 1 To cantidadMunicipios Step 1
            While (itemDepartamento > 0)
                cantEntrega = Val(InputBox("Ingrese la cantidad a entregar ", "Entrega de mascarillas"))
                If (itemDepartamento >= cantEntrega) Then
                    cantidadMunicipios += 1
                    itemDepartamento -= cantEntrega
                    txtStock.Text = itemDepartamento
                    Exit While
                Else
                    MessageBox.Show("No hay suficientes mascarillas", "Error en cantidad de municipios", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit For
                End If
            End While
        Next

        Return itemDepartamento

    End Function


End Class
