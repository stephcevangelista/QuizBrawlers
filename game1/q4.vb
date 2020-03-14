Public Class q4
    Private Sub companies5confirm_Click(sender As Object, e As EventArgs) Handles companies5confirm.Click
        Me.Hide()
        q5.Show()
    End Sub

    'A: WRONG'
    Private Sub companies5A_Click(sender As Object, e As EventArgs) Handles companies5A.Click
        Dim companies5A As Boolean = False, companies5B As Boolean = False,
         companies5C As Boolean = False, companies5D As Boolean = False

        If Not companies5C Then
            Me.companies5A.BackColor = Color.IndianRed
            companies5A = True
            Me.companies5B.BackColor = Color.IndianRed
            companies5B = True
        End If
        If Not companies5D Then
            Me.companies5C.BackColor = Color.DarkSeaGreen
            companies5C = True
            Me.companies5D.BackColor = Color.DarkSeaGreen
            companies5D = True
        End If

        companies5avatar.Image = My.Resources.superman
    End Sub

    'B: WRONG'
    Private Sub companies5B_Click(sender As Object, e As EventArgs) Handles companies5B.Click
        Dim companies5A As Boolean = False, companies5B As Boolean = False,
        companies5C As Boolean = False, companies5D As Boolean = False

        If Not companies5C Then
            Me.companies5A.BackColor = Color.IndianRed
            companies5A = True
            Me.companies5B.BackColor = Color.IndianRed
            companies5B = True
        End If
        If Not companies5D Then
            Me.companies5C.BackColor = Color.DarkSeaGreen
            companies5C = True
            Me.companies5D.BackColor = Color.DarkSeaGreen
            companies5D = True
        End If
        companies5avatar.Image = My.Resources.superman
    End Sub

    'C: CORRECT'
    Private Sub companies5C_Click(sender As Object, e As EventArgs) Handles companies5C.Click
        Dim companies5C As Boolean = False
        Me.companies5C.BackColor = Color.DarkSeaGreen
        companies5C = True
        companies5avatar.Image = My.Resources.superman
    End Sub

    'D: CORRECT'
    Private Sub companies5D_Click(sender As Object, e As EventArgs) Handles companies5D.Click
        Dim companies5D As Boolean = False
        Me.companies5D.BackColor = Color.DarkSeaGreen
        companies5D = True
        companies5avatar.Image = My.Resources.superman
    End Sub
End Class