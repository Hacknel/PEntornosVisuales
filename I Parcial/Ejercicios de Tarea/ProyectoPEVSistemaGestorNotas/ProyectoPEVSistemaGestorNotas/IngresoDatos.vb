Imports System.ComponentModel

Public Class IngresoDatos

    Private Sub IngresoDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chbAprobado.Enabled = False
        chbReprobado.Enabled = False
        txtRegistroV.Enabled = False
        txtNombreV.Enabled = False
        txtApellidosV.Enabled = False
        txtNota1V.Enabled = False
        txtNota2V.Enabled = False
        txtNota3V.Enabled = False

        btnEnviar.Enabled = False

        chbPrimerParcial.Enabled = True
        chbSegundoParcial.Enabled = False
        chbTercerParcial.Enabled = False

        txtNota1.Enabled = False
        txtNota2.Enabled = False
        txtNota3.Enabled = False

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Sub validacionesEnable(codigo As Int16)
        If codigo = 0 Then
            txtRegistroV.Enabled = False
            txtNombreV.Enabled = False
            txtApellidosV.Enabled = False
            txtNota1V.Enabled = False
            txtNota2V.Enabled = False
            txtNota3V.Enabled = False
        End If
        If codigo = 1 Then
            txtRegistroV.Enabled = True
            txtNombreV.Enabled = True
            txtApellidosV.Enabled = True
            txtNota1V.Enabled = True
            txtNota2V.Enabled = True
            txtNota3V.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Dim promedio As Double

        numeroRegistro = txtmRegistro.Text
        nombres = txtNombres.Text
        apellidos = txtApellido.Text
        nota1 = Val(txtNota1.Text)
        nota2 = Val(txtNota2.Text)
        nota3 = Val(txtNota3.Text)
        Try
            If Me.ValidateChildren And txtNombres.Text <> String.Empty And txtmRegistro.Text <> String.Empty And txtApellido.Text <> String.Empty Then
                If IsNumeric(nombres) = False And IsNumeric(apellidos) = False Then

                    If Me.Validate And txtNota1.Text <> String.Empty And txtNota2.Text <> String.Empty And txtNota3.Text <> String.Empty Then
                        If IsNumeric(txtNota1.Text) = True And IsNumeric(txtNota2.Text) = True And IsNumeric(txtNota3.Text) = True Then
                            If (nota1 >= 0 And nota1 <= 100) And (nota2 >= 0 And nota2 <= 100) And (nota3 >= 0 And nota3 <= 100) Then
                                validacionesEnable(1)
                                txtRegistroV.Text = numeroRegistro
                                txtNombreV.Text = nombres
                                txtApellidosV.Text = apellidos
                                txtNota1V.Text = nota1
                                txtNota2V.Text = nota2
                                txtNota3V.Text = nota3

                                promedio = (nota1 + nota2 + nota3) / 3

                                txtPromedio.Text = promedio

                                If promedio >= 70 Then
                                    chbAprobado.Enabled = True
                                    chbAprobado.Checked = True
                                    chbReprobado.Enabled = False
                                Else
                                    chbAprobado.Enabled = False
                                    chbAprobado.Checked = False
                                    chbReprobado.Enabled = True
                                    chbReprobado.Checked = True

                                End If

                                btnEnviar.Enabled = True
                            Else
                                MessageBox.Show("Ingrese notas entre 0 y 100!")
                            End If

                        Else
                                MessageBox.Show("Solo se permiten valores numericos!")
                        End If
                    Else
                        MessageBox.Show("Todos los campos son requeridos!")
                    End If
                Else
                    MessageBox.Show("No se permiten valores numericos!")
                End If
            Else
                MessageBox.Show("Todos los campos son requeridos!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub chbPrimerParcial_CheckedChanged(sender As Object, e As EventArgs) Handles chbPrimerParcial.CheckedChanged
        If chbPrimerParcial.Enabled = True Then
            chbSegundoParcial.Enabled = True
            txtNota1.Enabled = True
        Else
            chbSegundoParcial.Enabled = False
            chbTercerParcial.Enabled = False
        End If
    End Sub

    Private Sub chbSegundoParcial_CheckedChanged(sender As Object, e As EventArgs) Handles chbSegundoParcial.CheckedChanged
        If chbSegundoParcial.Enabled = True Then
            chbTercerParcial.Enabled = True
            txtNota2.Enabled = True
        Else
            chbTercerParcial.Enabled = False
        End If
    End Sub

    Private Sub chbTercerParcial_CheckedChanged(sender As Object, e As EventArgs) Handles chbTercerParcial.CheckedChanged
        If chbTercerParcial.Enabled = True Then
            txtNota3.Enabled = True
        Else
            txtNota3.Enabled = False
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
        validacionesEnable(0)
    End Sub
End Class