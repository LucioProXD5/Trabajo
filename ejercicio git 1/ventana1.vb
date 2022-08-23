Public Class ventana1
    Private Sub btnend1_Click(sender As Object, e As EventArgs) Handles btnend1.Click
        End
    End Sub

    Private Sub btnvent1_Click(sender As Object, e As EventArgs) Handles btnvent1.Click
        Me.Hide()
        ventana2.Show()
    End Sub

    Private Sub ventana1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ventana2.Show()
    End Sub
End Class
