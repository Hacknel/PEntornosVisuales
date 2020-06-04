Public Class Inicio

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CantidadAlumnos = Val(InputBox("Ingrese la cantidad de alumnos manejara"))
    End Sub

    Private Sub btnIngresarDatos_Click(sender As Object, e As EventArgs) Handles btnIngresarDatos.Click
        IngresoDatos.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        visualizarAlumnos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        calculadoraMini.Show()
    End Sub

    Private Sub btnIngresarAlumno_Click(sender As Object, e As EventArgs) Handles btnIngresarAlumno.Click
        impresionDatos.Show()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        End
    End Sub

    Private Sub RegresarAlInicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlInicioToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub IngresarDatosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IngresarDatosToolStripMenuItem1.Click
        IngresoDatos.Show()

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
