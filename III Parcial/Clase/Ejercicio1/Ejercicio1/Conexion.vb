Imports System.Data.SqlClient

Public Class Conexion


    Public Function insertarUsuario(idUsuario As Integer, nombre As String, apellido As String, userName As String,
                            psw As String, rol As String, estado As String, correo As String)
        Try
            cconexion.open()
            cmb = New SqlCommand(insertarUsuario, cconexion)
            cmb.commandType = CommandType.StoredProcedure
            cmb.Parameters.addWithValue("@idUsuario", idUsuario)
            cmb.Parameters.addWithValue("@nombre", nombre)
            cmb.Parameters.addWithValue("@apellido", apellido)
            cmb.Parameters.addWithValue("@userName", userName)
            cmb.Parameters.addWithValue("@psw", psw)
            cmb.Parameters.addWithValue("@rol", rol)
            cmb.Parameters.addWithValue("@estado", estado)
            cmb.Parameters.addWithValue("@idUsuario", idUsuario)
            cmb.Parameters.addWithValue("@correo", correo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

End Class
