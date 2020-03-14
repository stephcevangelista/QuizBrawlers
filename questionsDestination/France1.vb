Public Class France1

    Private Sub France1confirm_Click(sender As Object, e As EventArgs) Handles France1confirm.Click
        Me.Hide()
        France2.Show()
    End Sub

    Private Sub France1A_Click(sender As Object, e As EventArgs) Handles France1A.Click
        Dim France1A As Boolean = False, France1B As Boolean = False,
            France1C As Boolean = False, France1D As Boolean = False

        If Not France1A Then
            Me.France1A.BackColor = Color.IndianRed
            France1A = True
            Me.France1C.BackColor = Color.IndianRed
            France1C = True
        End If
        If Not France1B Then
            Me.France1B.BackColor = Color.DarkSeaGreen
            France1B = True
            Me.France1D.BackColor = Color.DarkSeaGreen
            France1D = True
        End If
    End Sub

    Private Sub France1B_Click(sender As Object, e As EventArgs) Handles France1B.Click
        Dim France1B As Boolean = False
        Me.France1B.BackColor = Color.DarkSeaGreen
        France1B = True
    End Sub

    Private Sub France1C_Click(sender As Object, e As EventArgs) Handles France1C.Click
        Dim France1A As Boolean = False, France1B As Boolean = False,
           France1C As Boolean = False, France1D As Boolean = False

        If Not France1C Then
            Me.France1C.BackColor = Color.IndianRed
            France1C = True
            Me.France1A.BackColor = Color.IndianRed
            France1A = True
        End If
        If Not France1B Then
            Me.France1B.BackColor = Color.DarkSeaGreen
            France1B = True
            Me.France1D.BackColor = Color.DarkSeaGreen
            France1D = True
        End If
    End Sub

    Private Sub France1D_Click(sender As Object, e As EventArgs) Handles France1D.Click
        Dim France1D As Boolean = False
        Me.France1D.BackColor = Color.DarkSeaGreen
        France1D = True
    End Sub
End Class