Public Class q9
    Private Sub companies1confirm_Click(sender As Object, e As EventArgs) Handles companies1confirm.Click
        Me.Hide()
        scores.Show()
    End Sub

    'A: CORRECT'
    Private Sub companies1A_Click(sender As Object, e As EventArgs) Handles companies1A.Click
        Dim companies1A As Boolean = False
        Me.companies1A.BackColor = Color.DarkSeaGreen
        companies1A = True
        companies1avatar.Image = My.Resources.superman
    End Sub

    'B: CORRECT'
    Private Sub companies1B_Click(sender As Object, e As EventArgs) Handles companies1B.Click
        Dim companies1B As Boolean = False
        Me.companies1B.BackColor = Color.DarkSeaGreen
        companies1B = True
        companies1avatar.Image = My.Resources.superman
    End Sub

    'C: WRONG'
    Private Sub companies1C_Click(sender As Object, e As EventArgs) Handles companies1C.Click
        Dim companies1A As Boolean = False, companies1B As Boolean = False,
         companies1C As Boolean = False, companies1D As Boolean = False

        If Not companies1A Then
            Me.companies1C.BackColor = Color.IndianRed
            companies1C = True
            Me.companies1D.BackColor = Color.IndianRed
            companies1D = True
        End If
        If Not companies1B Then
            Me.companies1A.BackColor = Color.DarkSeaGreen
            companies1A = True
            Me.companies1B.BackColor = Color.DarkSeaGreen
            companies1B = True
        End If
        companies1avatar.Image = My.Resources.superman
    End Sub

    'D: WRONG'
    Private Sub companies1D_Click(sender As Object, e As EventArgs) Handles companies1D.Click
        Dim companies1A As Boolean = False, companies1B As Boolean = False,
         companies1C As Boolean = False, companies1D As Boolean = False

        If Not companies1A Then
            Me.companies1C.BackColor = Color.IndianRed
            companies1C = True
            Me.companies1D.BackColor = Color.IndianRed
            companies1D = True
        End If
        If Not companies1B Then
            Me.companies1A.BackColor = Color.DarkSeaGreen
            companies1A = True
            Me.companies1B.BackColor = Color.DarkSeaGreen
            companies1B = True
        End If
        companies1avatar.Image = My.Resources.superman
    End Sub
End Class