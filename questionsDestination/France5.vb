Public Class France5
    Private Sub France5confirm_Click(sender As Object, e As EventArgs) Handles France5confirm.Click
        Me.Hide()
        Italy1.Show()
    End Sub

    Private Sub France5A_Click(sender As Object, e As EventArgs) Handles France5A.Click
        Dim France5A As Boolean = False, France5B As Boolean = False,
            France5C As Boolean = False, France5D As Boolean = False

        If Not France5A Then
            Me.France5A.BackColor = Color.IndianRed
            France5A = True
            Me.France5C.BackColor = Color.IndianRed
            France5C = True
        End If
        If Not France5B Then
            Me.France5B.BackColor = Color.DarkSeaGreen
            France5B = True
            Me.France5D.BackColor = Color.DarkSeaGreen
            France5D = True
        End If
    End Sub

    Private Sub France5B_Click(sender As Object, e As EventArgs) Handles France5B.Click
        Dim France5B As Boolean = False
        Me.France5B.BackColor = Color.DarkSeaGreen
        France5B = True
    End Sub

    Private Sub France5C_Click(sender As Object, e As EventArgs) Handles France5C.Click
        Dim France5A As Boolean = False, France5B As Boolean = False,
            France5C As Boolean = False, France5D As Boolean = False

        If Not France5C Then
            Me.France5C.BackColor = Color.IndianRed
            France5C = True
            Me.France5A.BackColor = Color.IndianRed
            France5A = True
        End If
        If Not France5B Then
            Me.France5B.BackColor = Color.DarkSeaGreen
            France5B = True
            Me.France5D.BackColor = Color.DarkSeaGreen
            France5D = True
        End If
    End Sub

    Private Sub France5D_Click(sender As Object, e As EventArgs) Handles France5D.Click
        Dim France5D As Boolean = False
        Me.France5D.BackColor = Color.DarkSeaGreen
        France5D = True
    End Sub
End Class