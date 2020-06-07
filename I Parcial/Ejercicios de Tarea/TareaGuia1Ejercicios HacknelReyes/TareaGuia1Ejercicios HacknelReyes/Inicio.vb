Public Class MenuInicio
    Private Sub btnCalculadora_Click(sender As Object, e As EventArgs) Handles btnCalculadora.Click
        Calculadora.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCuadratica_Click(sender As Object, e As EventArgs) Handles btnCuadratica.Click
        FormulaCuadratica.Show()
    End Sub

    Private Sub btnAlmacenes_Click(sender As Object, e As EventArgs) Handles btnAlmacenes.Click
        Almacenes.Show()
    End Sub

    Private Sub btnNumeros_Click(sender As Object, e As EventArgs) Handles btnNumeros.Click
        Numeros.Show()
    End Sub

    Private Sub btnSueldo_Click(sender As Object, e As EventArgs) Handles btnSueldo.Click
        CalculoSalario.Show()
    End Sub
End Class
