Imports System.IO

Public Class Inicio
    '---Ruta y nombre del archivo de base de datos
    Dim ruta As String = "C:\Users\Hacknel\source\repos\PEntornosVisuales-IF325-Hacknel-Reyes\I Parcial\Ejercicios de Tarea\ProyectoPEVSistemaGestorNotas\ProyectoPEVSistemaGestorNotas"
    Dim archivo As String = "BaseDatosAlumnos.txt"

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fs As FileStream

        '---Validar si el archivo existe
        Try
            If File.Exists(ruta) Then
                fs = File.
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
