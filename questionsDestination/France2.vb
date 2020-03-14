Public Class France2
    Private Sub France2confirm_Click(sender As Object, e As EventArgs) Handles France2confirm.Click
        Me.Hide()
        France3.Show()
    End Sub

    Private Sub France2A_Click(sender As Object, e As EventArgs) Handles France2A.Click
        Dim France2A As Boolean = False
        Me.France2A.BackColor = Color.DarkSeaGreen
        France2A = True
    End Sub

    Private Sub France2B_Click(sender As Object, e As EventArgs) Handles France2B.Click
        Dim France2A As Boolean = False, France2B As Boolean = False,
            France2C As Boolean = False, France2D As Boolean = False

        If Not France2B Then
            Me.France2B.BackColor = Color.IndianRed
            France2B = True
            Me.France2C.BackColor = Color.IndianRed
            France2C = True
        End If
        If Not France2A Then
            Me.France2A.BackColor = Color.DarkSeaGreen
            France2A = True
            Me.France2D.BackColor = Color.DarkSeaGreen
            France2D = True
        End If
    End Sub

    Private Sub France2C_Click(sender As Object, e As EventArgs) Handles France2C.Click
        Dim France2A As Boolean = False, France2B As Boolean = False,
           France2C As Boolean = False, France2D As Boolean = False

        If Not France2C Then
            Me.France2C.BackColor = Color.IndianRed
            France2C = True
            Me.France2B.BackColor = Color.IndianRed
            France2B = True
        End If
        If Not France2A Then
            Me.France2A.BackColor = Color.DarkSeaGreen
            France2A = True
            Me.France2D.BackColor = Color.DarkSeaGreen
            France2D = True
        End If
    End Sub

    Private Sub France2D_Click(sender As Object, e As EventArgs) Handles France2D.Click
        Dim France2D As Boolean = False
        Me.France2D.BackColor = Color.DarkSeaGreen
        France2D = True
    End Sub
End Class