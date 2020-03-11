Public Class pagePlayLAN

    Private Sub gameStart_Click(sender As Object, e As EventArgs) Handles gameStart.Click
        Me.Hide()
        pagePlayLANStartPlayers.Show()
    End Sub

    Private Sub playlanprev_Click(sender As Object, e As EventArgs) Handles playlanprev.Click
        Me.Hide()
        pageHome.Show()
    End Sub

    Private Sub gameCreate_Click(sender As Object, e As EventArgs) Handles gameCreate.Click
        Me.Hide()
        pagePlayLANCreateCategories.Show()
    End Sub
End Class