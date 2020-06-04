Imports System.ComponentModel

Public Class calculadoraMini
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Public Function comprobacion()
        Dim Verificado As Integer

        Try
            If txtValor1.Text <> String.Empty And txtValor2.Text <> String.Empty Then
                If IsNumeric(txtValor1.Text) = True And IsNumeric(txtValor2.Text) = True Then
                    Verificado = 1
                Else
                    Verificado = 0
                    MessageBox.Show("Ingrese valores numericos!")
                End If
            Else
                MessageBox.Show("Todos los campos son requeridos!")
                Verificado = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Verificado

    End Function

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim valor1 As Double = Val(txtValor1.Text)
        Dim valor2 As Double = Val(txtValor2.Text)

        If comprobacion() = 1 Then
            txtResultado.Text = valor1 + valor2
        End If

    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim valor1 As Double = Val(txtValor1.Text)
        Dim valor2 As Double = Val(txtValor2.Text)

        If comprobacion() = 1 Then
            txtResultado.Text = valor1 - valor2
        End If
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim valor1 As Double = Val(txtValor1.Text)
        Dim valor2 As Double = Val(txtValor2.Text)

        If comprobacion() = 1 Then
            txtResultado.Text = valor1 * valor2
        End If
    End Sub

    Private Sub btnDivi_Click(sender As Object, e As EventArgs) Handles btnDivi.Click
        Dim valor1 As Double = Val(txtValor1.Text)
        Dim valor2 As Double = Val(txtValor2.Text)

        If comprobacion() = 1 Then
            If txtValor2.Text <> 0 Then
                txtResultado.Text = valor1 / valor2
            Else
                MessageBox.Show("Error Matematico")
            End If
        End If
    End Sub

    Private Sub btnPromedio_Click(sender As Object, e As EventArgs) Handles btnPromedio.Click
        Dim cantidadNumero As Integer
        Dim valores As Double
        Dim acumulador As Double

        Try
            cantidadNumero = Val(InputBox("Ingrese la cantidad de valores que promediara", "Ingreso Valores"))

            If Me.ValidateChildren And IsNumeric(cantidadNumero) = True And cantidadNumero > 1 Then

                For i = 1 To cantidadNumero Step 1

                    valores = Val(InputBox("Ingrese el numero a evaluar: " & i, "Ingreso Valores"))
                    If Me.ValidateChildren And valores > 0 And IsNumeric(valores) = True Then
                        acumulador += valores

                    Else
                        MessageBox.Show("Ingrese valores correctos!")
                        Exit For

                    End If

                Next
            Else
                MessageBox.Show("Ingrese valores correctos!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtResultado.Text = Math.Round((acumulador / cantidadNumero), MidpointRounding.AwayFromZero)

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        End
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
        impresionDatos.Show()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub RegresarAlInicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlInicioToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtResultado.Clear()
        txtValor1.Clear()
        txtValor2.Clear()
    End Sub

End Class