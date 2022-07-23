Imports System.ComponentModel

Public Class Form1
    Private Sub btnEncender_Click(sender As Object, e As EventArgs) Handles btnEncender.Click
        enviarDato("1")
    End Sub

    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        enviarDato("0")
    End Sub

    Public Function enviarDato(dato As String)
        Try
            SerialPort1.Open()
            SerialPort1.Write(dato)
            SerialPort1.Close()
            Return "Dato enviado exitosamente"
        Catch ex As Exception
            If SerialPort1.IsOpen() Then
                SerialPort1.Close()
            End If

            Return "Error: dato no enviado"
        End Try
    End Function

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        enviarDato("0")
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        enviarDato(TextBoxDato.Text)
    End Sub
End Class
