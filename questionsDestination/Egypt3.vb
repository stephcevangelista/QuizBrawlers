Public Class Egypt3
    Private Sub Egypt3confirm_Click(sender As Object, e As EventArgs) Handles Egypt3confirm.Click
        Me.Hide()
        Egypt4.Show()
    End Sub

    Private Sub Egypt3A_Click(sender As Object, e As EventArgs) Handles Egypt3A.Click
        Dim Egypt3A As Boolean = False, Egypt3B As Boolean = False,
            Egypt3C As Boolean = False, Egypt3D As Boolean = False

        If Not Egypt3A Then
            Me.Egypt3A.BackColor = Color.IndianRed
            Egypt3A = True
            Me.Egypt3C.BackColor = Color.IndianRed
            Egypt3C = True
        End If
        If Not Egypt3B Then
            Me.Egypt3B.BackColor = Color.DarkSeaGreen
            Egypt3B = True
            Me.Egypt3D.BackColor = Color.DarkSeaGreen
            Egypt3D = True
        End If
    End Sub

    Private Sub Egypt3B_Click(sender As Object, e As EventArgs) Handles Egypt3B.Click
        Dim Egypt3B As Boolean = False
        Me.Egypt3B.BackColor = Color.DarkSeaGreen
        Egypt3B = True
    End Sub

    Private Sub Egypt3C_Click(sender As Object, e As EventArgs) Handles Egypt3C.Click
        Dim Egypt3A As Boolean = False, Egypt3B As Boolean = False,
            Egypt3C As Boolean = False, Egypt3D As Boolean = False

        If Not Egypt3C Then
            Me.Egypt3C.BackColor = Color.IndianRed
            Egypt3C = True
            Me.Egypt3A.BackColor = Color.IndianRed
            Egypt3A = True
        End If
        If Not Egypt3B Then
            Me.Egypt3B.BackColor = Color.DarkSeaGreen
            Egypt3B = True
            Me.Egypt3D.BackColor = Color.DarkSeaGreen
            Egypt3D = True
        End If
    End Sub

    Private Sub Egypt3D_Click(sender As Object, e As EventArgs) Handles Egypt3D.Click
        Dim Egypt3D As Boolean = False
        Me.Egypt3D.BackColor = Color.DarkSeaGreen
        Egypt3D = True
    End Sub
End Class