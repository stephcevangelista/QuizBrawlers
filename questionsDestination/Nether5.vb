Public Class Nether5
    Private Sub Nether5confirm_Click(sender As Object, e As EventArgs) Handles Nether5confirm.Click
        Me.Close()
    End Sub

    Private Sub Nether5A_Click(sender As Object, e As EventArgs) Handles Nether5A.Click
        Dim Nether5A As Boolean = False, Nether5B As Boolean = False,
            Nether5C As Boolean = False, Nether5D As Boolean = False

        If Not Nether5A Then
            Me.Nether5A.BackColor = Color.IndianRed
            Nether5A = True
            Me.Nether5D.BackColor = Color.IndianRed
            Nether5D = True
        End If
        If Not Nether5B Then
            Me.Nether5B.BackColor = Color.DarkSeaGreen
            Nether5B = True
            Me.Nether5C.BackColor = Color.DarkSeaGreen
            Nether5C = True
        End If
    End Sub

    Private Sub Nether5B_Click(sender As Object, e As EventArgs) Handles Nether5B.Click
        Dim Nether5B As Boolean = False
        Me.Nether5B.BackColor = Color.DarkSeaGreen
        Nether5B = True
    End Sub

    Private Sub Nether5C_Click(sender As Object, e As EventArgs) Handles Nether5C.Click
        Dim Nether5C As Boolean = False
        Me.Nether5C.BackColor = Color.DarkSeaGreen
        Nether5C = True
    End Sub

    Private Sub Nether5D_Click(sender As Object, e As EventArgs) Handles Nether5D.Click
        Dim Nether5A As Boolean = False, Nether5B As Boolean = False,
            Nether5C As Boolean = False, Nether5D As Boolean = False

        If Not Nether5D Then
            Me.Nether5D.BackColor = Color.IndianRed
            Nether5D = True
            Me.Nether5A.BackColor = Color.IndianRed
            Nether5A = True
        End If
        If Not Nether5B Then
            Me.Nether5B.BackColor = Color.DarkSeaGreen
            Nether5B = True
            Me.Nether5C.BackColor = Color.DarkSeaGreen
            Nether5C = True
        End If
    End Sub
End Class