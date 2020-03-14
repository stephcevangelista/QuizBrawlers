Public Class Egypt4
    Private Sub Egypt4confirm_Click(sender As Object, e As EventArgs) Handles Egypt4confirm.Click
        Me.Hide()
        Egypt5.Show()
    End Sub

    Private Sub Egypt4A_Click(sender As Object, e As EventArgs) Handles Egypt4A.Click
        Dim Egypt4A As Boolean = False, Egypt4B As Boolean = False,
            Egypt4C As Boolean = False, Egypt4D As Boolean = False

        If Not Egypt4A Then
            Me.Egypt4A.BackColor = Color.IndianRed
            Egypt4A = True
            Me.Egypt4C.BackColor = Color.IndianRed
            Egypt4C = True
        End If
        If Not Egypt4B Then
            Me.Egypt4B.BackColor = Color.DarkSeaGreen
            Egypt4B = True
            Me.Egypt4D.BackColor = Color.DarkSeaGreen
            Egypt4D = True
        End If
    End Sub

    Private Sub Egypt4B_Click(sender As Object, e As EventArgs) Handles Egypt4B.Click
        Dim Egypt4B As Boolean = False
        Me.Egypt4B.BackColor = Color.DarkSeaGreen
        Egypt4B = True
    End Sub

    Private Sub Egypt4C_Click(sender As Object, e As EventArgs) Handles Egypt4C.Click
        Dim Egypt4A As Boolean = False, Egypt4B As Boolean = False,
           Egypt4C As Boolean = False, Egypt4D As Boolean = False

        If Not Egypt4C Then
            Me.Egypt4C.BackColor = Color.IndianRed
            Egypt4C = True
            Me.Egypt4A.BackColor = Color.IndianRed
            Egypt4A = True
        End If
        If Not Egypt4B Then
            Me.Egypt4B.BackColor = Color.DarkSeaGreen
            Egypt4B = True
            Me.Egypt4D.BackColor = Color.DarkSeaGreen
            Egypt4D = True
        End If
    End Sub

    Private Sub Egypt4D_Click(sender As Object, e As EventArgs) Handles Egypt4D.Click
        Dim Egypt4D As Boolean = False
        Me.Egypt4D.BackColor = Color.DarkSeaGreen
        Egypt4D = True
    End Sub
End Class