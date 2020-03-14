Public Class q5
    Private Sub companies2confirm_Click(sender As Object, e As EventArgs) Handles companies2confirm.Click
        Me.Hide()
        q6.Show()
    End Sub

    'A: CORRECT'
    Private Sub companies2A_Click(sender As Object, e As EventArgs) Handles companies2A.Click
        Dim companies2A As Boolean = False
        Me.companies2A.BackColor = Color.DarkSeaGreen
        companies2A = True
    End Sub

    'B: WRONG'
    Private Sub companies2B_Click(sender As Object, e As EventArgs) Handles companies2B.Click
        Dim companies2A As Boolean = False, companies2B As Boolean = False,
        companies2C As Boolean = False, companies2D As Boolean = False

        If Not companies2A Then
            Me.companies2B.BackColor = Color.IndianRed
            companies2B = True
            Me.companies2C.BackColor = Color.IndianRed
            companies2C = True
        End If
        If Not companies2D Then
            Me.companies2A.BackColor = Color.DarkSeaGreen
            companies2A = True
            Me.companies2D.BackColor = Color.DarkSeaGreen
            companies2D = True
        End If
    End Sub

    'C: WRONG'
    Private Sub companies2C_Click(sender As Object, e As EventArgs) Handles companies2C.Click
        Dim companies2A As Boolean = False, companies2B As Boolean = False,
        companies2C As Boolean = False, companies2D As Boolean = False

        If Not companies2A Then
            Me.companies2B.BackColor = Color.IndianRed
            companies2B = True
            Me.companies2C.BackColor = Color.IndianRed
            companies2C = True
        End If
        If Not companies2D Then
            Me.companies2A.BackColor = Color.DarkSeaGreen
            companies2A = True
            Me.companies2D.BackColor = Color.DarkSeaGreen
            companies2D = True
        End If
    End Sub

    'D: CORRECT'
    Private Sub companies2D_Click(sender As Object, e As EventArgs) Handles companies2D.Click
        Dim companies2D As Boolean = False
        Me.companies2D.BackColor = Color.DarkSeaGreen
        companies2D = True
    End Sub
End Class