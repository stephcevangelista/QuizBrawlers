Public Class q6
    Private Sub Pop1confirm_Click(sender As Object, e As EventArgs) Handles Pop1confirm.Click
        Me.Hide()
        q7.Show()

    End Sub

    'A: WRONG'
    Private Sub Pop1A_Click(sender As Object, e As EventArgs) Handles Pop1A.Click
        Dim Pop1A As Boolean = False, Pop1B As Boolean = False,
        Pop1C As Boolean = False, Pop1D As Boolean = False

        If Not Pop1B Then
            Me.Pop1A.BackColor = Color.IndianRed
            Pop1A = True
            Me.Pop1D.BackColor = Color.IndianRed
            Pop1D = True
        End If
        If Not Pop1C Then
            Me.Pop1B.BackColor = Color.DarkSeaGreen
            Pop1B = True
            Me.Pop1C.BackColor = Color.DarkSeaGreen
            Pop1C = True
        End If
        Pop1avatar.Image = My.Resources.superman
    End Sub

    'B: CORRECT'
    Private Sub Pop1B_Click(sender As Object, e As EventArgs) Handles Pop1B.Click
        Dim Pop1B As Boolean = False
        Me.Pop1B.BackColor = Color.DarkSeaGreen
        Pop1B = True
        Pop1avatar.Image = My.Resources.superman
    End Sub

    'C: CORRECT'
    Private Sub Pop1C_Click(sender As Object, e As EventArgs) Handles Pop1C.Click
        Dim Pop1C As Boolean = False
        Me.Pop1C.BackColor = Color.DarkSeaGreen
        Pop1C = True
        Pop1avatar.Image = My.Resources.superman
    End Sub

    'D: CORRECT'
    Private Sub Pop1D_Click(sender As Object, e As EventArgs) Handles Pop1D.Click
        Dim Pop1A As Boolean = False, Pop1B As Boolean = False,
        Pop1C As Boolean = False, Pop1D As Boolean = False

        If Not Pop1B Then
            Me.Pop1A.BackColor = Color.IndianRed
            Pop1A = True
            Me.Pop1D.BackColor = Color.IndianRed
            Pop1D = True
        End If
        If Not Pop1C Then
            Me.Pop1B.BackColor = Color.DarkSeaGreen
            Pop1B = True
            Me.Pop1C.BackColor = Color.DarkSeaGreen
            Pop1C = True
        End If
        Pop1avatar.Image = My.Resources.superman
    End Sub
End Class