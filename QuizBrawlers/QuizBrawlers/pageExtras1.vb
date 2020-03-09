Public Class pageExtras1
    Private Sub extrasprev_Click(sender As Object, e As EventArgs) Handles extras1prev.Click
        Me.Hide()
        pageHome.Show()
    End Sub

    Private Sub extras1next_Click(sender As Object, e As EventArgs) Handles extras1next.Click
        Me.Hide()
        pageExtras2.Show()
    End Sub
End Class