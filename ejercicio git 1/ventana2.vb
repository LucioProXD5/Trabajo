Public Class ventana2
    Private Sub btnend2_Click(sender As Object, e As EventArgs) Handles btnend2.Click
        End
    End Sub

    Private Sub btnvent2_Click(sender As Object, e As EventArgs) Handles btnvent2.Click
        Me.Hide()
        ventana1.Show()
    End Sub

    Private Sub ventana2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ventana1.Show()
    End Sub
End Class