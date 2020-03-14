Public Class Nether4
    Private Sub Nether4confirm_Click(sender As Object, e As EventArgs) Handles Nether4confirm.Click
        Me.Hide()
        Nether5.Show()
    End Sub

    Private Sub Nether4A_Click(sender As Object, e As EventArgs) Handles Nether4A.Click
        Dim Nether4A As Boolean = False
        Me.Nether4A.BackColor = Color.DarkSeaGreen
        Nether4A = True
    End Sub

    Private Sub Nether4B_Click(sender As Object, e As EventArgs) Handles Nether4B.Click
        Dim Nether4A As Boolean = False, Nether4B As Boolean = False,
            Nether4C As Boolean = False, Nether4D As Boolean = False

        If Not Nether4B Then
            Me.Nether4B.BackColor = Color.IndianRed
            Nether4B = True
            Me.Nether4C.BackColor = Color.IndianRed
            Nether4C = True
        End If
        If Not Nether4A Then
            Me.Nether4A.BackColor = Color.DarkSeaGreen
            Nether4A = True
            Me.Nether4D.BackColor = Color.DarkSeaGreen
            Nether4D = True
        End If
    End Sub

    Private Sub Nether4C_Click(sender As Object, e As EventArgs) Handles Nether4C.Click
        Dim Nether4A As Boolean = False, Nether4B As Boolean = False,
            Nether4C As Boolean = False, Nether4D As Boolean = False

        If Not Nether4C Then
            Me.Nether4C.BackColor = Color.IndianRed
            Nether4C = True
            Me.Nether4B.BackColor = Color.IndianRed
            Nether4B = True
        End If
        If Not Nether4A Then
            Me.Nether4A.BackColor = Color.DarkSeaGreen
            Nether4A = True
            Me.Nether4D.BackColor = Color.DarkSeaGreen
            Nether4D = True
        End If
    End Sub

    Private Sub Nether4D_Click(sender As Object, e As EventArgs) Handles Nether4D.Click
        Dim Nether4D As Boolean = False
        Me.Nether4D.BackColor = Color.DarkSeaGreen
        Nether4D = True
    End Sub
End Class