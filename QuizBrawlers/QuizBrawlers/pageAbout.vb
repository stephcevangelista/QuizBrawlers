Public Class pageAbout

    Private Sub aboutPrev_Click(sender As Object, e As EventArgs) Handles aboutPrev.Click
        Me.Hide()
        pageHome.Show()
    End Sub
End Class