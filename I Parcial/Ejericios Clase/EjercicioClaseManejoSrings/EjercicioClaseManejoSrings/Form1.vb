Public Class ManejoStrings
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            Dim cadena As String
            If IsNumeric(txtCadena.Text) = False And txtCadena.Text <> String.Empty Then
                cadena = txtCadena.Text
                txtLonguitud.Text = cadena.Length
                txtUltimoCaracter.Text = cadena.Substring(cadena.Length - 1, 1)
                'substring(posicionCaracter, Cantidad de Caracteres)
                txtPrimerCaracter.Text = cadena.Substring(0, 1)
                txt3ro8vo.Text = cadena.Substring(2, 7)
                txtPosB.Text = cadena.IndexOf("B", 0) + 1
                txtMayusculas.Text = cadena.ToUpper
                txtMinusculas.Text = cadena.ToLower
                txtBorrarEspacios.Text = cadena.Replace("", "")
            Else
                MessageBox.Show("Ingrese Valores correctos!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub
End Class
