Public Class Egypt1
    Private Sub Egypt1confirm_Click(sender As Object, e As EventArgs) Handles Egypt1confirm.Click
        Me.Hide()
        Egypt2.Show()
    End Sub

    Private Sub Egypt1A_Click(sender As Object, e As EventArgs) Handles Egypt1A.Click
        Dim Egypt1A As Boolean = False, Egypt1B As Boolean = False,
            Egypt1C As Boolean = False, Egypt1D As Boolean = False

        If Not Egypt1A Then
            Me.Egypt1A.BackColor = Color.IndianRed
            Egypt1A = True
            Me.Egypt1D.BackColor = Color.IndianRed
            Egypt1D = True
        End If
        If Not Egypt1B Then
            Me.Egypt1B.BackColor = Color.DarkSeaGreen
            Egypt1B = True
            Me.Egypt1C.BackColor = Color.DarkSeaGreen
            Egypt1C = True
        End If
    End Sub

    Private Sub Egypt1B_Click(sender As Object, e As EventArgs) Handles Egypt1B.Click
        Dim Egypt1B As Boolean = False
        Me.Egypt1B.BackColor = Color.DarkSeaGreen
        Egypt1B = True
    End Sub

    Private Sub Egypt1C_Click(sender As Object, e As EventArgs) Handles Egypt1C.Click
        Dim Egypt1C As Boolean = False
        Me.Egypt1C.BackColor = Color.DarkSeaGreen
        Egypt1C = True
    End Sub

    Private Sub Egypt1D_Click(sender As Object, e As EventArgs) Handles Egypt1D.Click
        Dim Egypt1A As Boolean = False, Egypt1B As Boolean = False,
            Egypt1C As Boolean = False, Egypt1D As Boolean = False

        If Not Egypt1D Then
            Me.Egypt1D.BackColor = Color.IndianRed
            Egypt1D = True
            Me.Egypt1A.BackColor = Color.IndianRed
            Egypt1A = True
        End If
        If Not Egypt1B Then
            Me.Egypt1B.BackColor = Color.DarkSeaGreen
            Egypt1B = True
            Me.Egypt1C.BackColor = Color.DarkSeaGreen
            Egypt1C = True
        End If
    End Sub
End Class