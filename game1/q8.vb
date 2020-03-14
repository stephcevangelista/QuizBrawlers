Public Class q8

    Private Sub Singapore4confirm_Click(sender As Object, e As EventArgs) Handles Singapore4confirm.Click
        Me.Hide()
        q9.Show()
    End Sub

    'A: WRONG'
    Private Sub Singapore4A_Click(sender As Object, e As EventArgs) Handles Singapore4A.Click
        Dim Singapore4A As Boolean = False, Singapore4B As Boolean = False,
        Singapore4C As Boolean = False, Singapore4D As Boolean = False

        If Not Singapore4C Then
            Me.Singapore4A.BackColor = Color.IndianRed
            Singapore4A = True
            Me.Singapore4B.BackColor = Color.IndianRed
            Singapore4B = True
        End If
        If Not Singapore4D Then
            Me.Singapore4C.BackColor = Color.DarkSeaGreen
            Singapore4C = True
            Me.Singapore4D.BackColor = Color.DarkSeaGreen
            Singapore4D = True
        End If
    End Sub

    'B: WRONG'
    Private Sub Singapore4B_Click(sender As Object, e As EventArgs) Handles Singapore4B.Click
        Dim Singapore4A As Boolean = False, Singapore4B As Boolean = False,
       Singapore4C As Boolean = False, Singapore4D As Boolean = False

        If Not Singapore4C Then
            Me.Singapore4A.BackColor = Color.IndianRed
            Singapore4A = True
            Me.Singapore4B.BackColor = Color.IndianRed
            Singapore4B = True
        End If
        If Not Singapore4D Then
            Me.Singapore4C.BackColor = Color.DarkSeaGreen
            Singapore4C = True
            Me.Singapore4D.BackColor = Color.DarkSeaGreen
            Singapore4D = True
        End If
    End Sub

    'C: CORRECT'
    Private Sub Singapore4C_Click(sender As Object, e As EventArgs) Handles Singapore4C.Click
        Dim Singapore4C As Boolean = False
        Me.Singapore4C.BackColor = Color.DarkSeaGreen
        Singapore4C = True
    End Sub

    'D: CORRECT'
    Private Sub Singapore4D_Click(sender As Object, e As EventArgs) Handles Singapore4D.Click
        Dim Singapore4D As Boolean = False
        Me.Singapore4D.BackColor = Color.DarkSeaGreen
        Singapore4D = True
    End Sub
End Class