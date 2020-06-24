Public Class frmBolsasSolidariasTarea
    Private persona(30, 6, 17) As String
    Private contador As Integer

    Private Sub desactivar()
        chbBBasica.Enabled = False
        chbBRegular.Enabled = False
        chbBBasica.Checked = False
        chbBRegular.Checked = False
    End Sub
    Private Function activar(tipo As Integer)
        If tipo = 0 Then
            chbBBasica.Enabled = True
            chbBBasica.Checked = True
            If chbBBasica.Checked = True Then
                chbBRegular.Checked = False
                chbBRegular.Enabled = False
            End If

        ElseIf tipo = 1 Then
            chbBRegular.Enabled = True
            chbBRegular.Checked = True
            If chbBRegular.Checked = True Then
                chbBBasica.Checked = False
                chbBBasica.Enabled = False
            End If

        End If

        Return tipo
    End Function
    Private Sub frmBolsasSolidariasTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivar()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistorial.CellContentClick

    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        If Me.ValidateChildren And txtIdentidad.Text <> String.Empty And txtIdentidad.TextLength = 13 And IsNumeric(txtIdentidad.Text) = True Then

            If Me.ValidateChildren And txtNombre.Text <> String.Empty And cmbCnatInte.SelectedItem <> String.Empty And cmbEstadoEcono.SelectedItem <> String.Empty And (chbBBasica.Checked = True Or chbBRegular.Checked = True) And cmbDepartamento.SelectedItem <> String.Empty And txtMunicipio.Text <> String.Empty Then
                If IsNumeric(txtNombre.Text) = False And IsNumeric(txtMunicipio.Text) = False Then

                    For i = 0 To 29 Step 1
                        If txtIdentidad.Text = persona(i, 0, i) Then
                            MessageBox.Show("Este registro ya se le ha entregado Bolsa Solidaria!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit For
                        Else
                            For j = 0 To 17 Step 1
                                If j = cmbDepartamento.SelectedIndex Then
                                    MsgBox(j)
                                    persona(contador, 0, j) = txtIdentidad.Text
                                    persona(contador, 1, j) = txtNombre.Text
                                    persona(contador, 2, j) = cmbCnatInte.Text
                                    persona(contador, 3, j) = cmbEstadoEcono.Text
                                    If chbBBasica.Checked = True Then
                                        persona(contador, 4, j) = "Basica"
                                    ElseIf chbBRegular.Checked = True Then
                                        persona(contador, 4, j) = "Regular"
                                    End If
                                    persona(contador, 5, j) = cmbDepartamento.Text
                                    persona(contador, 6, j) = txtMunicipio.Text

                                    MsgBox(persona(0, 0, 0))

                                    contador += 1
                                End If
                            Next

                            Exit For
                        End If
                    Next
                Else
                    MessageBox.Show("No se permiten valores numericos en Nombre y Ciudad!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                    MessageBox.Show("Todos los campos son obligatorios!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
                MessageBox.Show("Ingrese una identidad numerica correcta de 13 caracteres!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnConsultarContBasi_Click(sender As Object, e As EventArgs) Handles btnConsultarContBasi.Click
        MessageBox.Show("Azúcar, manteca, avena, harina de maíz, café, cereal fortificado, espagueti, arroz blanco, frijoles, y kit de medicamentos del cuadro básico (ibuprofeno, loratadina, ranitidina, ácido fólico) ", "Descripcion Bolsa Solidaria Basica", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnConsultarContRegu_Click(sender As Object, e As EventArgs) Handles btnConsultarContRegu.Click
        MessageBox.Show("Azúcar, manteca, avena, harina de maíz, café, cereal fortificado, espagueti, arroz blanco, frijoles, y kit de medicamentos del cuadro básico (ibuprofeno, loratadina, ranitidina, ácido fólico) ", "Descripcion Bolsa Solidaria Regular", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmbCnatInte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCnatInte.SelectedIndexChanged
        If cmbCnatInte.SelectedIndex >= 0 And cmbCnatInte.SelectedIndex <= 2 Then
            activar(0)
        ElseIf cmbCnatInte.SelectedIndex >= 3 And cmbCnatInte.SelectedIndex <= 9 Then
            activar(1)
        End If
    End Sub

    Private Sub cmbConsultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConsultas.SelectedIndexChanged
        Dim i As Integer = 0
        Dim k As Integer = 0

        If cmbConsultas.SelectedIndex = 0 Then
            Do While persona(i, 0, i) <> ""
                dgvHistorial.Rows.Add(persona(i, 0, i), persona(i, 1, i), persona(i, 2, i), persona(i, 3, i), persona(i, 4, i), persona(i, 5, i), persona(i, 6, i))
                i += 1
                MsgBox(i)
            Loop
        Else
            For j = 1 To 18 Step 1
                If j = cmbConsultas.SelectedIndex Then

                    Do While persona(k, 0, j) <> ""
                        dgvHistorial.Rows.Add(persona(k, 0, j), persona(k, 1, j), persona(k, 2, j), persona(k, 3, j), persona(k, 4, j), persona(k, 5, j), persona(k, 6, j))
                        k += 1

                    Loop

                End If
            Next
        End If


    End Sub
End Class