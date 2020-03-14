Public Class Nether2
    Private Sub Nether2confirm_Click(sender As Object, e As EventArgs) Handles Nether2confirm.Click
        Me.Hide()
        Nether3.Show()
    End Sub

    Private Sub Nether2A_Click(sender As Object, e As EventArgs) Handles Nether2A.Click
        Dim Nether2A As Boolean = False, Nether2B As Boolean = False,
           Nether2C As Boolean = False, Nether2D As Boolean = False

        If Not Nether2A Then
            Me.Nether2A.BackColor = Color.IndianRed
            Nether2A = True
            Me.Nether2C.BackColor = Color.IndianRed
            Nether2C = True
        End If
        If Not Nether2B Then
            Me.Nether2B.BackColor = Color.DarkSeaGreen
            Nether2B = True
            Me.Nether2D.BackColor = Color.DarkSeaGreen
            Nether2D = True
        End If
    End Sub

    Private Sub Nether2B_Click(sender As Object, e As EventArgs) Handles Nether2B.Click
        Dim Nether2B As Boolean = False
        Me.Nether2B.BackColor = Color.DarkSeaGreen
        Nether2B = True
    End Sub

    Private Sub Nether2C_Click(sender As Object, e As EventArgs) Handles Nether2C.Click
        Dim Nether2A As Boolean = False, Nether2B As Boolean = False,
            Nether2C As Boolean = False, Nether2D As Boolean = False

        If Not Nether2C Then
            Me.Nether2C.BackColor = Color.IndianRed
            Nether2C = True
            Me.Nether2A.BackColor = Color.IndianRed
            Nether2A = True
        End If
        If Not Nether2B Then
            Me.Nether2B.BackColor = Color.DarkSeaGreen
            Nether2B = True
            Me.Nether2D.BackColor = Color.DarkSeaGreen
            Nether2D = True
        End If
    End Sub

    Private Sub Nether2D_Click(sender As Object, e As EventArgs) Handles Nether2D.Click
        Dim Nether2D As Boolean = False
        Me.Nether2D.BackColor = Color.DarkSeaGreen
        Nether2D = True
    End Sub
End Class