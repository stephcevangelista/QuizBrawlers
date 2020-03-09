Public Class pageHome
    Private Sub homePlay_Click(sender As Object, e As EventArgs) Handles homePlay.Click
        Me.Hide()
        pagePlayLAN.Show()
    End Sub

    Private Sub homeAbout_Click(sender As Object, e As EventArgs) Handles homeAbout.Click
        Me.Hide()
        pageAbout.Show()
    End Sub

    Private Sub homeHow2Play_Click(sender As Object, e As EventArgs) Handles homeHow2Play.Click
        Me.Hide()
        pageHow2Play.Show()
    End Sub

    Private Sub homeExtras_Click(sender As Object, e As EventArgs) Handles homeExtras.Click
        Me.Hide()
        pageExtras1.Show()
    End Sub

    Private Sub homeQuit_Click(sender As Object, e As EventArgs) Handles homeQuit.Click
        Me.Close()

    End Sub
End Class
