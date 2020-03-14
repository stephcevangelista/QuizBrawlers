Public Class France4
    Private Sub France4confirm_Click(sender As Object, e As EventArgs) Handles France4confirm.Click
        Me.Hide()
        France5.Show()
    End Sub

    Private Sub France4A_Click(sender As Object, e As EventArgs) Handles France4A.Click
        Dim France4A As Boolean = False
        Me.France4A.BackColor = Color.DarkSeaGreen
        France4A = True
    End Sub

    Private Sub France4B_Click(sender As Object, e As EventArgs) Handles France4B.Click
        Dim France4A As Boolean = False, France4B As Boolean = False,
            France4C As Boolean = False, France4D As Boolean = False

        If Not France4B Then
            Me.France4B.BackColor = Color.IndianRed
            France4B = True
            Me.France4C.BackColor = Color.IndianRed
            France4C = True
        End If
        If Not France4A Then
            Me.France4A.BackColor = Color.DarkSeaGreen
            France4A = True
            Me.France4D.BackColor = Color.DarkSeaGreen
            France4D = True
        End If
    End Sub

    Private Sub France4C_Click(sender As Object, e As EventArgs) Handles France4C.Click
        Dim France4A As Boolean = False, France4B As Boolean = False,
            France4C As Boolean = False, France4D As Boolean = False

        If Not France4C Then
            Me.France4C.BackColor = Color.IndianRed
            France4C = True
            Me.France4B.BackColor = Color.IndianRed
            France4B = True
        End If
        If Not France4A Then
            Me.France4A.BackColor = Color.DarkSeaGreen
            France4A = True
            Me.France4D.BackColor = Color.DarkSeaGreen
            France4D = True
        End If
    End Sub

    Private Sub France4D_Click(sender As Object, e As EventArgs) Handles France4D.Click
        Dim France4D As Boolean = False
        Me.France4D.BackColor = Color.DarkSeaGreen
        France4D = True
    End Sub
End Class