Public Class Egypt2
    Private Sub Egypt2confirm_Click(sender As Object, e As EventArgs) Handles Egypt2confirm.Click
        Me.Hide()
        Egypt3.Show()
    End Sub

    Private Sub Egypt2A_Click(sender As Object, e As EventArgs) Handles Egypt2A.Click
        Dim Egypt2A As Boolean = False, Egypt2B As Boolean = False,
            Egypt2C As Boolean = False, Egypt2D As Boolean = False

        If Not Egypt2A Then
            Me.Egypt2A.BackColor = Color.IndianRed
            Egypt2A = True
            Me.Egypt2C.BackColor = Color.IndianRed
            Egypt2C = True
        End If
        If Not Egypt2B Then
            Me.Egypt2B.BackColor = Color.DarkSeaGreen
            Egypt2B = True
            Me.Egypt2D.BackColor = Color.DarkSeaGreen
            Egypt2D = True
        End If
    End Sub

    Private Sub Egypt2B_Click(sender As Object, e As EventArgs) Handles Egypt2B.Click
        Dim Egypt2B As Boolean = False
        Me.Egypt2B.BackColor = Color.DarkSeaGreen
        Egypt2B = True
    End Sub

    Private Sub Egypt2C_Click(sender As Object, e As EventArgs) Handles Egypt2C.Click
        Dim Egypt2A As Boolean = False, Egypt2B As Boolean = False,
           Egypt2C As Boolean = False, Egypt2D As Boolean = False

        If Not Egypt2C Then
            Me.Egypt2C.BackColor = Color.IndianRed
            Egypt2C = True
            Me.Egypt2A.BackColor = Color.IndianRed
            Egypt2A = True
        End If
        If Not Egypt2B Then
            Me.Egypt2B.BackColor = Color.DarkSeaGreen
            Egypt2B = True
            Me.Egypt2D.BackColor = Color.DarkSeaGreen
            Egypt2D = True
        End If
    End Sub

    Private Sub Egypt2D_Click(sender As Object, e As EventArgs) Handles Egypt2D.Click
        Dim Egypt2D As Boolean = False
        Me.Egypt2D.BackColor = Color.DarkSeaGreen
        Egypt2D = True
    End Sub
End Class