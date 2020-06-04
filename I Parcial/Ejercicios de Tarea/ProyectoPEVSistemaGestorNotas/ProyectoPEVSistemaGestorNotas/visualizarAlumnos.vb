Public Class visualizarAlumnos
    Private Sub cmbDatosAlumnos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDatosAlumnos.SelectedIndexChanged
        Dim idCmb As Integer



        idCmb = cmbDatosAlumnos.SelectedIndex

        For j = 0 To idCmb Step 1
            If j = idCmb Then
                txtRegistro.Text = numeroRegistro(j)
                txtNombres.Text = nombres(j)
                txtApellidos.Text = apellidos(j)
                txtNota1.Text = nota1(j)
                txtNota2.Text = nota2(j)
                txtNota3.Text = nota3(j)
                txtPromedio.Text = Math.Round(promedio(j), 2, MidpointRounding.AwayFromZero)
                txtEstado.Text = textAproRepro(j)
            End If
        Next

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub visualizarAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtRegistro.Enabled = False
        txtNombres.Enabled = False
        txtApellidos.Enabled = False
        txtNota1.Enabled = False
        txtNota2.Enabled = False
        txtNota3.Enabled = False
        txtPromedio.Enabled = False
        txtEstado.Enabled = False

        For i = 0 To contador - 1 Step 1
            cmbDatosAlumnos.Items.Add(AlumnoDatos(i))
        Next

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        End
    End Sub

    Private Sub RegresarAlInicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlInicioToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()

    End Sub

    Private Sub IngresarDatosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IngresarDatosToolStripMenuItem1.Click
        IngresoDatos.Show()
        'Me.Close()
    End Sub

    Private Sub CalculadoraExternaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraExternaToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ImprimirLitsaDeAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirLitsaDeAlumnosToolStripMenuItem.Click
        impresionDatos.Show()
        'Me.Close()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        calculadoraMini.Show()
        'Me.Close()
    End Sub
End Class