Imports System.ComponentModel

Public Class frmBolsasSolidariasTarea
    Private persona(30, 6, 17) As String
    Private contador As Integer

    Private Sub desactivar()
        'Vuleve los checkbox inactivos en el arranque y al limpiar
        chbBBasica.Enabled = False
        chbBRegular.Enabled = False
        chbBBasica.Checked = False
        chbBRegular.Checked = False
    End Sub
    Private Sub activar(tipo As Integer)
        'Funcion para activar y desacttivar los checkBox
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
    End Sub
    Private Sub frmBolsasSolidariasTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivar()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistorial.CellContentClick

    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        Dim break As Integer = 0
        '---------------------------------------------Respectivas validaciones de datos---------------------------------------------------------------------------
        If Me.ValidateChildren And txtIdentidad.Text <> String.Empty And txtIdentidad.TextLength = 13 And IsNumeric(txtIdentidad.Text) = True Then

            If Me.ValidateChildren And txtNombre.Text <> String.Empty And cmbCnatInte.SelectedItem <> String.Empty And cmbEstadoEcono.SelectedItem <> String.Empty And (chbBBasica.Checked = True Or chbBRegular.Checked = True) And cmbDepartamento.SelectedItem <> String.Empty And txtMunicipio.Text <> String.Empty Then
                If IsNumeric(txtNombre.Text) = False And IsNumeric(txtMunicipio.Text) = False Then
                    '  Ciclo para validar los datos no se dupliquen
                    'Ciclo para verificar el indice de departamento
                    For j = 0 To 17 Step 1
                        'Ciclo para verificar el indice de persona
                        'MsgBox("j0 " & j)
                        For i = 0 To 29 Step 1
                            '--------------------------------------Comprobaciones y asignaciones al los espacios del arreglo--------------------------------------

                            If txtIdentidad.Text = persona(i, 0, j) Then
                                MessageBox.Show("Este registro ya se le ha entregado Bolsa Solidaria!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit For

                            ElseIf j = cmbDepartamento.SelectedIndex Then
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

                                MessageBox.Show("Se ha registardo exitosamente a " & txtIdentidad.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                contador += 1
                                break = 1
                                Exit For

                            End If

                        Next
                        If break = 1 Then
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
        MessageBox.Show("(DOBLE)  Azúcar, manteca, avena, harina de maíz, café, cereal fortificado, espagueti, arroz blanco, frijoles, y kit de medicamentos del cuadro básico (ibuprofeno, loratadina, ranitidina, ácido fólico) ", "Descripcion Bolsa Solidaria Regular", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmbCnatInte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCnatInte.SelectedIndexChanged
        'Activara o desactivara los checkBox segun la cantifad de personas que vivan en la familia
        If cmbCnatInte.SelectedIndex >= 0 And cmbCnatInte.SelectedIndex <= 2 Then
            activar(0)
        ElseIf cmbCnatInte.SelectedIndex >= 3 And cmbCnatInte.SelectedIndex <= 9 Then
            activar(1)
        End If
    End Sub

    Private Sub cmbConsultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConsultas.SelectedIndexChanged
        '------------------- Funcion para imprimir los datos----------------

        '-----------Cero para todos los datos
        If cmbConsultas.SelectedIndex = 0 Then
            dgvHistorial.Rows.Clear()
            For l = 0 To 17 Step 1
                For i = 0 To contador Step 1
                    If persona(i, 0, l) <> "" Then
                        dgvHistorial.Rows.Add(persona(i, 0, l), persona(i, 1, l), persona(i, 2, l), persona(i, 3, l), persona(i, 4, l), persona(i, 5, l), persona(i, 6, l))
                    End If
                Next
            Next

            '-------------Si selecciona cualquiera de los departamentos se le mostrara un historial especifico
        Else
            dgvHistorial.Rows.Clear()
            For j = 1 To 18 Step 1
                If j = cmbConsultas.SelectedIndex Then
                    For k = 0 To contador Step 1
                        '-----------       -1 por que en el comboBox existe un  valor antes de los departamentos, entonces para poder
                        '-----------        acceder a los datos correctos se le resta 1
                        If persona(k, 0, j - 1) <> "" Then
                            dgvHistorial.Rows.Add(persona(k, 0, j - 1), persona(k, 1, j - 1), persona(k, 2, j - 1), persona(k, 3, j - 1), persona(k, 4, j - 1), persona(k, 5, j - 1), persona(k, 6, j - 1))
                        End If
                    Next
                End If
            Next
        End If


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Funcion para limpiar los textBox y DgV
        For Each control As Control In grpIngresoDatos.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
        desactivar()
        dgvHistorial.Rows.Clear()
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip1.SetToolTip(txtIdentidad, "Ingrese el numero de ID sin guiones")
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "Info"
    End Sub



    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Ingrese su nombre completo")
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "Info"
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip1.SetToolTip(txtMunicipio, "Ingrese su municipio de residencia actual")
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "Info"
    End Sub

    Private Sub cmbCnatInte_MouseHover(sender As Object, e As EventArgs) Handles cmbCnatInte.MouseHover
        ToolTip1.SetToolTip(cmbCnatInte, "Seleccione el numero de personas que viven en la casa")
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "Info"
    End Sub

    Private Sub cmbConsultas_MouseHover(sender As Object, e As EventArgs) Handles cmbConsultas.MouseHover
        ToolTip1.SetToolTip(cmbConsultas, "Seleccione el departamento del que desea un informe")
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "Info"
    End Sub

    Private Sub cmbEstadoEcono_MouseHover(sender As Object, e As EventArgs) Handles cmbEstadoEcono.MouseHover
        ToolTip1.SetToolTip(cmbEstadoEcono, "Seleccione la actualidad economica de la familia")
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "Info"
    End Sub

    Private Sub cmbDepartamento_MouseHover(sender As Object, e As EventArgs) Handles cmbDepartamento.MouseHover
        ToolTip1.SetToolTip(cmbDepartamento, "Seleccione el departamento donde actualmente reside")
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "Info"
    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class