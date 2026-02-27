Public Class Form1
    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        Dim num1, num2 As Double
        Dim promedio As Double

        num1 = Val(Numero1.Text)
        num2 = Val(Numero2.Text)
        promedio = (num1 + num2) / 2
        Resultado.Text = promedio.ToString
    End Sub
End Class
