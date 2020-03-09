Public Class pagePlayLANStartPlayers
    Private Sub startplayersprev_Click(sender As Object, e As EventArgs) Handles startplayersprev.Click
        Me.Hide()
        pagePlayLAN.Show()
    End Sub

    Private Sub startplayersconfirm_Click(sender As Object, e As EventArgs) Handles startplayersconfirm.Click
        Me.Hide()
        pagePlayLANStartQuestions.Show()
    End Sub

End Class