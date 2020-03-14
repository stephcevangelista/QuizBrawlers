Public Class Egypt5
    Private Sub Egypt5confirm_Click(sender As Object, e As EventArgs) Handles Egypt5confirm.Click
        Me.Hide()
        France1.Show()
    End Sub

    Private Sub Egypt5A_Click(sender As Object, e As EventArgs) Handles Egypt5A.Click
        Dim Egypt5A As Boolean = False
        Me.Egypt5A.BackColor = Color.DarkSeaGreen
        Egypt5A = True
    End Sub

    Private Sub Egypt5B_Click(sender As Object, e As EventArgs) Handles Egypt5B.Click
        Dim Egypt5B As Boolean = False
        Me.Egypt5B.BackColor = Color.DarkSeaGreen
        Egypt5B = True
    End Sub

    Private Sub Egypt5C_Click(sender As Object, e As EventArgs) Handles Egypt5C.Click
        Dim Egypt5A As Boolean = False, Egypt5B As Boolean = False,
           Egypt5C As Boolean = False, Egypt5D As Boolean = False

        If Not Egypt5C Then
            Me.Egypt5C.BackColor = Color.IndianRed
            Egypt5C = True
            Me.Egypt5D.BackColor = Color.IndianRed
            Egypt5D = True
        End If
        If Not Egypt5A Then
            Me.Egypt5A.BackColor = Color.DarkSeaGreen
            Egypt5A = True
            Me.Egypt5B.BackColor = Color.DarkSeaGreen
            Egypt5B = True
        End If
    End Sub

    Private Sub Egypt5D_Click(sender As Object, e As EventArgs) Handles Egypt5D.Click
        Dim Egypt5A As Boolean = False, Egypt5B As Boolean = False,
          Egypt5C As Boolean = False, Egypt5D As Boolean = False

        If Not Egypt5D Then
            Me.Egypt5D.BackColor = Color.IndianRed
            Egypt5D = True
            Me.Egypt5C.BackColor = Color.IndianRed
            Egypt5C = True
        End If
        If Not Egypt5A Then
            Me.Egypt5A.BackColor = Color.DarkSeaGreen
            Egypt5A = True
            Me.Egypt5B.BackColor = Color.DarkSeaGreen
            Egypt5B = True
        End If
    End Sub
End Class