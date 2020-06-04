Public Class impresionDatos

    Dim ruta = My.Computer.FileSystem.SpecialDirectories.Desktop & "\DatosAlumnos.txt"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & "       No. Registro       " & "             Nombre Completo            " & "       Nota Primer Parcial " & "   Nota Segundo Parcial " & "   Nota Tercer Parcial " & "   Promedio " & "           Estado   ", True)
        For i = 0 To contador - 1 Step 1
            My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & "      " & numeroRegistro(i) & "               " & nombres(i) + " " + apellidos(i) & "                   " & nota1(i).ToString & "%                " & nota2(i).ToString & "%                     " & nota3(i).ToString & "%             " & Math.Round(promedio(i), 2, MidpointRounding.AwayFromZero) & "%        " & textAproRepro(i), True)
        Next

        MsgBox("Archivo de texto generado correctamente!", MessageBoxIcon.Information)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formularioImpresion.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
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
        visualizarAlumnos.Show()
        'Me.Close()
    End Sub

    Private Sub ImprimirLitsaDeAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirLitsaDeAlumnosToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        calculadoraMini.Show()
        'Me.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        Inicio.Show()
    End Sub
End Class