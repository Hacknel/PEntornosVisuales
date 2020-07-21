Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$")
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCorreo(LCase(txtCorreo.text)) = False Then
            MessageBox.Show("Correo invalido, 'username@iddominio.com' ", "Error")
        End If
    End Sub

    Private Sub insertarUsuario()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol, estado As String

        idUsuario = txtCodigo.text
            nombre -txtNombre.text
                apellido = txtApellido.text
            userName = txtUserName.text
            psw = txtPsw.text
            correo = txtCorreo.text
            estado = "activo"
        rol = cmbRol.text
        Try
            If cconexion =
        Catch ex As Exception

        End Try
    End Sub

End Class
