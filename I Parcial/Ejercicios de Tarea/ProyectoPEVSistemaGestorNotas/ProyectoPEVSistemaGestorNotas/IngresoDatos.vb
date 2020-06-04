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
        txtPromedio.Enabled = False

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
            txtPromedio.Enabled = False
        End If
        If codigo = 1 Then
            txtRegistroV.Enabled = True
            txtNombreV.Enabled = True
            txtApellidosV.Enabled = True
            txtNota1V.Enabled = True
            txtNota2V.Enabled = True
            txtNota3V.Enabled = True
            txtPromedio.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnValidar.Click

        numeroRegistro(contador) = txtmRegistro.Text
        nombres(contador) = txtNombres.Text
        apellidos(contador) = txtApellido.Text
        nota1(contador) = Val(txtNota1.Text)
        nota2(contador) = Val(txtNota2.Text)
        nota3(contador) = Val(txtNota3.Text)
        Try
            If Me.ValidateChildren And txtNombres.Text <> String.Empty And txtmRegistro.Text <> String.Empty And txtApellido.Text <> String.Empty And chbPrimerParcial.Checked = True Then
                If IsNumeric(nombres) = False And IsNumeric(apellidos) = False Then

                    If Me.Validate And txtNota1.Text <> String.Empty And txtNota2.Text <> String.Empty And txtNota3.Text <> String.Empty Then
                        If IsNumeric(txtNota1.Text) = True And IsNumeric(txtNota2.Text) = True And IsNumeric(txtNota3.Text) = True Then
                            If (nota1(contador) >= 0 And nota1(contador) <= 100) And (nota2(contador) >= 0 And nota2(contador) <= 100) And (nota3(contador) >= 0 And nota3(contador) <= 100) Then
                                validacionesEnable(1)
                                txtRegistroV.Text = numeroRegistro(contador)
                                txtNombreV.Text = nombres(contador)
                                txtApellidosV.Text = apellidos(contador)
                                txtNota1V.Text = nota1(contador)
                                txtNota2V.Text = nota2(contador)
                                txtNota3V.Text = nota3(contador)

                                promedio(contador) = (nota1(contador) + nota2(contador) + nota3(contador)) / 3

                                txtPromedio.Text = Math.Round(promedio(contador), 2, MidpointRounding.AwayFromZero)

                                If promedio(contador) >= 70 Then
                                    chbAprobado.Enabled = True
                                    chbAprobado.Checked = True
                                    chbReprobado.Enabled = False
                                    textAproRepro(contador) = "Aprobado"
                                Else
                                    chbAprobado.Enabled = False
                                    chbAprobado.Checked = False
                                    chbReprobado.Enabled = True
                                    chbReprobado.Checked = True
                                    textAproRepro(contador) = "Reprobado"
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
        If chbPrimerParcial.Checked = True Then
            chbSegundoParcial.Enabled = True
            txtNota1.Enabled = True
        Else
            chbSegundoParcial.Enabled = False
            chbTercerParcial.Enabled = False
            txtNota1.Enabled = False
            txtNota2.Enabled = False
        End If
    End Sub

    Private Sub chbSegundoParcial_CheckedChanged(sender As Object, e As EventArgs) Handles chbSegundoParcial.CheckedChanged
        If chbSegundoParcial.Checked = True Then
            chbTercerParcial.Enabled = True
            txtNota2.Enabled = True
        Else
            chbTercerParcial.Enabled = False
            txtNota2.Enabled = False
        End If
    End Sub

    Private Sub chbTercerParcial_CheckedChanged(sender As Object, e As EventArgs) Handles chbTercerParcial.CheckedChanged
        If chbTercerParcial.Checked = True Then
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
        For Each control As Control In GroupBox2.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
        For Each control As Control In GroupBox1.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next

        txtmRegistro.Clear()
        btnEnviar.Enabled = False

        chbAprobado.Enabled = False
        chbAprobado.Checked = False
        chbReprobado.Enabled = False
        chbReprobado.Checked = False

        chbPrimerParcial.Enabled = True
        chbSegundoParcial.Enabled = False
        chbTercerParcial.Enabled = False

        chbPrimerParcial.Checked = False
        chbSegundoParcial.Checked = False
        chbTercerParcial.Checked = False

        validacionesEnable(0)
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        AlumnoDatos(contador) = numeroRegistro(contador) + " " + nombres(contador) + " " + apellidos(contador)
        'AlumnoDatos(contador) = numeroRegistro + " " + nombres + " " + apellidos + " " + nota1.ToString + " " + nota2.ToString + " " + nota3.ToString + " " + promedio.ToString + " " + textAproRepro

        MsgBox("Alumno Registrado Correctamente", MessageBoxIcon.Information, AcceptButton)
        contador += 1
    End Sub

    Private Sub SALIRToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        End
    End Sub

    Private Sub RegresarAlInicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlInicioToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()

    End Sub

    Private Sub IngresarDatosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IngresarDatosToolStripMenuItem1.Click
        Me.Show()
    End Sub

    Private Sub CalculadoraExternaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraExternaToolStripMenuItem.Click
        'Me.Close()
        visualizarAlumnos.Show()

    End Sub

    Private Sub ImprimirLitsaDeAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirLitsaDeAlumnosToolStripMenuItem.Click
        'Me.Close()
        impresionDatos.Show()

    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        'Me.Close()
        calculadoraMini.Show()

    End Sub
End Class